namespace McDevs
{
    partial class frmMenuAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgClientes = new System.Windows.Forms.TabPage();
            this.tpgFuncionarios = new System.Windows.Forms.TabPage();
            this.tpgLanches = new System.Windows.Forms.TabPage();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.dtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.dtgLanches = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpgClientes.SuspendLayout();
            this.tpgFuncionarios.SuspendLayout();
            this.tpgLanches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLanches)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgClientes);
            this.tabControl1.Controls.Add(this.tpgFuncionarios);
            this.tabControl1.Controls.Add(this.tpgLanches);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(39, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgClientes
            // 
            this.tpgClientes.Controls.Add(this.dtgClientes);
            this.tpgClientes.Location = new System.Drawing.Point(4, 22);
            this.tpgClientes.Name = "tpgClientes";
            this.tpgClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpgClientes.Size = new System.Drawing.Size(584, 336);
            this.tpgClientes.TabIndex = 0;
            this.tpgClientes.Text = "Clientes";
            this.tpgClientes.UseVisualStyleBackColor = true;
            // 
            // tpgFuncionarios
            // 
            this.tpgFuncionarios.Controls.Add(this.dtgFuncionarios);
            this.tpgFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpgFuncionarios.Name = "tpgFuncionarios";
            this.tpgFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgFuncionarios.Size = new System.Drawing.Size(583, 336);
            this.tpgFuncionarios.TabIndex = 1;
            this.tpgFuncionarios.Text = "Funcionarios";
            this.tpgFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpgLanches
            // 
            this.tpgLanches.Controls.Add(this.dtgLanches);
            this.tpgLanches.Location = new System.Drawing.Point(4, 22);
            this.tpgLanches.Name = "tpgLanches";
            this.tpgLanches.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLanches.Size = new System.Drawing.Size(583, 336);
            this.tpgLanches.TabIndex = 2;
            this.tpgLanches.Text = "Produtos";
            this.tpgLanches.UseVisualStyleBackColor = true;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(3, 3);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(581, 337);
            this.dtgClientes.TabIndex = 0;
            // 
            // dtgFuncionarios
            // 
            this.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionarios.Location = new System.Drawing.Point(2, 0);
            this.dtgFuncionarios.Name = "dtgFuncionarios";
            this.dtgFuncionarios.Size = new System.Drawing.Size(581, 337);
            this.dtgFuncionarios.TabIndex = 1;
            // 
            // dtgLanches
            // 
            this.dtgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLanches.Location = new System.Drawing.Point(2, 0);
            this.dtgLanches.Name = "dtgLanches";
            this.dtgLanches.Size = new System.Drawing.Size(581, 337);
            this.dtgLanches.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgPedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 336);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(2, 0);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.Size = new System.Drawing.Size(581, 337);
            this.dtgPedidos.TabIndex = 2;
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::McDevs.Properties.Resources.Fundo_padrão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 399);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpgClientes.ResumeLayout(false);
            this.tpgFuncionarios.ResumeLayout(false);
            this.tpgLanches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLanches)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgClientes;
        private System.Windows.Forms.TabPage tpgFuncionarios;
        private System.Windows.Forms.TabPage tpgLanches;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridView dtgFuncionarios;
        private System.Windows.Forms.DataGridView dtgLanches;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgPedidos;
    }
}