namespace McDevs
{
    partial class frmCadCliente
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCPFcliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mskCPFcliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSenhaCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblCadastro.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCadastro.Location = new System.Drawing.Point(86, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(335, 43);
            this.lblCadastro.TabIndex = 20;
            this.lblCadastro.Text = "Cadastro de Clientes";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(14, 83);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(58, 20);
            this.lblNomeCliente.TabIndex = 27;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblCPFcliente
            // 
            this.lblCPFcliente.AutoSize = true;
            this.lblCPFcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCPFcliente.ForeColor = System.Drawing.Color.White;
            this.lblCPFcliente.Location = new System.Drawing.Point(317, 83);
            this.lblCPFcliente.Name = "lblCPFcliente";
            this.lblCPFcliente.Size = new System.Drawing.Size(47, 20);
            this.lblCPFcliente.TabIndex = 28;
            this.lblCPFcliente.Text = "CPF:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(87, 83);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(210, 20);
            this.txtNomeCliente.TabIndex = 30;
            // 
            // mskCPFcliente
            // 
            this.mskCPFcliente.Location = new System.Drawing.Point(380, 85);
            this.mskCPFcliente.Mask = "000.000.000-00";
            this.mskCPFcliente.Name = "mskCPFcliente";
            this.mskCPFcliente.Size = new System.Drawing.Size(83, 20);
            this.mskCPFcliente.TabIndex = 32;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.txtEmailCliente.Location = new System.Drawing.Point(87, 132);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(210, 20);
            this.txtEmailCliente.TabIndex = 38;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(14, 132);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(62, 20);
            this.lblEmailCliente.TabIndex = 33;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.ForeColor = System.Drawing.Color.Black;
            this.txtSenhaCliente.Location = new System.Drawing.Point(380, 132);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(112, 20);
            this.txtSenhaCliente.TabIndex = 40;
            this.txtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVoltar.Location = new System.Drawing.Point(111, 206);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 28);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCadastrar.Location = new System.Drawing.Point(213, 206);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 28);
            this.btnCadastrar.TabIndex = 49;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpar.Location = new System.Drawing.Point(315, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 28);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSenhaCliente
            // 
            this.lblSenhaCliente.AutoSize = true;
            this.lblSenhaCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSenhaCliente.ForeColor = System.Drawing.Color.White;
            this.lblSenhaCliente.Location = new System.Drawing.Point(317, 132);
            this.lblSenhaCliente.Name = "lblSenhaCliente";
            this.lblSenhaCliente.Size = new System.Drawing.Size(61, 20);
            this.lblSenhaCliente.TabIndex = 51;
            this.lblSenhaCliente.Text = "Senha:";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::McDevs.Properties.Resources.Fundo_padrão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 255);
            this.Controls.Add(this.lblSenhaCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.mskCPFcliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblCPFcliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCPFcliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.MaskedTextBox mskCPFcliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSenhaCliente;
    }
}