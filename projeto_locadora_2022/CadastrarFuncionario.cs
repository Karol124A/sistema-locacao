using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace projeto_locadora_2022
{
    public partial class CadastrarFuncionario : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;
        public CadastrarFuncionario()
        {
            InitializeComponent();

            //Desativando TextBox ID
            txt_codigo_funcionario.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Campo Vazio 

            codigosGerais c = new codigosGerais();
            if (c.campoVazio(txt_nome_funcionario, "Nome do Funcionário"))
                return;

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(cmb_cargo, "Cargo"))
                return;

            //Cadastro de Funcionários
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, tel;
                int cargo_id;
                DateTime data_contrato;


                nome = txt_nome_funcionario.Text.ToUpper();
                cargo_id = int.Parse(cmb_cargo.SelectedValue.ToString());
                tel = txt_telefone.Text.ToUpper();

                data_contrato = Convert.ToDateTime(dtp_contrato.Text);

                DateTimePicker data = new DateTimePicker();
                data.Value = DateTime.Now.Date;

                string sql_insert = @"insert into tb_funcionario
                                  (
                                    tb_funcionario_nome,
                                    tb_funcionario_tel,
                                    tb_funcionario_dt_contrato,
                                    tb_cargo_id
                                   )
                                   values 
                                   (
                                    @funcionario_nome,
                                    @funcionario_tel,
                                    @funcionario_dt_contrato, 
                                    @cargo_id
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_tel", tel);
                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_dt_contrato", data_contrato);
                executacmdMySql_insert.Parameters.AddWithValue("@cargo_id", cargo_id);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Funcionário cadastrado com sucesso!");

                this.Hide();
                FormLocacao form_locacao = new FormLocacao();
                form_locacao.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar funcionário! Tente novamente. ");
            }
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect = "select * from tb_cargo where tb_cargo_situacao = 'ATIVO' order by tb_cargo_nome asc";
            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(sqlselect, con);
            DataTable dtResultado = new DataTable();

            dtAdapter.Fill(dtResultado);

            cmb_cargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cargo.DataSource = dtResultado;
            cmb_cargo.ValueMember = "tb_cargo_id";
            cmb_cargo.DisplayMember = "tb_cargo_nome";

            cmb_cargo.SelectedItem = null;
        }
    }
}
