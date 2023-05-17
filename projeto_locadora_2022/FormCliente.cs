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
    public partial class FormCliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public FormCliente()
        {
            InitializeComponent();

            //Desativando textBox
            txt_codigocliente.Enabled = false;
        }


        private void FormCliente_Load(object sender, EventArgs e)
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
                                            from tb_cliente where tb_cliente_situacao = 'ATIVO'
            ";

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            dgv_cliente.DataSource = tabela_cliente;

            con.Close();
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigocliente.Text = dgv_cliente.CurrentRow.Cells[0].Value.ToString();
            txt_nomecliente.Text = dgv_cliente.CurrentRow.Cells[1].Value.ToString();
            txt_telefone.Text = dgv_cliente.CurrentRow.Cells[2].Value.ToString();
            cmb_sexo.Text = dgv_cliente.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dgv_cliente.CurrentRow.Cells[4].Value.ToString();
            txt_senha.Text = dgv_cliente.CurrentRow.Cells[5].Value.ToString();
            txt_endereco.Text = dgv_cliente.CurrentRow.Cells[6].Value.ToString();
            txt_complemento.Text = dgv_cliente.CurrentRow.Cells[7].Value.ToString();
            txt_bairro.Text = dgv_cliente.CurrentRow.Cells[8].Value.ToString();
            txt_cidade.Text = dgv_cliente.CurrentRow.Cells[9].Value.ToString();
            cmb_uf.Text = dgv_cliente.CurrentRow.Cells[10].Value.ToString();
            dtp_nascimento.Text = dgv_cliente.CurrentRow.Cells[11].Value.ToString();
            dtp_cadastrado.Text = dgv_cliente.CurrentRow.Cells[12].Value.ToString();

            //Ativando textBox
            txt_codigocliente.Enabled = true;
        }


        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            // Ativando CampoVazio
            codigosGerais c = new codigosGerais();
            if (c.campoVazio(txt_nomecliente, "Nome do Cliente"))
                return;

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_cidade, "Cidade"))
                return;


            codigosGerais c2 = new codigosGerais();
            if (c2.campoVazio(txt_bairro, "Bairro"))
                return;


            codigosGerais c3 = new codigosGerais();
            if (c3.campoVazio(dtp_nascimento, "Data de Nascimento"))
                return;

            codigosGerais c4 = new codigosGerais();
            if (c4.campoVazio(dtp_cadastrado, "Data de Cadastro"))
                return;

            codigosGerais c5 = new codigosGerais();
            if (c5.campoVazio(txt_telefone, "Telefone"))
                return;

           // codigosGerais c6 = new codigosGerais();
           // if (c6.campoVazio(dtp_cadastrado, "Data de Cadastro"))
               // return;

            codigosGerais c7 = new codigosGerais();
            if (c7.campoVazio(txt_endereco, "Logradouro"))
                return;

           // codigosGerais c8 = new codigosGerais();
           // if (c8.campoVazio(dtp_cadastrado, "Data de Cadastro"))
               // return;

            codigosGerais c9 = new codigosGerais();
            if (c9.campoVazio(cmb_uf, "Unidade Federativa"))
                return;

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, tel, sexo, email, senha, endereco, complemento, bairro, cidade, uf;
                DateTime dtp_cadastro, dtp_nasc;


                nome = txt_nomecliente.Text.ToUpper();
                tel = txt_telefone.Text.ToUpper();
                sexo = cmb_sexo.Text.ToUpper();
                email = txt_email.Text.ToUpper();
                senha = txt_senha.Text.ToUpper();
                endereco = txt_endereco.Text.ToUpper();
                complemento = txt_complemento.Text.ToUpper();
                bairro = txt_bairro.Text.ToUpper();
                cidade = txt_cidade.Text.ToUpper();
                uf = cmb_uf.Text.ToUpper();
                dtp_cadastro = Convert.ToDateTime(dtp_cadastrado.Text);
                dtp_nasc = Convert.ToDateTime(dtp_nascimento.Text);




                string sql_insert = @"insert into tb_cliente
                                  (
                                    tb_cliente_nome,
                                    tb_cliente_tel, 
                                    tb_cliente_sexo, 
                                    tb_cliente_email,
                                    tb_cliente_senha,
                                    tb_cliente_endereco,
                                    tb_cliente_complemento,
                                    tb_cliente_bairro,
                                    tb_cliente_cidade,  
                                    tb_cliente_uf,
                                    tb_cliente_dt_nasc,
                                    tb_cliente_dt_cad
                                   )
                                   values 
                                   (
                                    @tb_cliente_nome, 
                                    @tb_cliente_tel,
                                    @tb_cliente_sexo,
                                    @tb_cliente_email,
                                    @tb_cliente_senha, 
                                    @tb_cliente_endereco,
                                    @tb_cliente_complemento,
                                    @tb_cliente_bairro,
                                    @tb_cliente_cidade,
                                    @tb_cliente_uf,
                                    @tb_cliente_dt_nasc,
                                    @tb_cliente_dt_cad
                                    )";

                MySqlCommand executar_sql_insert = new MySqlCommand(sql_insert, con);

                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_nome", nome);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_tel", tel);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_sexo", sexo);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_email", email);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_senha", senha);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_endereco", endereco);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_complemento", complemento);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_bairro", bairro);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_cidade", cidade);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_uf", uf);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_dt_nasc", dtp_nasc);
                executar_sql_insert.Parameters.AddWithValue("@tb_cliente_dt_cad", dtp_cadastro);

                con.Open();
                executar_sql_insert.ExecuteNonQuery();

                //Ativando DataGridView no Cadastro

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
                                            from tb_cliente where tb_cliente_situacao = 'ATIVO'
            ";

                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);

                dgv_cliente.DataSource = tabela_cliente;


                txt_nomecliente.Clear();
                txt_telefone.Clear();
                cmb_sexo.Text = string.Empty;
                cmb_sexo.Items.Clear();
                txt_email.Clear();
                txt_senha.Clear();
                txt_endereco.Clear();
                txt_complemento.Clear();
                txt_bairro.Clear();
                txt_cidade.Clear();
                dtp_cadastrado.ResetText();
                dtp_nascimento.ResetText();

                cmb_uf.Text = string.Empty;
                cmb_uf.Items.Clear();

                con.Close();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar cliente");
            }
        }

        private void btn_atualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Desativando textBox
                txt_codigocliente.Enabled = false;

                int codigo;
                string cliente_nome;
                string tel_cliente;
                string sexo;
                string email;
                string senha;
                string endereco;
                string complemento;
                string bairro;
                string cidade;
                string uf;
                DateTime dtp_cadastro, dtp_nasc;


                codigo = int.Parse(txt_codigocliente.Text);
                cliente_nome = txt_nomecliente.Text.ToUpper();
                tel_cliente = txt_telefone.Text.ToUpper();
                sexo = cmb_sexo.Text;
                email = txt_email.Text.ToUpper();
                senha = txt_senha.Text.ToUpper();
                endereco = txt_endereco.Text.ToUpper();
                complemento = txt_complemento.Text.ToUpper();
                bairro = txt_bairro.Text.ToUpper();
                cidade = txt_cidade.Text.ToUpper();
                uf = cmb_uf.Text;
                dtp_nasc = Convert.ToDateTime(dtp_nascimento.Text);
                dtp_cadastro = Convert.ToDateTime(dtp_cadastrado.Text);



                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cliente = @"update tb_cliente
                                      set TB_CLIENTE_NOME = @nome_cliente,
                                          TB_CLIENTE_TEL = @tel_cliente,
                                          TB_CLIENTE_SEXO= @sexo,
                                          TB_CLIENTE_EMAIL= @email,
                                          TB_CLIENTE_SENHA = @senha,
                                          TB_CLIENTE_ENDERECO = @endereco,
                                          TB_CLIENTE_COMPLEMENTO = @complemento,
                                          TB_CLIENTE_BAIRRO = @bairro,
                                          TB_CLIENTE_CIDADE = @cidade,
                                          TB_CLIENTE_UF = @uf,
                                          TB_CLIENTE_DT_NASC = @dt_nasc,
                                          TB_CLIENTE_DT_CAD = @dt_cad
                                      where TB_CLIENTE_ID = @id_cliente";

                MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);

                executacmdMySql_update_cliente.Parameters.AddWithValue("@id_cliente", codigo);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@nome_cliente", cliente_nome);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@tel_cliente", tel_cliente);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@sexo", sexo);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@email", email);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@senha", senha);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@endereco", endereco);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@complemento", complemento);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@bairro", bairro);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@cidade", cidade);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@uf", uf);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@dt_nasc", dtp_nasc);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@dt_cad", dtp_cadastro);

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
                                        from tb_cliente where tb_cliente_situacao = 'ATIVO'
                                                ";

                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);

                dgv_cliente.DataSource = tabela_cliente;

                con.Close();
                MessageBox.Show("Dados atualizados com sucesso!");

                txt_nomecliente.Clear();
                txt_telefone.Clear();
                cmb_sexo.Items.Clear();
                txt_email.Clear();
                txt_senha.Clear();
                txt_endereco.Clear();
                txt_complemento.Clear();
                txt_bairro.Clear();
                txt_cidade.Clear();
                dtp_cadastrado.ResetText();
                dtp_nascimento.ResetText();
                cmb_uf.Items.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados! Tente novamente.");
            }
        }

        private void btn_desativar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigocliente.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cliente = @"update tb_cliente
                                      set tb_cliente_situacao = 'DESATIVADO'
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
                                        from tb_cliente where tb_cliente_status = 'ATIVO'
                                                ";

                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);

                dgv_cliente.DataSource = tabela_cliente;

                con.Close();
                MessageBox.Show("Dados atualizados com sucesso!");

                txt_nomecliente.Clear();
                txt_telefone.Clear();
                cmb_sexo.Text = string.Empty;
                cmb_sexo.Items.Clear();
                txt_email.Clear();
                txt_senha.Clear();
                txt_endereco.Clear();
                txt_complemento.Clear();
                txt_bairro.Clear();
                txt_cidade.Clear();
                dtp_cadastrado.ResetText();
                dtp_nascimento.ResetText();

                cmb_uf.Text = string.Empty;
                cmb_uf.Items.Clear();

            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados! Tente novamente");
            }
        }

        //BOTÃO SAIR
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }
    }
}


       
