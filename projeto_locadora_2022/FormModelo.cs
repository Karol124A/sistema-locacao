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
    public partial class FormModelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public FormModelo()
        {
            InitializeComponent();

            //Desativando textBox
            txt_codigo_modelo.Enabled = false;
        }
        
        private void FormModelo_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            //Populando o DataGrid

            con.Open();

            string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
                                        tb_modelo_desc as DESCRIÇÃO,
                                        tb_modelo_situacao as 'SITUAÇÃO'
                                        from tb_modelo where tb_modelo_situacao = 'ATIVO'";

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            dgv_modelo.DataSource = tabela_modelo;
            con.Close();

        }


        private void dgv_modelo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_modelo.Text = dgv_modelo.CurrentRow.Cells[0].Value.ToString();
            txt_nome_modelo.Text = dgv_modelo.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_modelo.Enabled = true;
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Ativando CampoVazio
            codigosGerais c = new codigosGerais();
            if (c.campoVazio(txt_nome_modelo, "Nome do Modelo"))
                return;

            try

            {
                MySqlConnection con = new MySqlConnection(conexao);
                string nome_modelo;
                nome_modelo = txt_nome_modelo.Text.ToUpper();

                string sql_insert = @"insert into tb_modelo
                                  (
                                    tb_modelo_desc
                                  )
                                  values 
                                  (
                                    @modelo_nome
                                  )";

                MySqlCommand executar_sql_insert = new MySqlCommand(sql_insert, con);

                executar_sql_insert.Parameters.AddWithValue("@modelo_nome", nome_modelo);
                con.Open();
                executar_sql_insert.ExecuteNonQuery();


                //Ativando DataGridView no Cadastro

                string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
                                            tb_modelo_desc as DESCRIÇÃO,
                                            tb_modelo_situacao as 'SITUAÇÃO'
                                            from tb_modelo where tb_modelo_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_modelo.Fill(tabela_modelo);

                dgv_modelo.DataSource = tabela_modelo;
                con.Close();

                MessageBox.Show("MODELO CADASTRADO!");

                txt_nome_modelo.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar modelo! Tente novamente");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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
                txt_codigo_modelo.Enabled = false;

                int codigo;
                string modelo_nome;

                codigo = int.Parse(txt_codigo_modelo.Text);

                modelo_nome = txt_nome_modelo.Text.ToUpper();

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_modelo = @"update tb_modelo
                                      set TB_MODELO_DESC = @nome_modelo
                                      where TB_MODELO_ID = @id_modelo";

                MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);

                executacmdMySql_update_modelo.Parameters.AddWithValue("@nome_modelo", modelo_nome);
                executacmdMySql_update_modelo.Parameters.AddWithValue("@id_modelo", codigo);

                executacmdMySql_update_modelo.ExecuteNonQuery();


                //Atualizando dados automaticamente no DataGridView
                string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
	                                    tb_modelo_desc as DESCRIÇÃO,
                                        tb_modelo_situacao as 'SITUAÇÃO'
                                        from tb_modelo where tb_modelo_situacao='ATIVO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter adap_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                adap_modelo.Fill(tabela_modelo);

                dgv_modelo.DataSource = tabela_modelo;

                con.Close();

                MessageBox.Show("Dados atualizados com sucesso!!");
                txt_nome_modelo.Clear();
                txt_codigo_modelo.Clear();
                txt_nome_modelo.Focus();
                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados! Tente Novamente");
            }
        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_modelo.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_modelo = @"update tb_modelo
                                      set TB_MODELO_SITUACAO = 'DESATIVADO'
                                      where TB_MODELO_ID = @id_modelo";

                MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);

                executacmdMySql_update_modelo.Parameters.AddWithValue("@id_modelo", codigo);

                executacmdMySql_update_modelo.ExecuteNonQuery();

                //Atualizando dados automaticamente no DataGridView
                string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
                                        tb_modelo_desc as DESCRIÇÃO,
                                        tb_modelo_situacao as 'SITUAÇÃO'
                                        from tb_modelo where tb_modelo_id <> 5000 and tb_modelo_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter adap_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                adap_modelo.Fill(tabela_modelo);

                dgv_modelo.DataSource = tabela_modelo;

                con.Close();

                MessageBox.Show("Dados desativados com sucesso!!");
                txt_nome_modelo.Clear();
                txt_codigo_modelo.Clear();
                txt_nome_modelo.Focus();
                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados! Tente novamente.");
            }
        }
    }   
}
