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
    public partial class FormLocacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2022"].ConnectionString;

        public FormLocacao()
        {
            InitializeComponent();
            //Desativando ID
            txt_codigo_locacao.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            

            //Campo Vazio 

            codigosGerais c = new codigosGerais();
            if (c.campoVazio(cmb_tipo, "Tipo de locação"))
                return;

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_valor, "Valor da locação"))
                return;

            codigosGerais c2 = new codigosGerais();
            if (c2.campoVazio(cmb_cliente_id, "Nome do cliente"))
                return;

            codigosGerais c3 = new codigosGerais();
            if (c3.campoVazio(cmb_funcionario_id, "Nome do funcionário"))
                return;

            codigosGerais c4 = new codigosGerais();
            if (c4.campoVazio(cmb_automovel_id, "Nome do automóvel"))
                return;

            try
            {
                //Cadastro de Locações

                MySqlConnection con = new MySqlConnection(conexao);

                double valor_locacao;
                string tipo;
                DateTime dt_inicio, dt_final;
                int autom_id, func_id, cliente_id;

                valor_locacao = double.Parse(txt_valor.Text);

                tipo = cmb_tipo.Text;

                dt_inicio = Convert.ToDateTime(dtp_inicio_locacao.Text);
                dt_final = Convert.ToDateTime(dtp_fim_locacao.Text);

                DateTimePicker data = new DateTimePicker();
                data.Value = DateTime.Now.Date;

                autom_id = int.Parse(cmb_automovel_id.SelectedValue.ToString());
                func_id = int.Parse(cmb_funcionario_id.SelectedValue.ToString());
                cliente_id = int.Parse(cmb_cliente_id.SelectedValue.ToString());

                string sql_insert = @"insert into tb_locacao 
                                   (
                                    tb_locacao_tipo,
                                    tb_locacao_valor,
                                    tb_locacao_dt_inicio,
                                    tb_locacao_dt_fim,
                                    tb_cliente_id,
                                    tb_funcionario_id,
                                    tb_automovel_id
                                   )
                                   values 
                                   (
                                    @locacao_tipo,
                                    @locacao_valor,
                                    @locacao_dt_inicio,
                                    @locacao_dt_fim,
                                    @cliente_id,
                                    @funcionario_id,
                                    @automovel_id
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@locacao_tipo", tipo);
                executacmdMySql_insert.Parameters.AddWithValue("@locacao_valor", valor_locacao);
                executacmdMySql_insert.Parameters.AddWithValue("@locacao_dt_inicio", dt_inicio);
                executacmdMySql_insert.Parameters.AddWithValue("@locacao_dt_fim", dt_final);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_id", cliente_id);
                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_id", func_id);
                executacmdMySql_insert.Parameters.AddWithValue("@automovel_id", autom_id);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();



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
                                               where tb_locacao.tb_locacao_situacao= 'ATIVO'";

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tb_locacao = new DataTable();

                MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

                adapter_loc.Fill(tb_locacao);

                dgv_locacao.DataSource = tb_locacao;

                //Fim DataGridView


                con.Close();


                MessageBox.Show("Locação cadastrada com sucesso!");

                cmb_tipo.SelectedIndex = -1;
                txt_valor.Clear();
                cmb_cliente_id.SelectedIndex = -1;
                cmb_funcionario_id.SelectedIndex = -1;
                cmb_automovel_id.SelectedIndex = -1;
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar locação! Tente novamente");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void FormLocacao_Load(object sender, EventArgs e)
        {
            //ComboBox Cliente

            MySqlConnection con = new MySqlConnection(conexao);


            string sqlselect_cliente = "select * from tb_cliente order by tb_cliente_id asc";
            MySqlDataAdapter dtAdapter_cliente = new MySqlDataAdapter(sqlselect_cliente, con);
            DataTable dtResultado_cliente = new DataTable();

            dtAdapter_cliente.Fill(dtResultado_cliente);

            cmb_cliente_id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cliente_id.DataSource = dtResultado_cliente;
            cmb_cliente_id.ValueMember = "tb_cliente_id";
            cmb_cliente_id.DisplayMember = "tb_cliente_nome";

            cmb_cliente_id.SelectedItem = null;


            //ComboBox Funcionário

            string sqlselect_func = "select * from tb_funcionario order by tb_funcionario_id asc";
            MySqlDataAdapter dtAdapter_func = new MySqlDataAdapter(sqlselect_func, con);
            DataTable dtResultado_func = new DataTable();

            dtAdapter_func.Fill(dtResultado_func);

            cmb_funcionario_id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_funcionario_id.DataSource = dtResultado_func;
            cmb_funcionario_id.ValueMember = "tb_funcionario_id";
            cmb_funcionario_id.DisplayMember = "tb_funcionario_nome";

            cmb_funcionario_id.SelectedItem = null;

            //ComboBox Automóvel

            string sqlselect_autom = "select * from tb_automovel order by tb_automovel_id asc";
            MySqlDataAdapter dtAdapter_autom = new MySqlDataAdapter(sqlselect_autom, con);
            DataTable dtResultado_autom = new DataTable();

            dtAdapter_autom.Fill(dtResultado_autom);

            cmb_automovel_id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_automovel_id.DataSource = dtResultado_autom;
            cmb_automovel_id.ValueMember = "tb_automovel_id";
            cmb_automovel_id.DisplayMember = "tb_automovel_nome";

            cmb_automovel_id.SelectedItem = null;

            cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipo.SelectedItem = null;



            //Populando DataGridView

            con.Open();

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
                                           where tb_locacao.tb_locacao_situacao= 'ATIVO'";

            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tb_locacao = new DataTable();

            MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

            adapter_loc.Fill(tb_locacao);

            dgv_locacao.DataSource = tb_locacao;

            con.Close();

            //Fim DataGridView
        }

        private void dgv_locacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_locacao.Text = dgv_locacao.CurrentRow.Cells[0].Value.ToString();
            cmb_tipo.SelectedItem = dgv_locacao.CurrentRow.Cells[1].Value.ToString();
            txt_valor.Text = dgv_locacao.CurrentRow.Cells[2].Value.ToString();
            dtp_inicio_locacao.Text = dgv_locacao.CurrentRow.Cells[3].Value.ToString();
            dtp_fim_locacao.Text = dgv_locacao.CurrentRow.Cells[4].Value.ToString();
            cmb_cliente_id.Text = dgv_locacao.CurrentRow.Cells[5].Value.ToString();
            cmb_funcionario_id.Text = dgv_locacao.CurrentRow.Cells[6].Value.ToString();
            cmb_automovel_id.Text = dgv_locacao.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            //Campo Vazio 

            codigosGerais c = new codigosGerais();
            if (c.campoVazio(cmb_tipo, "Tipo de locação"))
                return;

            codigosGerais c1 = new codigosGerais();
            if (c1.campoVazio(txt_valor, "Valor da locação"))
                return;

            codigosGerais c2 = new codigosGerais();
            if (c2.campoVazio(cmb_cliente_id, "Nome do cliente"))
                return;

            codigosGerais c3 = new codigosGerais();
            if (c3.campoVazio(cmb_funcionario_id, "Nome do funcionário"))
                return;

            codigosGerais c4 = new codigosGerais();
            if (c4.campoVazio(cmb_automovel_id, "Nome do automóvel"))
                return;

            try
            {
                //Atualização das Locações

                MySqlConnection con = new MySqlConnection(conexao);

                double valor_locacao;
                string tipo;
                DateTime dt_inicio, dt_final;
                int autom_id, func_id, cliente_id, codigo;

                valor_locacao = double.Parse(txt_valor.Text);

                tipo = cmb_tipo.Text;

                dt_inicio = Convert.ToDateTime(dtp_inicio_locacao.Text);
                dt_final = Convert.ToDateTime(dtp_fim_locacao.Text);

                DateTimePicker data = new DateTimePicker();
                data.Value = DateTime.Now.Date;

                autom_id = int.Parse(cmb_automovel_id.SelectedValue.ToString());
                func_id = int.Parse(cmb_funcionario_id.SelectedValue.ToString());
                cliente_id = int.Parse(cmb_cliente_id.SelectedValue.ToString());
                codigo = int.Parse(txt_codigo_locacao.Text);

                string sql_update_locacao = @"update tb_locação
                                      set TB_CLIENTE_ID = @cliente_id,
                                          TB_LOCACAO_TIPO = @tipo,      
                                          TB_LOCACAO_VALOR = @valor,
                                          TB_FUNCIONARIO_ID = @funcionario_id,
                                          TB_AUTOMOVEL_ID = @automovel_id,
                                          TB_LOCACAO_DT_INICIO = @dt_inicio,
                                          TB_LOCACAO_DT_FIM = @dt_fim
                                       where TB_LOCACAO_ID = @id_locacao";

                MySqlCommand executacmdMysql_update_locacao = new MySqlCommand(sql_update_locacao, con);

                executacmdMysql_update_locacao.Parameters.AddWithValue("@locacao_tipo", tipo);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@locacao_valor", valor_locacao);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@locacao_dt_inicio", dt_inicio);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@locacao_dt_fim", dt_final);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@cliente_id", cliente_id);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@funcionario_id", func_id);
                executacmdMysql_update_locacao.Parameters.AddWithValue("@automovel_id", autom_id);

                con.Open();

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
                                               where tb_locacao.tb_locacao_situacao= 'ATIVO'";

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tb_locacao = new DataTable();

                MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

                adapter_loc.Fill(tb_locacao);

                dgv_locacao.DataSource = tb_locacao;

                //Fim DataGridView


                con.Close();


                MessageBox.Show("Locação atualizada com sucesso!");

                cmb_tipo.SelectedIndex = -1;
                txt_valor.Clear();
                cmb_cliente_id.SelectedIndex = -1;
                cmb_funcionario_id.SelectedIndex = -1;
                cmb_automovel_id.SelectedIndex = -1;
                txt_codigo_locacao.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar dados! Tente novamente");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            int codigo;

            codigo = int.Parse(txt_codigo_locacao.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_locacao = @"update tb_locacao
                                      set TB_LOCACAO_SITUACAO = 'DESATIVADO'
                                      where TB_LOCACAO_ID = @ID_LOCACAO";

            MySqlCommand executacmdMysql_update_locacao = new MySqlCommand(sql_update_locacao, con);

            executacmdMysql_update_locacao.Parameters.AddWithValue("@id_locacao", codigo);

            executacmdMysql_update_locacao.ExecuteNonQuery();

            String sql_select_locacao = @"select tb_locacao_id as 'CÓDIGO',
	                                       tb_locacao_tipo as 'TIPO', 
                                           tb_locacao_valor as 'VALOR DA DIÁRIA',
                                           tb_locacao_dt_inicio as 'INÍCIO',
                                           tb_locacao_dt_fim as 'FIM', 
                                           tb_cliente.tb_cliente_nome as 'CLIENTE', 
                                           tb_funcionario.tb_funcionario_nome as 'FUNCIONÁRIO',
                                           tb_automovel.tb_automovel_nome as 'VEÍCULO',
                                           tb_locacao_situacao as 'SITUAÇÃO'
                                           from tb_locacao
                                           inner join tb_clientetb_locacao_tipo
                                           on tb_locacao.tb_cliente_id = tb_cliente.tb_cliente_id
                                           inner join tb_funcionario
                                           on tb_locacao.tb_funcionario_id = tb_funcionario.tb_funcionario_id
                                           inner join tb_automovel
                                           on tb_locacao.tb_automovel_id = tb_automovel.tb_automovel_id
                                           where tb_locacao.tb_locacao_situacao= 'ATIVO'";

            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tb_locacao = new DataTable();

            MySqlDataAdapter adapter_loc = new MySqlDataAdapter(executacmdMySql_select_locacao);

            adapter_loc.Fill(tb_locacao);

            dgv_locacao.DataSource = tb_locacao;

            //Fim DataGridView


            con.Close();


            MessageBox.Show("Locação desativada com sucesso!");

            cmb_tipo.SelectedIndex = -1;
            txt_valor.Clear();
            cmb_cliente_id.SelectedIndex = -1;
            cmb_funcionario_id.SelectedIndex = -1;
            cmb_automovel_id.SelectedIndex = -1;
            txt_codigo_locacao.Clear();
        }

        private void novo_veiculo_Click(object sender, EventArgs e)
        {
            CadastrarAutomovel cadastrar_automovel = new CadastrarAutomovel();
            cadastrar_automovel.ShowDialog();
        }

        private void novo_cliente_Click_1(object sender, EventArgs e)
        {
            CadastrarCliente cadastrar_cliente = new CadastrarCliente();
            cadastrar_cliente.ShowDialog();
        }

        private void novo_funcionario_Click(object sender, EventArgs e)
        {

            CadastrarFuncionario cadastrar_funcionario = new CadastrarFuncionario();
            cadastrar_funcionario.ShowDialog();
        }
    }
}
