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
    public partial class CadastrarModelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public CadastrarModelo()
        {
            InitializeComponent();
            //Desativando textBox
            txt_codigo_modelo.Enabled = false;
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Ativando CampoVazio
            codigosGerais c = new codigosGerais();
            if (c.campoVazio(txt_nome_modelo, "Nome do Modelo"))
                return; MySqlConnection con = new MySqlConnection(conexao);

            string nome_modelo;
            nome_modelo = txt_nome_modelo.Text.ToUpper();

            try

            {

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
                con.Close();

                MessageBox.Show("Cadastrado com sucesso");

                this.Hide();
                AUTOMÓVEIS form_automovel = new AUTOMÓVEIS();
                form_automovel.ShowDialog();

            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar modelo");
            }
        }
    }
}