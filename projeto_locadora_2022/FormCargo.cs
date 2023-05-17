using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;



namespace projeto_locadora_2022
{
    public partial class FormCargo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public FormCargo()
        {
            InitializeComponent();

            //Desativando textBox
            txt_codigo_cargo.Enabled = false;
        }


        private void FormCargo_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            //Populando o DataGrid
            con.Open();

            string sql_select_cargo = @"select tb_cargo_id as CÓDIGO,
	                                    tb_cargo_nome as CARGO,
                                        tb_cargo_situacao as 'SITUAÇÃO'
                                        from tb_cargo where tb_cargo_id <> 5000 and tb_cargo_situacao='ATIVO'";

            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();

            MySqlDataAdapter adap_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            adap_cargo.Fill(tabela_cargo);

            dgv_cargo.DataSource = tabela_cargo;

            con.Close();
        }

        

        private void label14_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
            
        }

        private void dgv_cargo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_cargo.Text = dgv_cargo.CurrentRow.Cells[0].Value.ToString();
            txt_nome_cargo.Text = dgv_cargo.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_cargo.Enabled = true;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            //CADASTRANDO
                //Ativando CampoVazio
                codigosGerais c = new codigosGerais();
                if (c.campoVazio(txt_nome_cargo, "Nome do Cargo"))
                    return;

                try
                {

                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_cargo;
                    nome_cargo = txt_nome_cargo.Text.ToUpper();

                    string sql_insert = @"insert into tb_cargo
                                  (
                                    tb_cargo_nome
                                  )
                                  values 
                                  (
                                    @cargo_nome
                                  )";

                    MySqlCommand executar_sql_insert = new MySqlCommand(sql_insert, con);

                    executar_sql_insert.Parameters.AddWithValue("@cargo_nome", nome_cargo);
                    con.Open();
                    executar_sql_insert.ExecuteNonQuery();

                    //Ativando DataGridView no Cadastro

                    string sql_select_cargo = @"select tb_cargo_id as CÓDIGO,
                                            tb_cargo_nome as CARGO,
                                            tb_cargo_situacao as 'SITUAÇÃO'
                                            from tb_cargo where tb_cargo_id <> 5000 and tb_cargo_situacao = 'ATIVO'";

                    MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                    executacmdMySql_select_cargo.ExecuteNonQuery();

                    DataTable tabela_cargo = new DataTable();

                    MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                    da_cargo.Fill(tabela_cargo);

                    dgv_cargo.DataSource = tabela_cargo;
                    con.Close();

                    MessageBox.Show("CARGO CADASTRADO!");

                    txt_nome_cargo.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar cargo");
                }
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        //ATUALIZANDO
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Desativando textBox
                txt_codigo_cargo.Enabled = false;

                int codigo;
                string cargo_nome;

                codigo = int.Parse(txt_codigo_cargo.Text);

                cargo_nome = txt_nome_cargo.Text.ToUpper();

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cargo = @"update tb_cargo
                                      set TB_CARGO_NOME = @nome_cargo
                                      where TB_CARGO_ID = @id_cargo";

                MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                executacmdMySql_update_cargo.Parameters.AddWithValue("@nome_cargo", cargo_nome);
                executacmdMySql_update_cargo.Parameters.AddWithValue("@id_cargo", codigo);
                executacmdMySql_update_cargo.ExecuteNonQuery();



                //Atualizando dados automaticamente no DataGridView
                string sql_select_cargo = @"select tb_cargo_id as CÓDIGO,
                                        tb_cargo_nome as CARGO,
                                        tb_cargo_situacao as 'SITUAÇÃO'
                                        from tb_cargo where tb_cargo_id <> 5000 and tb_cargo_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter adap_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                adap_cargo.Fill(tabela_cargo);

                dgv_cargo.DataSource = tabela_cargo;

                con.Close();

                MessageBox.Show("Dados Atualizados com sucesso!!");

                txt_nome_cargo.Clear();
                txt_codigo_cargo.Clear();
                txt_nome_cargo.Focus();
                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados, tente novamente.");
            }
        }

        //DESATIVANDO
        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_cargo.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cargo = @"update tb_cargo
                                      set TB_CARGO_SITUACAO = 'DESATIVADO'
                                      where TB_CARGO_ID = @id_cargo";

                MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                executacmdMySql_update_cargo.Parameters.AddWithValue("@id_cargo", codigo);

                executacmdMySql_update_cargo.ExecuteNonQuery();

                //Atualizando dados automaticamente no DataGridView
                string sql_select_cargo = @"select tb_cargo_id as CÓDIGO,
                                        tb_cargo_nome as CARGO,
                                        tb_cargo_situacao as 'SITUAÇÃO'
                                        from tb_cargo where tb_cargo_id <> 5000 and tb_cargo_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter adap_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                adap_cargo.Fill(tabela_cargo);

                dgv_cargo.DataSource = tabela_cargo;

                con.Close();

                MessageBox.Show("Dados desativados com sucesso!!");

                txt_nome_cargo.Clear();
                txt_codigo_cargo.Clear();
                txt_nome_cargo.Focus();
                //fim
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados");
            }
        }
    }
}
