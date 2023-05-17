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
    public partial class CadastrarMarca : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public CadastrarMarca()
        {
            InitializeComponent();
            // Desativando textBox
            txt_codigo_marca.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
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


                con.Close();
                MessageBox.Show("MARCA CADASTRADA!");

                this.Hide();
                AUTOMÓVEIS form_automovel = new AUTOMÓVEIS();
                form_automovel.ShowDialog();


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar marca! Tente novamente");
            }
        }
    }
}
