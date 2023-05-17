using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace projeto_locadora_2022
{
    public partial class FormDesativados : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;
        public FormDesativados()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
            this.Hide();
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_cliente.Text = dgv_cliente.CurrentRow.Cells[0].Value.ToString();
            txt_cliente.Text = dgv_cliente.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_cliente.Enabled = true;
        }

        private void dgv_modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_modelo.Text = dgv_modelo.CurrentRow.Cells[0].Value.ToString();
            txt_modelo.Text = dgv_modelo.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_modelo.Enabled = true;
        }

        private void dgv_marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_marca.Text = dgv_marca.CurrentRow.Cells[0].Value.ToString();
            txt_marca.Text = dgv_marca.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_marca.Enabled = true;
        }

        private void dgv_cargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_cargo.Text = dgv_cargo.CurrentRow.Cells[0].Value.ToString();
            txt_cargo.Text = dgv_cargo.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_cargo.Enabled = true;
        }

        private void FormDesativados_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);


            //Ativando DataGridView 

            con.Open();
            string sql_select_cliente = @"select tb_cliente_id as CÓDIGO,
                                            tb_cliente_nome as NOME, 	
	                                        tb_cliente_tel as TELEFONE,
                                            tb_cliente_sexo as SEXO,
                                            tb_cliente_email as EMAIL,
                                            tb_cliente_senha as SENHA,
                                            tb_cliente_endereco as ENDERECO,
                                            tb_cliente_complemento as COMPLEMENTO,
                                            tb_cliente_bairro as BAIRRO,
                                            tb_cliente_cidade as CIDADE, 
                                            tb_cliente_uf as UF,
                                            tb_cliente_dt_nasc as 'DATA DE NASCIMENTO',
                                            tb_cliente_dt_cad as 'DATA DE CADASTRO',
                                            tb_cliente_situacao as 'SITUAÇÃO'
                                            from tb_cliente where tb_cliente_id <> 5000 and tb_cliente_situacao = 'DESATIVADO'
            ";

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;

            //CARGO

            string sql_select_cargo = @"select tb_cargo_id as CÓDIGO,
	                                    tb_cargo_nome as CARGO,
                                        tb_cargo_situacao as 'SITUAÇÃO'
                                        from tb_cargo where tb_cargo_id <> 5000 and tb_cargo_situacao='DESATIVADO'";

            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();

            MySqlDataAdapter adap_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            adap_cargo.Fill(tabela_cargo);

            dgv_cargo.DataSource = tabela_cargo;

            //MARCA

            string sql_select_marca = @"select tb_marca_id as CÓDIGO,
                                        tb_marca_nome as MARCA,
                                        tb_marca_situacao as 'SITUAÇÃO'
                                        from tb_marca where tb_marca_id <> 5000 and tb_marca_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            adap_marca.Fill(tabela_marca);

            dgv_marca.DataSource = tabela_marca;

            //MODELO

            string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
                                        tb_modelo_desc as DESCRIÇÃO,
                                        tb_modelo_situacao as 'SITUAÇÃO'
                                        from tb_modelo where tb_modelo_id <> 5000 and tb_modelo_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            dgv_modelo.DataSource = tabela_modelo;


            //AUTOMOVEL

            string sql_select_autom = @"select tb_automovel_id as 'CÓDIGO',
	                                        tb_automovel_nome as 'NOME',
                                            tb_automovel_ano_fab as 'ANO DE FABRICAÇÃO',
                                            tb_automovel_cor as 'COR',
                                            tb_automovel_km as 'KILOMETRAGEM', 
                                            tb_automovel_valor_d as 'VALOR DA DIÁRIA',
                                            tb_automovel_status as 'STATUS',
                                            tb_marca.tb_marca_nome as 'MARCA', 
                                            tb_modelo.tb_modelo_desc as 'MODELO', 
                                            tb_automovel_situacao as 'SITUAÇÃO'
                                            from tb_automovel
                                            inner join tb_marca
                                            on tb_automovel.tb_marca_id = tb_marca.tb_marca_id
                                            inner join tb_modelo
                                            on tb_automovel.tb_modelo_id = tb_modelo.tb_modelo_id
                                            where tb_marca_nome <> 'NOVO' and tb_automovel_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_autom = new MySqlCommand(sql_select_autom, con);

            executacmdMySql_select_autom.ExecuteNonQuery();

            DataTable tb_automovel = new DataTable();

            MySqlDataAdapter adapter_autom = new MySqlDataAdapter(executacmdMySql_select_autom);

            adapter_autom.Fill(tb_automovel);

            dgv_automoveis.DataSource = tb_automovel;


            //FUNCIONARIO
            string sql_select_funcionario = @"select tb_funcionario.TB_FUNCIONARIO_ID as 'CÓDIGO',
	                                           tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME',
                                               tb_funcionario.TB_FUNCIONARIO_TEL as 'TELEFONE',
                                               tb_funcionario.TB_FUNCIONARIO_DT_CONTRATO as 'DATA DE CONTRATO',
                                               tb_cargo.TB_CARGO_NOME as 'CARGO',
                                               tb_funcionario.TB_FUNCIONARIO_SITUACAO as 'SITUAÇÃO'
                                               from tb_funcionario
                                               inner join tb_cargo
                                               on tb_funcionario.TB_CARGO_ID = tb_cargo.TB_CARGO_ID
                                               where tb_funcionario_id <> 5000 and tb_funcionario_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_func = new MySqlCommand(sql_select_funcionario, con);

            executacmdMySql_select_func.ExecuteNonQuery();

            DataTable tb_func = new DataTable();

            MySqlDataAdapter adapter_func = new MySqlDataAdapter(executacmdMySql_select_func);

            adapter_func.Fill(tb_func);

            dgv_funcionarios.DataSource = tb_func;



            //LOCAÇÃO
          
            string sql_select_locacao = @"select tb_locacao_id as 'CÓDIGO',
	                                       tb_locacao_tipo as 'TIPO', 
                                           tb_locacao_valor as 'VALOR DA DIÁRIA',
                                           tb_locacao_dt_inicio as 'INÍCIO',
                                           tb_locacao_dt_fim as 'FIM', 
                                           tb_cliente.tb_cliente_nome as 'CLIENTE', 
                                           tb_funcionario.tb_funcionario_nome as 'FUNCIONÁRIO',
                                           tb_automovel.tb_automovel_nome as 'VEÍCULO',
                                           tb_locacao_situacao as 'SITUAÇÃO'
                                           from tb_locacao
                                           inner join tb_cliente
                                           on tb_locacao.tb_cliente_id = tb_cliente.tb_cliente_id
                                           inner join tb_funcionario
                                           on tb_locacao.tb_funcionario_id = tb_funcionario.tb_funcionario_id
                                           inner join tb_automovel
                                           on tb_locacao.tb_automovel_id = tb_automovel.tb_automovel_id
                                           where tb_locacao.tb_locacao_situacao= 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tb_locacao = new DataTable();

            MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

            adapter_loc.Fill(tb_locacao);

            dgv_locacao.DataSource = tb_locacao;


            con.Close();
        }


        private void btn_ativar_cargo_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_cargo.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cargo = @"update tb_cargo
                                      set TB_CARGO_situacao = 'ATIVO'
                                      where TB_CARGO_ID = @id_cargo";

                MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                executacmdMySql_update_cargo.Parameters.AddWithValue("@id_cargo", codigo);

                executacmdMySql_update_cargo.ExecuteNonQuery();

                //Ativando DataGridView 

                string sql_select_cargo = @"select tb_cargo_id as CÓDIGO, 
                                        tb_cargo_nome as CARGO,
                                        tb_cargo_situacao as 'SITUAÇÃO' from tb_cargo
                                        where tb_cargo_id <> 5000 and tb_cargo_situacao='DESATIVADO'";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter adap_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                adap_cargo.Fill(tabela_cargo);

                dgv_cargo.DataSource = tabela_cargo;

                con.Close();
                MessageBox.Show("Dados ativados com sucesso!");
                txt_codigo_cargo.Clear();
                txt_cargo.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao ativar dados! Tente novamente");
            }
        }

        private void btn_ativar_marca_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_marca.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_marca = @"update tb_marca
                                      set TB_MARCA_situacao = 'ATIVO'
                                      where TB_MARCA_ID = @id_marca";

                MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

                executacmdMySql_update_marca.Parameters.AddWithValue("@id_marca", codigo);

                executacmdMySql_update_marca.ExecuteNonQuery();

                //Ativando DataGridView 

                string sql_select_marca = @"select tb_marca_id as CÓDIGO, 
                                        tb_marca_nome as MARCA,
                                        tb_marca_situacao as 'SITUAÇÃO' from tb_marca
                                        where tb_marca_situacao='DESATIVADO'";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter adap_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                adap_marca.Fill(tabela_marca);

                dgv_marca.DataSource = tabela_marca;



                con.Close();
                MessageBox.Show("Dados ativos com sucesso!");
                txt_codigo_marca.Clear();
                txt_modelo.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao ativar dados! Tente novamente.");
            }
        }

        private void btn_ativar_modelo_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigo_modelo.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_modelo = @"update tb_modelo
                                      set TB_MODELO_situacao = 'ATIVO'
                                      where TB_MODELO_ID = @id_modelo";

                MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);

                executacmdMySql_update_modelo.Parameters.AddWithValue("@id_modelo", codigo);

                executacmdMySql_update_modelo.ExecuteNonQuery();

                //Ativando DataGridView 

                string sql_select_modelo = @"select tb_modelo_id as CÓDIGO,
                                         tb_modelo_desc as DESCRIÇÃO,
                                         tb_modelo_situacao as 'SITUAÇÃO'
                                         from tb_modelo where tb_modelo_situacao = 'DESATIVADO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter adap_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                adap_modelo.Fill(tabela_modelo);

                dgv_modelo.DataSource = tabela_modelo;




                con.Close();
                MessageBox.Show("Dados ativos com sucesso!");
                txt_codigo_modelo.Clear();
                txt_modelo.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao ativar dados! Tente novamente.");
            }


        }

        private void label14_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void btn_sair_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void btn_ativar_cliente_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txt_codigo_cliente.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cliente = @"update tb_cliente
                                      set TB_CLIENTE_situacao = 'ATIVO'
                                      where TB_CLIENTE_ID = @id_cliente";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);

            executacmdMySql_update_cliente.Parameters.AddWithValue("@id_cliente", codigo);

            executacmdMySql_update_cliente.ExecuteNonQuery();

            //Ativando DataGridView 

            string sql_select_cliente = @"select tb_cliente_id as CÓDIGO,
	                                     tb_cliente_nome as NOME, 	
	                                     tb_cliente_tel as TELEFONE,
                                         tb_cliente_sexo as SEXO,
                                         tb_cliente_email as EMAIL,
                                         tb_cliente_senha as SENHA,
                                         tb_cliente_endereco as ENDERECO,
                                         tb_cliente_complemento as COMPLEMENTO,
                                         tb_cliente_bairro as BAIRRO,
                                         tb_cliente_cidade as CIDADE, 
                                         tb_cliente_uf as UF,
                                         tb_cliente_dt_nasc as 'DATA DE NASCIMENTO',
                                         tb_cliente_dt_cad as 'DATA DE CADASTRO',
                                         tb_cliente_situacao as 'SITUAÇÃO'
                                         from tb_cliente where tb_cliente_id <> 5000 and tb_cliente_situacao='DESATIVADO'";

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter adap_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            adap_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;

            con.Close();
            MessageBox.Show("Dados ativados com sucesso!");
            txt_codigo_cliente.Clear();
            txt_cliente.Clear();
        }

        private void dgv_automoveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_automovel.Text = dgv_automoveis.CurrentRow.Cells[0].Value.ToString();
            txt_automovel.Text = dgv_automoveis.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_automovel.Enabled = true;
        }

        private void btn_ativar_automovel_Click(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txt_codigo_automovel.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_autom = @"update tb_automovel
                                      set TB_automovel_situacao = 'ATIVO'
                                      where TB_automovel_ID = @id_automovel";

            MySqlCommand executacmdMySql_update_autom = new MySqlCommand(sql_update_autom, con);

            executacmdMySql_update_autom.Parameters.AddWithValue("@id_automovel", codigo);

            executacmdMySql_update_autom.ExecuteNonQuery();

            //Ativando DataGridView 

            string sql_select_autom = @"select tb_automovel_id as 'CÓDIGO',
	                                        tb_automovel_nome as 'NOME',
                                            tb_automovel_ano_fab as 'ANO DE FABRICAÇÃO',
                                            tb_automovel_cor as 'COR',
                                            tb_automovel_km as 'KILOMETRAGEM', 
                                            tb_automovel_valor_d as 'VALOR DA DIÁRIA',
                                            tb_automovel_status as 'STATUS',
                                            tb_marca.tb_marca_nome as 'MARCA', 
                                            tb_modelo.tb_modelo_desc as 'MODELO', 
                                            tb_automovel_situacao as 'SITUAÇÃO'
                                            from tb_automovel
                                            inner join tb_marca
                                            on tb_automovel.tb_marca_id = tb_marca.tb_marca_id
                                            inner join tb_modelo
                                            on tb_automovel.tb_modelo_id = tb_modelo.tb_modelo_id
                                            where tb_marca_nome <> 'NOVO' and tb_automovel_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_autom = new MySqlCommand(sql_select_autom, con);

            executacmdMySql_select_autom.ExecuteNonQuery();

            DataTable tb_automovel = new DataTable();

            MySqlDataAdapter adapter_autom = new MySqlDataAdapter(executacmdMySql_select_autom);

            adapter_autom.Fill(tb_automovel);

            dgv_automoveis.DataSource = tb_automovel;

            //Fim DataGridView

            con.Close();
            MessageBox.Show("Dados ativados com sucesso!");
            txt_codigo_automovel.Clear();
            txt_automovel.Clear();
        }

        private void dgv_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_funcionario.Text = dgv_funcionarios.CurrentRow.Cells[0].Value.ToString();
            txt_funcionario.Text = dgv_funcionarios.CurrentRow.Cells[1].Value.ToString();

            //Ativando textBox
            txt_codigo_funcionario.Enabled = true;
        }

        private void btn_ativar_funcionario_Click(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txt_codigo_funcionario.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_funcionario = @"update tb_funcionario
                                      set TB_FUNCIONARIO_situacao = 'ATIVO'
                                      where TB_FUNCIONARIO_ID = @id_FUNCIONARIO";

            MySqlCommand executacmdMysql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

            executacmdMysql_update_funcionario.Parameters.AddWithValue("@id_funcionario", codigo);

            executacmdMysql_update_funcionario.ExecuteNonQuery();

            //Populando DataGridView

            string sql_select_funcionario = @"select tb_funcionario.TB_FUNCIONARIO_ID as 'CÓDIGO',
	                                           tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME',
                                               tb_funcionario.TB_FUNCIONARIO_TEL as 'TELEFONE',
                                               tb_funcionario.TB_FUNCIONARIO_DT_CONTRATO as 'DATA DE CONTRATO',
                                               tb_cargo.TB_CARGO_NOME as 'CARGO',
                                               tb_funcionario.TB_FUNCIONARIO_SITUACAO as 'SITUAÇÃO'
                                               from tb_funcionario
                                               inner join tb_cargo
                                               on tb_funcionario.TB_CARGO_ID = tb_cargo.TB_CARGO_ID
                                               where tb_funcionario_id <> 5000 and tb_funcionario_situacao = 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_func = new MySqlCommand(sql_select_funcionario, con);

            executacmdMySql_select_func.ExecuteNonQuery();

            DataTable tb_func = new DataTable();

            MySqlDataAdapter adapter_func = new MySqlDataAdapter(executacmdMySql_select_func);

            adapter_func.Fill(tb_func);

            dgv_funcionarios.DataSource = tb_func;

            //Fim DataGridView


            con.Close();


            MessageBox.Show("Funcionário ativado com sucesso!");

            txt_codigo_funcionario.Clear();
            txt_funcionario.Clear();
        }

        private void dgv_locacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_locacao.Text = dgv_locacao.CurrentRow.Cells[0].Value.ToString();

            //Ativando textBox
            txt_codigo_locacao.Enabled = true;
        }

        private void btn_ativar_locacao_Click(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txt_codigo_funcionario.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_locacao = @"update tb_locacao
                                      set TB_LOCACAO_SITUACAO = 'ATIVO'
                                      where TB_LOCACAO_ID = @ID_LOCACAO";

            MySqlCommand executacmdMysql_update_locacao = new MySqlCommand(sql_update_locacao, con);

            executacmdMysql_update_locacao.Parameters.AddWithValue("@id_locacao", codigo);

            executacmdMysql_update_locacao.ExecuteNonQuery();

            //Populando DataGridView
            string sql_select_locacao = @"select tb_locacao_id as 'CÓDIGO',
	                                       tb_locacao_tipo as 'TIPO', 
                                           tb_locacao_valor as 'VALOR DA DIÁRIA',
                                           tb_locacao_dt_inicio as 'INÍCIO',
                                           tb_locacao_dt_fim as 'FIM', 
                                           tb_cliente.tb_cliente_nome as 'CLIENTE', 
                                           tb_funcionario.tb_funcionario_nome as 'FUNCIONÁRIO',
                                           tb_automovel.tb_automovel_nome as 'VEÍCULO',
                                           tb_locacao_situacao as 'SITUAÇÃO'
                                           from tb_locacao
                                           inner join tb_cliente
                                           on tb_locacao.tb_cliente_id = tb_cliente.tb_cliente_id
                                           inner join tb_funcionario
                                           on tb_locacao.tb_funcionario_id = tb_funcionario.tb_funcionario_id
                                           inner join tb_automovel
                                           on tb_locacao.tb_automovel_id = tb_automovel.tb_automovel_id
                                           where tb_locacao.tb_locacao_situacao= 'DESATIVADO'";

            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tb_locacao = new DataTable();

            MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

            adapter_loc.Fill(tb_locacao);

            dgv_locacao.DataSource = tb_locacao;

            con.Close();

            MessageBox.Show("Locação ativada com sucesso!");

            txt_codigo_locacao.Clear();
        }
    }
}
