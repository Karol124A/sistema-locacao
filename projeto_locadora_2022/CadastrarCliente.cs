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
    public partial class CadastrarCliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public CadastrarCliente()
        {
            InitializeComponent();
            //Desativando textBox
            txt_codigocliente.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
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
                con.Close();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                this.Hide();
                FormLocacao form_locacao = new FormLocacao();
                form_locacao.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar cliente");
            }
        }
    }
}
