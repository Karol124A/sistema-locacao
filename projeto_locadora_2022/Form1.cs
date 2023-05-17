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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_automovel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AUTOMÓVEIS form_automovel = new AUTOMÓVEIS();
            form_automovel.ShowDialog();
            
        }

        private void btn_locacao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLocacao form_locacao = new FormLocacao();
            form_locacao.ShowDialog();
            
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMarca form_marca= new FormMarca();
            form_marca.ShowDialog();
           
        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModelo form_modelo = new FormModelo();
            form_modelo.ShowDialog();
            
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente form_cliente = new FormCliente();
            form_cliente.ShowDialog();
            
        }

        private void btn_cargo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargo form_cargo = new FormCargo();
            form_cargo.ShowDialog();
            
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionario form_funcionario = new FormFuncionario();
            form_funcionario.ShowDialog();
            
        }

       

        private void btn_desativados_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDesativados form_Desativados = new FormDesativados();
            form_Desativados.ShowDialog();
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
    
}
