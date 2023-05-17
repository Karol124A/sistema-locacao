namespace projeto_locadora_2022
{
    partial class CadastrarFuncionario
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_cargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_contrato = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_telefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nome_funcionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_codigo_funcionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cmb_cargo);
            this.groupBox3.Controls.Add(this.dtp_contrato);
            this.groupBox3.Controls.Add(this.txt_telefone);
            this.groupBox3.Controls.Add(this.txt_nome_funcionario);
            this.groupBox3.Controls.Add(this.txt_codigo_funcionario);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(16, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(533, 332);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS";
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.AutoRoundedCorners = true;
            this.cmb_cargo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_cargo.BorderRadius = 17;
            this.cmb_cargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cargo.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_cargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_cargo.ItemHeight = 30;
            this.cmb_cargo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cmb_cargo.Location = new System.Drawing.Point(193, 261);
            this.cmb_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(311, 36);
            this.cmb_cargo.TabIndex = 71;
            // 
            // dtp_contrato
            // 
            this.dtp_contrato.AutoRoundedCorners = true;
            this.dtp_contrato.BorderRadius = 17;
            this.dtp_contrato.Checked = true;
            this.dtp_contrato.FillColor = System.Drawing.Color.White;
            this.dtp_contrato.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtp_contrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_contrato.Location = new System.Drawing.Point(199, 217);
            this.dtp_contrato.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_contrato.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_contrato.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_contrato.Name = "dtp_contrato";
            this.dtp_contrato.Size = new System.Drawing.Size(307, 37);
            this.dtp_contrato.TabIndex = 70;
            this.dtp_contrato.Value = new System.DateTime(2022, 11, 16, 16, 48, 45, 655);
            // 
            // txt_telefone
            // 
            this.txt_telefone.AutoRoundedCorners = true;
            this.txt_telefone.BorderRadius = 17;
            this.txt_telefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefone.DefaultText = "";
            this.txt_telefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefone.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_telefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_telefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefone.Location = new System.Drawing.Point(199, 162);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(5);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.PasswordChar = '\0';
            this.txt_telefone.PlaceholderText = "";
            this.txt_telefone.SelectedText = "";
            this.txt_telefone.Size = new System.Drawing.Size(307, 37);
            this.txt_telefone.TabIndex = 69;
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.AutoRoundedCorners = true;
            this.txt_nome_funcionario.BorderRadius = 17;
            this.txt_nome_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome_funcionario.DefaultText = "";
            this.txt_nome_funcionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome_funcionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome_funcionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome_funcionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome_funcionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome_funcionario.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_nome_funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nome_funcionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome_funcionario.Location = new System.Drawing.Point(199, 108);
            this.txt_nome_funcionario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.PasswordChar = '\0';
            this.txt_nome_funcionario.PlaceholderText = "";
            this.txt_nome_funcionario.SelectedText = "";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(319, 37);
            this.txt_nome_funcionario.TabIndex = 68;
            // 
            // txt_codigo_funcionario
            // 
            this.txt_codigo_funcionario.AutoRoundedCorners = true;
            this.txt_codigo_funcionario.BorderRadius = 17;
            this.txt_codigo_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo_funcionario.DefaultText = "";
            this.txt_codigo_funcionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_codigo_funcionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_codigo_funcionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo_funcionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo_funcionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo_funcionario.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_codigo_funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_codigo_funcionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo_funcionario.Location = new System.Drawing.Point(199, 62);
            this.txt_codigo_funcionario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_codigo_funcionario.Name = "txt_codigo_funcionario";
            this.txt_codigo_funcionario.PasswordChar = '\0';
            this.txt_codigo_funcionario.PlaceholderText = "";
            this.txt_codigo_funcionario.SelectedText = "";
            this.txt_codigo_funcionario.Size = new System.Drawing.Size(105, 37);
            this.txt_codigo_funcionario.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(103, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contratado em:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(79, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(107, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nome:";
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
            this.btn_cadastrar.Location = new System.Drawing.Point(235, 364);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(173, 49);
            this.btn_cadastrar.TabIndex = 61;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseTransparentBackground = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::projeto_locadora_2022.Properties.Resources.cadastrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(160, 352);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 425);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarFuncionario";
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_cargo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_contrato;
        private Guna.UI2.WinForms.Guna2TextBox txt_telefone;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome_funcionario;
        private Guna.UI2.WinForms.Guna2TextBox txt_codigo_funcionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}