namespace projeto_locadora_2022
{
    partial class CadastrarAutomovel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 477);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS";
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
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
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
            this.cmb_ano.Size = new System.Drawing.Size(104, 36);
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
            this.label7.Location = new System.Drawing.Point(75, 417);
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
            this.cmb_modelo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
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
            this.cmb_marca.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
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
            this.label9.Location = new System.Drawing.Point(75, 364);
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
            this.label5.Location = new System.Drawing.Point(8, 229);
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
            this.btn_cadastrar.Location = new System.Drawing.Point(241, 546);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(173, 49);
            this.btn_cadastrar.TabIndex = 58;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseTransparentBackground = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.cadastrar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(166, 533);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 62);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // CadastrarAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 608);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarAutomovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Automovel";
            this.Load += new System.EventHandler(this.CadastrarAutomovel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_modelo;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_marca;
        private Guna.UI2.WinForms.Guna2TextBox txt_valor;
        private Guna.UI2.WinForms.Guna2TextBox txt_km;
        private Guna.UI2.WinForms.Guna2TextBox txt_cor;
        private Guna.UI2.WinForms.Guna2TextBox txt_nomecarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_codigocarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ano;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private System.Windows.Forms.Label label7;
    }
}