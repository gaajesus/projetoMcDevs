namespace McDevs
{
    partial class frmCardapio
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
            this.tabCardapio = new System.Windows.Forms.TabControl();
            this.tabPaginacao = new System.Windows.Forms.TabPage();
            this.lblCardápio = new System.Windows.Forms.Label();
            this.dtgCardapio = new System.Windows.Forms.DataGridView();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.numQtdLanche = new System.Windows.Forms.NumericUpDown();
            this.mskTotalPedido = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskPrecoLanche = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomeLanche = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQtdLanche = new System.Windows.Forms.Label();
            this.lblNomeLanche = new System.Windows.Forms.Label();
            this.lblLanche = new System.Windows.Forms.Label();
            this.txtIDLanche = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.tabCardapio.SuspendLayout();
            this.tabPaginacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapio)).BeginInit();
            this.tabPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdLanche)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCardapio
            // 
            this.tabCardapio.Controls.Add(this.tabPaginacao);
            this.tabCardapio.Controls.Add(this.tabPedido);
            this.tabCardapio.Location = new System.Drawing.Point(-3, 1);
            this.tabCardapio.Name = "tabCardapio";
            this.tabCardapio.SelectedIndex = 0;
            this.tabCardapio.Size = new System.Drawing.Size(456, 375);
            this.tabCardapio.TabIndex = 1;
            // 
            // tabPaginacao
            // 
            this.tabPaginacao.BackgroundImage = global::McDevs.Properties.Resources.Fundo_padrão;
            this.tabPaginacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPaginacao.Controls.Add(this.lblCardápio);
            this.tabPaginacao.Controls.Add(this.dtgCardapio);
            this.tabPaginacao.Location = new System.Drawing.Point(4, 22);
            this.tabPaginacao.Name = "tabPaginacao";
            this.tabPaginacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaginacao.Size = new System.Drawing.Size(448, 349);
            this.tabPaginacao.TabIndex = 0;
            this.tabPaginacao.Text = "Cardápio";
            this.tabPaginacao.UseVisualStyleBackColor = true;
            // 
            // lblCardápio
            // 
            this.lblCardápio.BackColor = System.Drawing.Color.Transparent;
            this.lblCardápio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblCardápio.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCardápio.Location = new System.Drawing.Point(142, 17);
            this.lblCardápio.Name = "lblCardápio";
            this.lblCardápio.Size = new System.Drawing.Size(157, 43);
            this.lblCardápio.TabIndex = 17;
            this.lblCardápio.Text = "Cardápio";
            // 
            // dtgCardapio
            // 
            this.dtgCardapio.AllowUserToAddRows = false;
            this.dtgCardapio.AllowUserToDeleteRows = false;
            this.dtgCardapio.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCardapio.Location = new System.Drawing.Point(-5, 62);
            this.dtgCardapio.Name = "dtgCardapio";
            this.dtgCardapio.ReadOnly = true;
            this.dtgCardapio.Size = new System.Drawing.Size(448, 270);
            this.dtgCardapio.TabIndex = 0;
            // 
            // tabPedido
            // 
            this.tabPedido.BackgroundImage = global::McDevs.Properties.Resources.Fundo_padrão;
            this.tabPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPedido.Controls.Add(this.numQtdLanche);
            this.tabPedido.Controls.Add(this.mskTotalPedido);
            this.tabPedido.Controls.Add(this.label1);
            this.tabPedido.Controls.Add(this.mskPrecoLanche);
            this.tabPedido.Controls.Add(this.btnSair);
            this.tabPedido.Controls.Add(this.btnComprar);
            this.tabPedido.Controls.Add(this.btnBuscar);
            this.tabPedido.Controls.Add(this.txtNomeLanche);
            this.tabPedido.Controls.Add(this.lblTotal);
            this.tabPedido.Controls.Add(this.lblQtdLanche);
            this.tabPedido.Controls.Add(this.lblNomeLanche);
            this.tabPedido.Controls.Add(this.lblLanche);
            this.tabPedido.Controls.Add(this.txtIDLanche);
            this.tabPedido.Controls.Add(this.lblPedido);
            this.tabPedido.Location = new System.Drawing.Point(4, 22);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedido.Size = new System.Drawing.Size(448, 349);
            this.tabPedido.TabIndex = 1;
            this.tabPedido.Text = "Pedido";
            this.tabPedido.ToolTipText = "Insira o ID do produto que deseja comprar:";
            this.tabPedido.UseVisualStyleBackColor = true;
            // 
            // numQtdLanche
            // 
            this.numQtdLanche.Location = new System.Drawing.Point(2, 166);
            this.numQtdLanche.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQtdLanche.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdLanche.Name = "numQtdLanche";
            this.numQtdLanche.Size = new System.Drawing.Size(38, 20);
            this.numQtdLanche.TabIndex = 138;
            this.numQtdLanche.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdLanche.ValueChanged += new System.EventHandler(this.numQtdLanche_ValueChanged);
            // 
            // mskTotalPedido
            // 
            this.mskTotalPedido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTotalPedido.Enabled = false;
            this.mskTotalPedido.Location = new System.Drawing.Point(324, 223);
            this.mskTotalPedido.Mask = "$00,00";
            this.mskTotalPedido.Name = "mskTotalPedido";
            this.mskTotalPedido.Size = new System.Drawing.Size(54, 20);
            this.mskTotalPedido.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 136;
            this.label1.Text = "Total:";
            // 
            // mskPrecoLanche
            // 
            this.mskPrecoLanche.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskPrecoLanche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskPrecoLanche.Enabled = false;
            this.mskPrecoLanche.Location = new System.Drawing.Point(324, 109);
            this.mskPrecoLanche.Mask = "$00,00";
            this.mskPrecoLanche.Name = "mskPrecoLanche";
            this.mskPrecoLanche.Size = new System.Drawing.Size(54, 20);
            this.mskPrecoLanche.TabIndex = 135;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSair.Location = new System.Drawing.Point(303, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 28);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnComprar.Location = new System.Drawing.Point(162, 288);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(110, 28);
            this.btnComprar.TabIndex = 27;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBuscar.Location = new System.Drawing.Point(21, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 28);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtNomeLanche
            // 
            this.txtNomeLanche.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomeLanche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeLanche.Enabled = false;
            this.txtNomeLanche.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomeLanche.Location = new System.Drawing.Point(2, 223);
            this.txtNomeLanche.Name = "txtNomeLanche";
            this.txtNomeLanche.Size = new System.Drawing.Size(190, 20);
            this.txtNomeLanche.TabIndex = 24;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(320, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 24);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Preço unitário:";
            // 
            // lblQtdLanche
            // 
            this.lblQtdLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLanche.ForeColor = System.Drawing.Color.White;
            this.lblQtdLanche.Location = new System.Drawing.Point(-2, 139);
            this.lblQtdLanche.Name = "lblQtdLanche";
            this.lblQtdLanche.Size = new System.Drawing.Size(104, 24);
            this.lblQtdLanche.TabIndex = 21;
            this.lblQtdLanche.Text = "Quantidade:";
            // 
            // lblNomeLanche
            // 
            this.lblNomeLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLanche.ForeColor = System.Drawing.Color.White;
            this.lblNomeLanche.Location = new System.Drawing.Point(1, 196);
            this.lblNomeLanche.Name = "lblNomeLanche";
            this.lblNomeLanche.Size = new System.Drawing.Size(71, 24);
            this.lblNomeLanche.TabIndex = 20;
            this.lblNomeLanche.Text = "Produto:";
            // 
            // lblLanche
            // 
            this.lblLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanche.ForeColor = System.Drawing.Color.White;
            this.lblLanche.Location = new System.Drawing.Point(-2, 82);
            this.lblLanche.Name = "lblLanche";
            this.lblLanche.Size = new System.Drawing.Size(31, 24);
            this.lblLanche.TabIndex = 19;
            this.lblLanche.Text = "ID:";
            // 
            // txtIDLanche
            // 
            this.txtIDLanche.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIDLanche.Location = new System.Drawing.Point(2, 108);
            this.txtIDLanche.Name = "txtIDLanche";
            this.txtIDLanche.Size = new System.Drawing.Size(48, 20);
            this.txtIDLanche.TabIndex = 18;
            // 
            // lblPedido
            // 
            this.lblPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblPedido.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPedido.Location = new System.Drawing.Point(157, 17);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(126, 43);
            this.lblPedido.TabIndex = 17;
            this.lblPedido.Text = "Pedido";
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 351);
            this.Controls.Add(this.tabCardapio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            this.tabCardapio.ResumeLayout(false);
            this.tabPaginacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardapio)).EndInit();
            this.tabPedido.ResumeLayout(false);
            this.tabPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdLanche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCardapio;
        private System.Windows.Forms.TabPage tabPaginacao;
        private System.Windows.Forms.Label lblCardápio;
        private System.Windows.Forms.DataGridView dtgCardapio;
        private System.Windows.Forms.TabPage tabPedido;
        private System.Windows.Forms.NumericUpDown numQtdLanche;
        private System.Windows.Forms.MaskedTextBox mskTotalPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskPrecoLanche;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNomeLanche;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQtdLanche;
        private System.Windows.Forms.Label lblNomeLanche;
        private System.Windows.Forms.Label lblLanche;
        private System.Windows.Forms.TextBox txtIDLanche;
        private System.Windows.Forms.Label lblPedido;
    }
}