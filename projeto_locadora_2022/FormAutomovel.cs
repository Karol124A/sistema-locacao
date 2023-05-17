using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_locadora_2022
{
    public partial class AUTOMÓVEIS : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public AUTOMÓVEIS()
        {
            InitializeComponent();
            //Desativando TextBox ID
            txt_codigocarro.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Campo Vazio 

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_nomecarro, "Nome do Automóvel"))
                return;

            codigosGerais c5 = new codigosGerais();
            if (c5.campoVazio(txt_cor, "Cor do Automóvel"))
                return;

            codigosGerais c6 = new codigosGerais();
            if (c6.campoVazio(cmb_modelo, "Modelo do Automóvel"))
                return;

            codigosGerais c7 = new codigosGerais();
            if (c7.campoVazio(cmb_marca, "Marca do Automóvel"))
                return;

            //Cadastro de Dados

            try
            {

                MySqlConnection con = new MySqlConnection(conexao);

                string nome, cor, status;
                int marca_id, modelo_id;
                int? ano_fab;
                double? valor;
                double? km;

                nome = txt_nomecarro.Text.ToUpper();
                cor = txt_cor.Text.ToUpper();
                status = cmb_status.Text;



                marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                modelo_id = int.Parse(cmb_modelo.SelectedValue.ToString());


                if (cmb_ano.Text.Length == 0)
                {
                    ano_fab = null;
                }

                else
                {
                    ano_fab = int.Parse(cmb_ano.Text);

                }


                if (txt_valor.Text.Length == 0)
                {
                    valor = null;
                }

                else
                {
                    valor = double.Parse(txt_valor.Text);

                }

                if (txt_km.Text.Length == 0)
                {
                    km = null;
                }

                else
                {
                    km = double.Parse(txt_km.Text);

                }


                string sql_insert = @"insert into tb_automovel  
                                     (
                                        tb_automovel_nome,
                                        tb_automovel_ano_fab,
                                        tb_automovel_cor,
                                        tb_automovel_km,
                                        tb_automovel_valor_d,
                                        tb_automovel_status,
                                        tb_marca_id,
                                        tb_modelo_id
                                     )
                                      values 
                                     (
                                        @automovel_nome,
                                        @automovel_ano_fab,
                                        @automovel_cor,
                                        @automovel_km,
                                        @automovel_valor_d,
                                        @automovel_status,
                                        @marca_id,
                                        @modelo_id
                                     )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@automovel_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_ano_fab", ano_fab);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_cor", cor);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_km", km);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_valor_d", valor);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_status", status);
                executacmdMySql_insert.Parameters.AddWithValue("@marca_id", marca_id);
                executacmdMySql_insert.Parameters.AddWithValue("@modelo_id", modelo_id);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();



                //Populando DataGridView

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
                                            where tb_automovel_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_autom = new MySqlCommand(sql_select_autom, con);

                executacmdMySql_select_autom.ExecuteNonQuery();

                DataTable tb_automovel = new DataTable();

                MySqlDataAdapter adapter_autom = new MySqlDataAdapter(executacmdMySql_select_autom);

                adapter_autom.Fill(tb_automovel);

                dgv_automovel.DataSource = tb_automovel;

                //Fim DataGridView

                con.Close();

                MessageBox.Show("Automóvel cadastrado com sucesso!");

                txt_nomecarro.Clear();
                txt_cor.Clear();
                txt_km.Clear();
                txt_valor.Clear();
                cmb_ano.SelectedIndex = -1;
                cmb_status.SelectedIndex = -1;
                cmb_marca.SelectedIndex = -1;
                cmb_modelo.SelectedIndex = -1;

            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar automóvel! Tente novamente. ");
            }
        }

        private void AUTOMÓVEIS_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            DataTable dtResultado_mod = new DataTable();

            //TABELA MODELO
            string sql_select_modelo = "select * from tb_modelo" 
                + " order by tb_modelo_id asc";
            MySqlDataAdapter dtAdapter_mod = new MySqlDataAdapter(sql_select_modelo, con);

            dtAdapter_mod.Fill(dtResultado_mod);

            cmb_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_modelo.DataSource = dtResultado_mod;
            cmb_modelo.ValueMember = "tb_modelo_id";
            cmb_modelo.DisplayMember = "tb_modelo_desc";

            cmb_modelo.SelectedItem = null;


            //TABELA MARCA
            string sql_select_marca = "select * from tb_marca  order by tb_marca_id asc";
            MySqlDataAdapter dtAdapter_marca = new MySqlDataAdapter(sql_select_marca, con);

            DataTable dtResultado_marca = new DataTable();

            dtAdapter_marca.Fill(dtResultado_marca);

            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.DataSource = dtResultado_marca;
            cmb_marca.ValueMember = "tb_marca_id";
            cmb_marca.DisplayMember = "tb_marca_nome";

            cmb_marca.SelectedItem = null;

            //COMOBOBOX STATUS
            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;

            con.Open();

            //Populando DataGridView

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
                                            where tb_automovel_situacao = 'ATIVO'";

            MySqlCommand executacmdMySql_select_autom = new MySqlCommand(sql_select_autom, con);

            executacmdMySql_select_autom.ExecuteNonQuery();

            DataTable tb_automovel = new DataTable();

            MySqlDataAdapter adapter_autom = new MySqlDataAdapter(executacmdMySql_select_autom);

            adapter_autom.Fill(tb_automovel);

            dgv_automovel.DataSource = tb_automovel;

            //Fim DataGridView

            con.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            //Campo Vazio 

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_nomecarro, "Nome do Automóvel"))
                return;

            codigosGerais c5 = new codigosGerais();
            if (c5.campoVazio(txt_cor, "Cor do Automóvel"))
                return;

            codigosGerais c6 = new codigosGerais();
            if (c6.campoVazio(cmb_modelo, "Modelo do Automóvel"))
                return;

            codigosGerais c7 = new codigosGerais();
            if (c7.campoVazio(cmb_marca, "Marca do Automóvel"))
                return;

            //ATUALIZANDO DADOS

            try
            {

                MySqlConnection con = new MySqlConnection(conexao);

                string nome, cor, status;
                int marca_id, modelo_id;
                int? ano_fab;
                double? valor;
                double? km;

                nome = txt_nomecarro.Text.ToUpper();
                cor = txt_cor.Text.ToUpper();
                status = cmb_status.Text;



                marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                modelo_id = int.Parse(cmb_modelo.SelectedValue.ToString());





                if (cmb_ano.Text.Length == 0)
                {
                    ano_fab = null;
                }

                else
                {
                    ano_fab = int.Parse(cmb_ano.Text);

                }


                if (txt_valor.Text.Length == 0)
                {
                    valor = null;
                }

                else
                {
                    valor = double.Parse(txt_valor.Text);

                }

                if (txt_km.Text.Length == 0)
                {
                    km = null;
                }

                else
                {
                    km = double.Parse(txt_km.Text);

                }


                string sql_update_automovel = @"update tb_automovel
                                      set TB_AUTOMOVEL_NOME = @nome_automovel,
                                          TB_AUTOMOVEL_COR = @cor_automovel,      
                                          TB_AUTOMOVEL_VALOR_D = @valor_automovel,
                                          TB_AUTOMOVEL_STATUS = @status_automovel,
                                          TB_MARCA_ID = @marca_id,
                                          TB_MODELO_ID = @modelo_id,
                                          TB_AUTOMOVEL_ANO_FAB = @ano_fabricacao,
                                          TB_AUTOMOVEL_KM = @km_automovel
                                       where TB_AUTOMOVEL_ID = @id_automovel";

                MySqlCommand executacmdMysql_update_automovel = new MySqlCommand(sql_update_automovel, con);

                executacmdMysql_update_automovel.Parameters.AddWithValue("@nome_automovel", nome);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@automovel_ano_fabricacao", ano_fab);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@cor_automovel", cor);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@km_automovel", km);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@valor_automovel", valor);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@status_automovel", status);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@marca_id", marca_id);
                executacmdMysql_update_automovel.Parameters.AddWithValue("@modelo_id", modelo_id);

                con.Open();

                executacmdMysql_update_automovel.ExecuteNonQuery();



                //Populando DataGridView

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
                                            where tb_automovel_situacao = 'ATIVO'";

                MySqlCommand executacmdMySql_select_autom = new MySqlCommand(sql_select_autom, con);

                executacmdMySql_select_autom.ExecuteNonQuery();

                DataTable tb_automovel = new DataTable();

                MySqlDataAdapter adapter_autom = new MySqlDataAdapter(executacmdMySql_select_autom);

                adapter_autom.Fill(tb_automovel);

                dgv_automovel.DataSource = tb_automovel;

                //Fim DataGridView

                con.Close();

                MessageBox.Show("Automóvel atualizado com sucesso!");

                txt_nomecarro.Clear();
                txt_cor.Clear();
                txt_km.Clear();
                txt_valor.Clear();
                cmb_ano.SelectedIndex = -1;
                cmb_status.SelectedIndex = -1;
                cmb_marca.SelectedIndex = -1;
                cmb_modelo.SelectedIndex = -1;

            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar automovel! Tente Novamente");
            }

        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;

                codigo = int.Parse(txt_codigocarro.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_automovel = @"update tb_automovel
                                      set TB_AUTOMOVEL_SITUACAO = 'DESATIVADO'
                                      where TB_AUTOMOVEL_ID = @id_AUTOMOVEL";
                MySqlCommand executacmdMysql_update_automovel = new MySqlCommand(sql_update_automovel, con);

                executacmdMysql_update_automovel.Parameters.AddWithValue("@id_AUTOMOVEL", codigo);

                executacmdMysql_update_automovel.ExecuteNonQuery();

                
                con.Close();

                MessageBox.Show("Automóvel desativado com sucesso!");

                txt_nomecarro.Clear();
                txt_cor.Clear();
                txt_km.Clear();
                txt_valor.Clear();
                cmb_ano.SelectedIndex = -1;
                cmb_status.SelectedIndex = -1;
                cmb_marca.SelectedIndex = -1;
                cmb_modelo.SelectedIndex = -1;
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao desativar dados! Tente novamente.");
            }
        }

        private void dgv_automovel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigocarro.Text = dgv_automovel.CurrentRow.Cells[0].Value.ToString();
            txt_nomecarro.Text = dgv_automovel.CurrentRow.Cells[1].Value.ToString();
            cmb_ano.Text = dgv_automovel.CurrentRow.Cells[2].Value.ToString();
            txt_cor.Text = dgv_automovel.CurrentRow.Cells[3].Value.ToString();
            txt_km.Text = dgv_automovel.CurrentRow.Cells[4].Value.ToString();
            txt_valor.Text = dgv_automovel.CurrentRow.Cells[5].Value.ToString();
            cmb_status.Text = dgv_automovel.CurrentRow.Cells[6].Value.ToString();
            cmb_marca.Text = dgv_automovel.CurrentRow.Cells[7].Value.ToString();
            cmb_modelo.Text = dgv_automovel.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void novo_marca_Click(object sender, EventArgs e)
        {
            CadastrarMarca cadastrar_marca = new CadastrarMarca();
            cadastrar_marca.ShowDialog();
        }

        private void novo_modelo_Click(object sender, EventArgs e)
        {
            CadastrarModelo cadastrar_modelo = new CadastrarModelo();
            cadastrar_modelo.ShowDialog();
        }
    }
}
