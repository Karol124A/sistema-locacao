namespace projeto_locadora_2022
{
    partial class FormLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_locacao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.novo_veiculo = new System.Windows.Forms.PictureBox();
            this.novo_funcionario = new System.Windows.Forms.PictureBox();
            this.novo_cliente = new System.Windows.Forms.PictureBox();
            this.cmb_tipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_automovel_id = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_funcionario_id = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_cliente_id = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_fim_locacao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_inicio_locacao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_valor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_codigo_locacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_desativar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novo_veiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label14.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 217);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 32);
            this.label14.TabIndex = 53;
            this.label14.Text = "GERENCIAMENTO";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.pictureBox4.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.logo2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(347, 201);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(336, 826);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgv_locacao);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(864, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1059, 658);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LOCAÇÃO";
            // 
            // dgv_locacao
            // 
            this.dgv_locacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_locacao.Location = new System.Drawing.Point(32, 46);
            this.dgv_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_locacao.Name = "dgv_locacao";
            this.dgv_locacao.Size = new System.Drawing.Size(999, 582);
            this.dgv_locacao.TabIndex = 0;
            this.dgv_locacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_locacao_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.novo_veiculo);
            this.groupBox1.Controls.Add(this.novo_funcionario);
            this.groupBox1.Controls.Add(this.novo_cliente);
            this.groupBox1.Controls.Add(this.cmb_tipo);
            this.groupBox1.Controls.Add(this.cmb_automovel_id);
            this.groupBox1.Controls.Add(this.cmb_funcionario_id);
            this.groupBox1.Controls.Add(this.cmb_cliente_id);
            this.groupBox1.Controls.Add(this.dtp_fim_locacao);
            this.groupBox1.Controls.Add(this.dtp_inicio_locacao);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.txt_codigo_locacao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 432);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS";
            // 
            // novo_veiculo
            // 
            this.novo_veiculo.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.icone_novo;
            this.novo_veiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novo_veiculo.Location = new System.Drawing.Point(458, 377);
            this.novo_veiculo.Margin = new System.Windows.Forms.Padding(4);
            this.novo_veiculo.Name = "novo_veiculo";
            this.novo_veiculo.Size = new System.Drawing.Size(41, 36);
            this.novo_veiculo.TabIndex = 81;
            this.novo_veiculo.TabStop = false;
            this.novo_veiculo.Click += new System.EventHandler(this.novo_veiculo_Click);
            // 
            // novo_funcionario
            // 
            this.novo_funcionario.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.icone_novo;
            this.novo_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novo_funcionario.Location = new System.Drawing.Point(458, 324);
            this.novo_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.novo_funcionario.Name = "novo_funcionario";
            this.novo_funcionario.Size = new System.Drawing.Size(41, 36);
            this.novo_funcionario.TabIndex = 80;
            this.novo_funcionario.TabStop = false;
            this.novo_funcionario.Click += new System.EventHandler(this.novo_funcionario_Click);
            // 
            // novo_cliente
            // 
            this.novo_cliente.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.icone_novo;
            this.novo_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novo_cliente.Location = new System.Drawing.Point(460, 273);
            this.novo_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.novo_cliente.Name = "novo_cliente";
            this.novo_cliente.Size = new System.Drawing.Size(41, 36);
            this.novo_cliente.TabIndex = 66;
            this.novo_cliente.TabStop = false;
            this.novo_cliente.Click += new System.EventHandler(this.novo_cliente_Click_1);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.AutoRoundedCorners = true;
            this.cmb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_tipo.BorderRadius = 17;
            this.cmb_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipo.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_tipo.ItemHeight = 30;
            this.cmb_tipo.Items.AddRange(new object[] {
            "SEMANAL",
            "MENSAL",
            "DIÁRIO"});
            this.cmb_tipo.Location = new System.Drawing.Point(212, 94);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(241, 36);
            this.cmb_tipo.TabIndex = 79;
            // 
            // cmb_automovel_id
            // 
            this.cmb_automovel_id.AutoRoundedCorners = true;
            this.cmb_automovel_id.BackColor = System.Drawing.Color.Transparent;
            this.cmb_automovel_id.BorderRadius = 17;
            this.cmb_automovel_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_automovel_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_automovel_id.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_automovel_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_automovel_id.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_automovel_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_automovel_id.ItemHeight = 30;
            this.cmb_automovel_id.Location = new System.Drawing.Point(209, 377);
            this.cmb_automovel_id.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_automovel_id.Name = "cmb_automovel_id";
            this.cmb_automovel_id.Size = new System.Drawing.Size(241, 36);
            this.cmb_automovel_id.TabIndex = 78;
            // 
            // cmb_funcionario_id
            // 
            this.cmb_funcionario_id.AutoRoundedCorners = true;
            this.cmb_funcionario_id.BackColor = System.Drawing.Color.Transparent;
            this.cmb_funcionario_id.BorderRadius = 17;
            this.cmb_funcionario_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_funcionario_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_funcionario_id.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_funcionario_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_funcionario_id.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_funcionario_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_funcionario_id.ItemHeight = 30;
            this.cmb_funcionario_id.Location = new System.Drawing.Point(209, 325);
            this.cmb_funcionario_id.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_funcionario_id.Name = "cmb_funcionario_id";
            this.cmb_funcionario_id.Size = new System.Drawing.Size(241, 36);
            this.cmb_funcionario_id.TabIndex = 77;
            // 
            // cmb_cliente_id
            // 
            this.cmb_cliente_id.AutoRoundedCorners = true;
            this.cmb_cliente_id.BackColor = System.Drawing.Color.Transparent;
            this.cmb_cliente_id.BorderRadius = 17;
            this.cmb_cliente_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cliente_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente_id.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cliente_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cliente_id.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_cliente_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_cliente_id.ItemHeight = 30;
            this.cmb_cliente_id.Location = new System.Drawing.Point(211, 273);
            this.cmb_cliente_id.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cliente_id.Name = "cmb_cliente_id";
            this.cmb_cliente_id.Size = new System.Drawing.Size(241, 36);
            this.cmb_cliente_id.TabIndex = 76;
            // 
            // dtp_fim_locacao
            // 
            this.dtp_fim_locacao.AutoRoundedCorners = true;
            this.dtp_fim_locacao.BorderRadius = 17;
            this.dtp_fim_locacao.Checked = true;
            this.dtp_fim_locacao.FillColor = System.Drawing.Color.White;
            this.dtp_fim_locacao.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtp_fim_locacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim_locacao.Location = new System.Drawing.Point(212, 229);
            this.dtp_fim_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fim_locacao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fim_locacao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fim_locacao.Name = "dtp_fim_locacao";
            this.dtp_fim_locacao.Size = new System.Drawing.Size(244, 37);
            this.dtp_fim_locacao.TabIndex = 75;
            this.dtp_fim_locacao.Value = new System.DateTime(2022, 11, 16, 16, 48, 45, 655);
            // 
            // dtp_inicio_locacao
            // 
            this.dtp_inicio_locacao.AutoRoundedCorners = true;
            this.dtp_inicio_locacao.BorderRadius = 17;
            this.dtp_inicio_locacao.Checked = true;
            this.dtp_inicio_locacao.FillColor = System.Drawing.Color.White;
            this.dtp_inicio_locacao.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtp_inicio_locacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio_locacao.Location = new System.Drawing.Point(212, 185);
            this.dtp_inicio_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_inicio_locacao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_inicio_locacao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_inicio_locacao.Name = "dtp_inicio_locacao";
            this.dtp_inicio_locacao.Size = new System.Drawing.Size(240, 37);
            this.dtp_inicio_locacao.TabIndex = 74;
            this.dtp_inicio_locacao.Value = new System.DateTime(2022, 11, 16, 16, 48, 45, 655);
            // 
            // txt_valor
            // 
            this.txt_valor.AutoRoundedCorners = true;
            this.txt_valor.BorderRadius = 17;
            this.txt_valor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_valor.DefaultText = "";
            this.txt_valor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_valor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_valor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_valor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_valor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_valor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_valor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_valor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_valor.Location = new System.Drawing.Point(211, 139);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(5);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PasswordChar = '\0';
            this.txt_valor.PlaceholderText = "";
            this.txt_valor.SelectedText = "";
            this.txt_valor.Size = new System.Drawing.Size(241, 37);
            this.txt_valor.TabIndex = 73;
            // 
            // txt_codigo_locacao
            // 
            this.txt_codigo_locacao.AutoRoundedCorners = true;
            this.txt_codigo_locacao.BorderRadius = 17;
            this.txt_codigo_locacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo_locacao.DefaultText = "";
            this.txt_codigo_locacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_codigo_locacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_codigo_locacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo_locacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo_locacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo_locacao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_codigo_locacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_codigo_locacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo_locacao.Location = new System.Drawing.Point(212, 46);
            this.txt_codigo_locacao.Margin = new System.Windows.Forms.Padding(5);
            this.txt_codigo_locacao.Name = "txt_codigo_locacao";
            this.txt_codigo_locacao.PasswordChar = '\0';
            this.txt_codigo_locacao.PlaceholderText = "";
            this.txt_codigo_locacao.SelectedText = "";
            this.txt_codigo_locacao.Size = new System.Drawing.Size(105, 37);
            this.txt_codigo_locacao.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Veículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Fim da locação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Início da locação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.cadastrar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(904, 727);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.atualizar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1260, 727);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.desativar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1611, 727);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 62);
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // btn_desativar
            // 
            this.btn_desativar.AutoRoundedCorners = true;
            this.btn_desativar.BackColor = System.Drawing.Color.Transparent;
            this.btn_desativar.BorderRadius = 23;
            this.btn_desativar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_desativar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_desativar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_desativar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_desativar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btn_desativar.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_desativar.ForeColor = System.Drawing.Color.White;
            this.btn_desativar.Location = new System.Drawing.Point(1685, 740);
            this.btn_desativar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(173, 49);
            this.btn_desativar.TabIndex = 64;
            this.btn_desativar.Text = "Desativar";
            this.btn_desativar.UseTransparentBackground = true;
            this.btn_desativar.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.AutoRoundedCorners = true;
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.BorderRadius = 23;
            this.btn_atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_atualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btn_atualizar.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(1335, 740);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(173, 49);
            this.btn_atualizar.TabIndex = 63;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseTransparentBackground = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.AutoRoundedCorners = true;
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.BorderRadius = 23;
            this.btn_cadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btn_cadastrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(979, 740);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(173, 49);
            this.btn_cadastrar.TabIndex = 62;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseTransparentBackground = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.Location = new System.Drawing.Point(113, 578);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(87, 43);
            this.guna2Button1.TabIndex = 65;
            this.guna2Button1.Text = "Sair";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 826);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_desativar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOCAÇÃO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novo_veiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_locacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_codigo_locacao;
        private Guna.UI2.WinForms.Guna2TextBox txt_valor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fim_locacao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_inicio_locacao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2Button btn_desativar;
        private Guna.UI2.WinForms.Guna2Button btn_atualizar;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_automovel_id;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_funcionario_id;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_cliente_id;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_tipo;
        private System.Windows.Forms.PictureBox novo_veiculo;
        private System.Windows.Forms.PictureBox novo_funcionario;
        private System.Windows.Forms.PictureBox novo_cliente;
    }
}