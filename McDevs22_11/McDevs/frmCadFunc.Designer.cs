namespace McDevs
{
    partial class frmCadFunc
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
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblCPFcliente = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblNiver = new System.Windows.Forms.Label();
            this.mskNiver = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lblDress = new System.Windows.Forms.Label();
            this.txtDress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(461, 89);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(83, 20);
            this.mskCPF.TabIndex = 44;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.ForeColor = System.Drawing.Color.Black;
            this.txtNomeFunc.Location = new System.Drawing.Point(130, 89);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(250, 20);
            this.txtNomeFunc.TabIndex = 41;
            // 
            // lblCPFcliente
            // 
            this.lblCPFcliente.AutoSize = true;
            this.lblCPFcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCPFcliente.ForeColor = System.Drawing.Color.White;
            this.lblCPFcliente.Location = new System.Drawing.Point(395, 87);
            this.lblCPFcliente.Name = "lblCPFcliente";
            this.lblCPFcliente.Size = new System.Drawing.Size(47, 20);
            this.lblCPFcliente.TabIndex = 40;
            this.lblCPFcliente.Text = "CPF:";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomeFunc.ForeColor = System.Drawing.Color.White;
            this.lblNomeFunc.Location = new System.Drawing.Point(21, 87);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(58, 20);
            this.lblNomeFunc.TabIndex = 39;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblCadastro.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCadastro.Location = new System.Drawing.Point(71, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(414, 43);
            this.lblCadastro.TabIndex = 36;
            this.lblCadastro.Text = "Cadastro de Funcionários";
            // 
            // lblNiver
            // 
            this.lblNiver.AutoSize = true;
            this.lblNiver.BackColor = System.Drawing.Color.Transparent;
            this.lblNiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNiver.ForeColor = System.Drawing.Color.White;
            this.lblNiver.Location = new System.Drawing.Point(21, 133);
            this.lblNiver.Name = "lblNiver";
            this.lblNiver.Size = new System.Drawing.Size(103, 20);
            this.lblNiver.TabIndex = 64;
            this.lblNiver.Text = "Nascimento:";
            // 
            // mskNiver
            // 
            this.mskNiver.Location = new System.Drawing.Point(130, 133);
            this.mskNiver.Mask = "00/00/0000";
            this.mskNiver.Name = "mskNiver";
            this.mskNiver.Size = new System.Drawing.Size(68, 20);
            this.mskNiver.TabIndex = 63;
            this.mskNiver.ValidatingType = typeof(System.DateTime);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(397, 133);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(39, 20);
            this.lblRG.TabIndex = 100;
            this.lblRG.Text = "RG:";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(461, 131);
            this.mskRG.Mask = "00.000.000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(83, 20);
            this.mskRG.TabIndex = 99;
            // 
            // lblDress
            // 
            this.lblDress.AutoSize = true;
            this.lblDress.BackColor = System.Drawing.Color.Transparent;
            this.lblDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDress.ForeColor = System.Drawing.Color.White;
            this.lblDress.Location = new System.Drawing.Point(21, 179);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(85, 20);
            this.lblDress.TabIndex = 109;
            this.lblDress.Text = "Endereço:";
            // 
            // txtDress
            // 
            this.txtDress.ForeColor = System.Drawing.Color.Black;
            this.txtDress.Location = new System.Drawing.Point(130, 181);
            this.txtDress.Name = "txtDress";
            this.txtDress.Size = new System.Drawing.Size(210, 20);
            this.txtDress.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(130, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 116;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(21, 222);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(62, 20);
            this.lblEmailCliente.TabIndex = 110;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(432, 224);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(112, 20);
            this.txtSenha.TabIndex = 118;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpar.Location = new System.Drawing.Point(354, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 28);
            this.btnLimpar.TabIndex = 127;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCadastrar.Location = new System.Drawing.Point(238, 268);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 28);
            this.btnCadastrar.TabIndex = 126;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVoltar.Location = new System.Drawing.Point(122, 268);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 28);
            this.btnVoltar.TabIndex = 125;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtGen
            // 
            this.txtGen.ForeColor = System.Drawing.Color.Black;
            this.txtGen.Location = new System.Drawing.Point(279, 133);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(112, 20);
            this.txtGen.TabIndex = 128;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.Transparent;
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGen.ForeColor = System.Drawing.Color.White;
            this.lblGen.Location = new System.Drawing.Point(204, 133);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(69, 20);
            this.lblGen.TabIndex = 129;
            this.lblGen.Text = "Gênero:";
            // 
            // frmCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::McDevs.Properties.Resources.Fundo_padrão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 306);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblDress);
            this.Controls.Add(this.txtDress);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.mskRG);
            this.Controls.Add(this.lblNiver);
            this.Controls.Add(this.mskNiver);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblCPFcliente);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadFunc_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadFunc_FormClosed);
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblCPFcliente;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblNiver;
        private System.Windows.Forms.MaskedTextBox mskNiver;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.TextBox txtDress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
    }
}