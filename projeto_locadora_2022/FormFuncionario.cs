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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace projeto_locadora_2022
{
    public partial class FormFuncionario : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;
        public FormFuncionario()
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


                //Populando DataGridView

                string sql_select_func = @"select
                                          tb_funcionario_nome as NOME,
                                          tb_funcionario_tel as TELEFONE,      
                                          tb_cargo_id as CARGO,
                                          tb_funcionario_dt_contrato as 'DATA DO CONTRATO'
                                          from tb_funcionario where tb_funcionario_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_func = new MySqlCommand(sql_select_func, con);

                executacmdMySql_select_func.ExecuteNonQuery();

                DataTable tb_func = new DataTable();

                MySqlDataAdapter adapter_func = new MySqlDataAdapter(executacmdMySql_select_func);

                adapter_func.Fill(tb_func);

                dgv_funcionario.DataSource = tb_func;

                //Fim DataGridView


                con.Close();


                MessageBox.Show("Funcionário cadastrado com sucesso!");

                txt_nome_funcionario.Clear();
                txt_telefone.Clear();
                cmb_cargo.SelectedIndex = -1;
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar funcionário! Tente novamente. ");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
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
                con.Open();

                string nome, tel;
                int cargo_id, codigo;
                DateTime data_contrato;


                nome = txt_nome_funcionario.Text.ToUpper();
                cargo_id = int.Parse(cmb_cargo.SelectedValue.ToString());
                codigo = int.Parse(txt_codigo_funcionario.Text);
                tel = txt_telefone.Text.ToUpper();

                data_contrato = Convert.ToDateTime(dtp_contrato.Text);

                DateTimePicker data = new DateTimePicker();
                data.Value = DateTime.Now.Date;

                string sql_update_funcionario = @"update tb_funcionario
                                      set TB_FUNCIONARIO_NOME = @funcionario_nome,
                                          TB_FUNCIONARIO_TEL = @funcionario_tel,      
                                          TB_CARGO_ID = @cargo_id,
                                          TB_FUNCIONARIO_DT_CONTRATO = @funcionario_dt_contrato
                                       where TB_FUNCIONARIO_ID = @funcionario_id";

                MySqlCommand executacmdMysql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

                executacmdMysql_update_funcionario.Parameters.AddWithValue("@funcionario_id", codigo);
                executacmdMysql_update_funcionario.Parameters.AddWithValue("@funcionario_nome", nome);
                executacmdMysql_update_funcionario.Parameters.AddWithValue("@funcionario_tel", tel);
                executacmdMysql_update_funcionario.Parameters.AddWithValue("@funcionario_dt_contrato", data_contrato);
                executacmdMysql_update_funcionario.Parameters.AddWithValue("@cargo_id", cargo_id);


                executacmdMysql_update_funcionario.ExecuteNonQuery();


                //Populando DataGridView

                string sql_select_funcionario = @"select
                                          tb_funcionario_nome as NOME,
                                          tb_funcionario_tel as TELEFONE,      
                                          tb_cargo_id as CARGO,
                                          tb_funcionario_dt_contrato as 'DATA DO CONTRATO'
                                          from tb_funcionario where tb_funcionario_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_func = new MySqlCommand(sql_select_funcionario, con);

                executacmdMySql_select_func.ExecuteNonQuery();

                DataTable tb_func = new DataTable();

                MySqlDataAdapter adapter_func = new MySqlDataAdapter(executacmdMySql_select_func);

                adapter_func.Fill(tb_func);

                dgv_funcionario.DataSource = tb_func;

                //Fim DataGridView


                con.Close();


                MessageBox.Show("Funcionário atualizado com sucesso!");

                txt_codigo_funcionario.Clear();
                txt_nome_funcionario.Clear();
                txt_telefone.Clear();
                cmb_cargo.SelectedIndex = -1;
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados! Tente novamente.");
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
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



            //Populando DataGridView

            con.Open();

            string sql_select_func = "select * from tb_funcionario where tb_funcionario_situacao = 'ATIVO'";

            MySqlCommand executacmdMySql_select_func = new MySqlCommand(sql_select_func, con);

            executacmdMySql_select_func.ExecuteNonQuery();

            DataTable tb_func = new DataTable();

            MySqlDataAdapter adapter_func = new MySqlDataAdapter(executacmdMySql_select_func);

            adapter_func.Fill(tb_func);

            dgv_funcionario.DataSource = tb_func;

            con.Close();

            //Fim DataGridView
        }

        private void dgv_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_funcionario.Text = dgv_funcionario.CurrentRow.Cells[0].Value.ToString();
            txt_nome_funcionario.Text = dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_telefone.Text = dgv_funcionario.CurrentRow.Cells[2].Value.ToString();
            dtp_contrato.Text = dgv_funcionario.CurrentRow.Cells[3].Value.ToString();
            cmb_cargo.Text = dgv_funcionario.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_funcionario.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_funcionario = @"update tb_funcionario
                                      set TB_FUNCIONARIO_situacao = 'DESATIVADO'
                                      where TB_FUNCIONARIO_ID = @id_FUNCIONARIO";

                MySqlCommand executacmdMysql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

                executacmdMysql_update_funcionario.Parameters.AddWithValue("@id_funcionario", codigo);

                executacmdMysql_update_funcionario.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Funcionário desativado com sucesso!");

                txt_codigo_funcionario.Clear();
                txt_nome_funcionario.Clear();
                txt_telefone.Clear();
                cmb_cargo.SelectedIndex = -1;
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados! Tente novamente");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void novo_cargo_Click(object sender, EventArgs e)
        {
            CadastrarCargo cadastrar_cargo = new CadastrarCargo();
            cadastrar_cargo.ShowDialog();
        }
    }
}
