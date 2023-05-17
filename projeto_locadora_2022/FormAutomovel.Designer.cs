namespace projeto_locadora_2022
{
    partial class AUTOMÓVEIS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.novo_modelo = new System.Windows.Forms.PictureBox();
            this.novo_marca = new System.Windows.Forms.PictureBox();
            this.cmb_ano = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_modelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_marca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_valor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_km = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_cor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nomecarro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_codigocarro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_automovel = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btn_sair = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_desativar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novo_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_marca)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_automovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label14.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 32);
            this.label14.TabIndex = 40;
            this.label14.Text = "GERENCIAMENTO";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.novo_modelo);
            this.groupBox1.Controls.Add(this.novo_marca);
            this.groupBox1.Controls.Add(this.cmb_ano);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_modelo);
            this.groupBox1.Controls.Add(this.cmb_marca);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.txt_km);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.txt_nomecarro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_codigocarro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(333, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 483);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS";
            // 
            // novo_modelo
            // 
            this.novo_modelo.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.icone_novo;
            this.novo_modelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novo_modelo.Location = new System.Drawing.Point(446, 364);
            this.novo_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.novo_modelo.Name = "novo_modelo";
            this.novo_modelo.Size = new System.Drawing.Size(41, 36);
            this.novo_modelo.TabIndex = 56;
            this.novo_modelo.TabStop = false;
            this.novo_modelo.Click += new System.EventHandler(this.novo_modelo_Click);
            // 
            // novo_marca
            // 
            this.novo_marca.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.icone_novo;
            this.novo_marca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novo_marca.Location = new System.Drawing.Point(446, 313);
            this.novo_marca.Margin = new System.Windows.Forms.Padding(4);
            this.novo_marca.Name = "novo_marca";
            this.novo_marca.Size = new System.Drawing.Size(41, 36);
            this.novo_marca.TabIndex = 55;
            this.novo_marca.TabStop = false;
            this.novo_marca.Click += new System.EventHandler(this.novo_marca_Click);
            // 
            // cmb_ano
            // 
            this.cmb_ano.AutoRoundedCorners = true;
            this.cmb_ano.BackColor = System.Drawing.Color.Transparent;
            this.cmb_ano.BorderRadius = 17;
            this.cmb_ano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ano.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ano.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_ano.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_ano.ItemHeight = 30;
            this.cmb_ano.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cmb_ano.Location = new System.Drawing.Point(177, 129);
            this.cmb_ano.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(113, 36);
            this.cmb_ano.TabIndex = 51;
            // 
            // cmb_status
            // 
            this.cmb_status.AutoRoundedCorners = true;
            this.cmb_status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status.BorderRadius = 17;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_status.ItemHeight = 30;
            this.cmb_status.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cmb_status.Location = new System.Drawing.Point(175, 417);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(263, 36);
            this.cmb_status.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Status:";
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.AutoRoundedCorners = true;
            this.cmb_modelo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_modelo.BorderRadius = 17;
            this.cmb_modelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_modelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_modelo.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_modelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_modelo.ItemHeight = 30;
            this.cmb_modelo.Location = new System.Drawing.Point(175, 364);
            this.cmb_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(263, 36);
            this.cmb_modelo.TabIndex = 48;
            // 
            // cmb_marca
            // 
            this.cmb_marca.AutoRoundedCorners = true;
            this.cmb_marca.BackColor = System.Drawing.Color.Transparent;
            this.cmb_marca.BorderRadius = 17;
            this.cmb_marca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_marca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_marca.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_marca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_marca.ItemHeight = 30;
            this.cmb_marca.Location = new System.Drawing.Point(175, 313);
            this.cmb_marca.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(263, 36);
            this.cmb_marca.TabIndex = 47;
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
            this.txt_valor.Location = new System.Drawing.Point(176, 267);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(5);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PasswordChar = '\0';
            this.txt_valor.PlaceholderText = "";
            this.txt_valor.SelectedText = "";
            this.txt_valor.Size = new System.Drawing.Size(223, 37);
            this.txt_valor.TabIndex = 42;
            // 
            // txt_km
            // 
            this.txt_km.AutoRoundedCorners = true;
            this.txt_km.BorderRadius = 17;
            this.txt_km.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_km.DefaultText = "";
            this.txt_km.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_km.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_km.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_km.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_km.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_km.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_km.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_km.Location = new System.Drawing.Point(176, 220);
            this.txt_km.Margin = new System.Windows.Forms.Padding(5);
            this.txt_km.Name = "txt_km";
            this.txt_km.PasswordChar = '\0';
            this.txt_km.PlaceholderText = "";
            this.txt_km.SelectedText = "";
            this.txt_km.Size = new System.Drawing.Size(223, 37);
            this.txt_km.TabIndex = 41;
            // 
            // txt_cor
            // 
            this.txt_cor.AutoRoundedCorners = true;
            this.txt_cor.BorderRadius = 17;
            this.txt_cor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cor.DefaultText = "";
            this.txt_cor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_cor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_cor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cor.Location = new System.Drawing.Point(176, 174);
            this.txt_cor.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.PasswordChar = '\0';
            this.txt_cor.PlaceholderText = "";
            this.txt_cor.SelectedText = "";
            this.txt_cor.Size = new System.Drawing.Size(264, 37);
            this.txt_cor.TabIndex = 40;
            // 
            // txt_nomecarro
            // 
            this.txt_nomecarro.AutoRoundedCorners = true;
            this.txt_nomecarro.BorderRadius = 17;
            this.txt_nomecarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nomecarro.DefaultText = "";
            this.txt_nomecarro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nomecarro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nomecarro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomecarro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomecarro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomecarro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecarro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nomecarro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomecarro.Location = new System.Drawing.Point(176, 80);
            this.txt_nomecarro.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nomecarro.Name = "txt_nomecarro";
            this.txt_nomecarro.PasswordChar = '\0';
            this.txt_nomecarro.PlaceholderText = "";
            this.txt_nomecarro.SelectedText = "";
            this.txt_nomecarro.Size = new System.Drawing.Size(329, 37);
            this.txt_nomecarro.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Modelo:";
            // 
            // txt_codigocarro
            // 
            this.txt_codigocarro.AutoRoundedCorners = true;
            this.txt_codigocarro.BorderRadius = 17;
            this.txt_codigocarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigocarro.DefaultText = "";
            this.txt_codigocarro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_codigocarro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_codigocarro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigocarro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigocarro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigocarro.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_codigocarro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_codigocarro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigocarro.Location = new System.Drawing.Point(176, 33);
            this.txt_codigocarro.Margin = new System.Windows.Forms.Padding(5);
            this.txt_codigocarro.Name = "txt_codigocarro";
            this.txt_codigocarro.PasswordChar = '\0';
            this.txt_codigocarro.PlaceholderText = "";
            this.txt_codigocarro.SelectedText = "";
            this.txt_codigocarro.Size = new System.Drawing.Size(105, 37);
            this.txt_codigocarro.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "KMs rodados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgv_automovel);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(856, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1059, 658);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AUTOMÓVEIS";
            // 
            // dgv_automovel
            // 
            this.dgv_automovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_automovel.Location = new System.Drawing.Point(21, 129);
            this.dgv_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_automovel.Name = "dgv_automovel";
            this.dgv_automovel.Size = new System.Drawing.Size(999, 582);
            this.dgv_automovel.TabIndex = 0;
            this.dgv_automovel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_automovel_CellClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // btn_sair
            // 
            this.btn_sair.AutoRoundedCorners = true;
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BorderRadius = 20;
            this.btn_sair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sair.FillColor = System.Drawing.Color.White;
            this.btn_sair.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sair.Location = new System.Drawing.Point(124, 572);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(87, 43);
            this.btn_sair.TabIndex = 51;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseTransparentBackground = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.btn_cadastrar.Location = new System.Drawing.Point(971, 745);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(173, 49);
            this.btn_cadastrar.TabIndex = 52;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseTransparentBackground = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
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
            this.btn_atualizar.Location = new System.Drawing.Point(1327, 745);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(173, 49);
            this.btn_atualizar.TabIndex = 53;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseTransparentBackground = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
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
            this.btn_desativar.Location = new System.Drawing.Point(1677, 745);
            this.btn_desativar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(173, 49);
            this.btn_desativar.TabIndex = 54;
            this.btn_desativar.Text = "Desativar";
            this.btn_desativar.UseTransparentBackground = true;
            this.btn_desativar.Click += new System.EventHandler(this.btn_desativar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.desativar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1603, 732);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 62);
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.atualizar;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1252, 732);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 62);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.cadastrar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(896, 732);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 62);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.pictureBox2.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.logo2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-19, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 191);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 826);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AUTOMÓVEIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 826);
            this.Controls.Add(this.btn_desativar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(250, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AUTOMÓVEIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMÓVEIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AUTOMÓVEIS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novo_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novo_marca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_automovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_automovel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Guna.UI2.WinForms.Guna2TextBox txt_codigocarro;
        private Guna.UI2.WinForms.Guna2Button btn_sair;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrar;
        private Guna.UI2.WinForms.Guna2Button btn_atualizar;
        private Guna.UI2.WinForms.Guna2Button btn_desativar;
        private Guna.UI2.WinForms.Guna2TextBox txt_nomecarro;
        private Guna.UI2.WinForms.Guna2TextBox txt_valor;
        private Guna.UI2.WinForms.Guna2TextBox txt_km;
        private Guna.UI2.WinForms.Guna2TextBox txt_cor;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_modelo;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_marca;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ano;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox novo_marca;
        private System.Windows.Forms.PictureBox novo_modelo;
    }
}