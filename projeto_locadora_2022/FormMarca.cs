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
    public partial class FormMarca : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;
        public FormMarca()
        {
            InitializeComponent();

            //Desativando textBox
            txt_codigo_marca.Enabled = false;

        }

        //Read
        private void FormMarca_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            //Populando o DataGrid

            con.Open();

            string sql_select_marca = @"select tb_marca_id as CÓDIGO,
                                        tb_marca_nome as MARCA,
                                        tb_marca_situacao as 'SITUAÇÃO'
                                        from tb_marca where tb_marca_id <> 5000 and tb_marca_situacao = 'ATIVO'";

            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            adap_marca.Fill(tabela_marca);

            dgv_marca.DataSource = tabela_marca;

            con.Close();
        }

      


        private void dgv_marca_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_marca.Text = dgv_marca.CurrentRow.Cells[0].Value.ToString();
            txt_nome_marca.Text = dgv_marca.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_marca.Enabled = true;
        }


        //DESATIVANDO
        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_marca.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_marca = @"update tb_marca 
                                      set TB_MARCA_situacao = 'DESATIVADO'
                                      where TB_MARCA_ID = @id_marca";

                MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

                executacmdMySql_update_marca.Parameters.AddWithValue("@id_marca", codigo);

                executacmdMySql_update_marca.ExecuteNonQuery();


                //Atualizando dados automaticamente no DataGridView
                string sql_select_marca = @"select tb_marca_id as CÓDIGO,
                                        tb_marca_nome as MARCA,
                                        tb_marca_situacao as 'SITUAÇÃO'
                                        from tb_marca where tb_marca_id <> 5000 and tb_marca_situacao = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                adap_marca.Fill(tabela_marca);

                dgv_marca.DataSource = tabela_marca;

                con.Close();

                MessageBox.Show("Dados desativados com sucesso!!");

                txt_nome_marca.Clear();
                txt_nome_marca.Focus();
                txt_codigo_marca.Clear();
                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados! Tente novamente");
            }
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            //Ativando CampoVazio
            codigosGerais c = new codigosGerais();
            if (c.campoVazio(txt_nome_marca, "Nome da Marca"))
                return;

            //Cadastro
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome_marca;
                nome_marca = txt_nome_marca.Text.ToUpper();

                string sql_insert = @"insert into tb_marca
                                  (
                                    tb_marca_nome
                                  )
                                  values 
                                  (
                                    @marca_nome
                                  )";

                MySqlCommand executar_sql_insert = new MySqlCommand(sql_insert, con);

                executar_sql_insert.Parameters.AddWithValue("@marca_nome", nome_marca);
                con.Open();
                executar_sql_insert.ExecuteNonQuery();


                //DataGridView - Cadastro

                string sql_select_marca = @"select tb_marca_id as CÓDIGO,
                                            tb_marca_nome as MARCA,
                                            tb_marca_situacao as 'SITUAÇÃO'
                                            from tb_marca where tb_marca_id <> 5000 and tb_marca_situacao = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                adap_marca.Fill(tabela_marca);

                dgv_marca.DataSource = tabela_marca;

                con.Close();
                MessageBox.Show("MARCA CADASTRADA!");

                txt_nome_marca.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar marca! Tente novamente");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Desativando textBox
                txt_codigo_marca.Enabled = false;


                int codigo;
                string marca_nome;

                codigo = int.Parse(txt_codigo_marca.Text);
                marca_nome = txt_nome_marca.Text.ToUpper();

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_marca = @"update tb_marca 
                                      set TB_MARCA_NOME = @nome_marca
                                      where TB_MARCA_ID = @id_marca";

                MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

                executacmdMySql_update_marca.Parameters.AddWithValue("@nome_marca", marca_nome);
                executacmdMySql_update_marca.Parameters.AddWithValue("@id_marca", codigo);

                executacmdMySql_update_marca.ExecuteNonQuery();
            //Atualizando dados automaticamente no DataGridView
                string sql_select_marca = @"select tb_marca_id as CÓDIGO,
                                        tb_marca_nome as MARCA,
                                        tb_marca_situacao as 'SITUAÇÃO'
                                        from tb_marca where tb_marca_id <> 5000 and tb_marca_situacao = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                adap_marca.Fill(tabela_marca);

                dgv_marca.DataSource = tabela_marca;

                con.Close();

                MessageBox.Show("Dados Atualizados com sucesso!!");

                txt_nome_marca.Clear();
                txt_nome_marca.Focus();
                txt_codigo_marca.Clear();

                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados! Tente novamente.");
            }
        }
    }
}
