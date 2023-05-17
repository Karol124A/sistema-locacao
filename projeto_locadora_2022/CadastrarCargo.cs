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
    public partial class CadastrarCargo : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public CadastrarCargo()
        {
            InitializeComponent();

            //Desativando textBox
            txt_codigo_cargo.Enabled = false;
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
                con.Close();

                MessageBox.Show("Cargo cadastrado!");
                this.Hide();
                FormFuncionario form_funcionario = new FormFuncionario();
                form_funcionario.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar código! Tente novamente");
            }
        }


    }
}
