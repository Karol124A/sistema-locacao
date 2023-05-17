using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projeto_locadora_2022
{
    public partial class CadastrarAutomovel : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;
        public CadastrarAutomovel()
        {
            InitializeComponent();
            //Desativando TextBox ID
            txt_codigocarro.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);
             
            //Campo Vazio 

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_nomecarro, "Nome do Automóvel"))
                return;

            codigosGerais c5 = new codigosGerais();
            if (c5.campoVazio(txt_cor, "Cor do Automóvel"))
                return;

            codigosGerais c6 = new codigosGerais();
            if (c6.campoVazio(cmb_modelo, "Modelo do Automóvel"))
                return;

            codigosGerais c7 = new codigosGerais();
            if (c7.campoVazio(cmb_marca, "Marca do Automóvel"))
                return;

            //Cadastro de Dados

            try
            {
                string nome, cor, status;
                int marca_id, modelo_id;
                int? ano_fab;
                double? valor;
                double? km;

                nome = txt_nomecarro.Text.ToUpper();
                cor = txt_cor.Text.ToUpper();
                status = cmb_status.Text;



                marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                modelo_id = int.Parse(cmb_modelo.SelectedValue.ToString());





                if (cmb_ano.Text.Length == 0)
                {
                    ano_fab = null;
                }

                else
                {
                    ano_fab = int.Parse(cmb_ano.Text);

                }


                if (txt_valor.Text.Length == 0)
                {
                    valor = null;
                }

                else
                {
                    valor = double.Parse(txt_valor.Text);

                }

                if (txt_km.Text.Length == 0)
                {
                    km = null;
                }

                else
                {
                    km = double.Parse(txt_km.Text);

                }

                string sql_insert = @"insert into tb_automovel  
                                     (
                                        tb_automovel_nome,
                                        tb_automovel_ano_fab,
                                        tb_automovel_cor,
                                        tb_automovel_km,
                                        tb_automovel_valor_d,
                                        tb_automovel_status,
                                        tb_marca_id,
                                        tb_modelo_id
                                     )
                                      values 
                                     (
                                        @automovel_nome,
                                        @automovel_ano_fab,
                                        @automovel_cor,
                                        @automovel_km,
                                        @automovel_valor_d,
                                        @automovel_status,
                                        @marca_id,
                                        @modelo_id
                                     )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@automovel_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_ano_fab", ano_fab);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_cor", cor);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_km", km);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_valor_d", valor);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_status", status);
                executacmdMySql_insert.Parameters.AddWithValue("@marca_id", marca_id);
                executacmdMySql_insert.Parameters.AddWithValue("@modelo_id", modelo_id);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();


                //Fim DataGridView

                con.Close();

                MessageBox.Show("Automóvel cadastrado com sucesso!");

                txt_nomecarro.Clear();
                txt_cor.Clear();
                txt_km.Clear();
                txt_valor.Clear();
                cmb_ano.SelectedIndex = -1;
                cmb_status.SelectedIndex = -1;
                cmb_marca.SelectedIndex = -1;
                cmb_modelo.SelectedIndex = -1;

                this.Hide();
                FormLocacao form_locacao = new FormLocacao();
                form_locacao.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar automóvel! Tente novamente. ");
            }
        }

        private void CadastrarAutomovel_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            DataTable dtResultado_mod = new DataTable();

            //TABELA MODELO
            string sql_select_modelo = "select * from tb_modelo"
                + " order by tb_modelo_id asc";
            MySqlDataAdapter dtAdapter_mod = new MySqlDataAdapter(sql_select_modelo, con);

            dtAdapter_mod.Fill(dtResultado_mod);

            cmb_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_modelo.DataSource = dtResultado_mod;
            cmb_modelo.ValueMember = "tb_modelo_id";
            cmb_modelo.DisplayMember = "tb_modelo_desc";

            cmb_modelo.SelectedItem = null;


            //TABELA MARCA
            string sql_select_marca = "select * from tb_marca  order by tb_marca_id asc";
            MySqlDataAdapter dtAdapter_marca = new MySqlDataAdapter(sql_select_marca, con);

            DataTable dtResultado_marca = new DataTable();

            dtAdapter_marca.Fill(dtResultado_marca);

            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.DataSource = dtResultado_marca;
            cmb_marca.ValueMember = "tb_marca_id";
            cmb_marca.DisplayMember = "tb_marca_nome";

            cmb_marca.SelectedItem = null;
        }
    }
}
