using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Npgsql;

namespace McDevs
{
    public partial class frmCadCardapio : Form
    {
        Thread nt;
        public frmCadCardapio()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltar);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();

        }
        private void voltar()
        {
            Application.Run(new frmLogin());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }
        public void limpaCampo()
        {
            txtProduto.Clear();
            mskPreco.Clear();
            txtCategoria.Clear();
            txtProduto.Focus();
        }

      
        private void frmCadCardapio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmCadCardapio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente sair?", "McDevs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        public void Cadastrar()
        {
            string sql, converter, converter1;
            try //Verifica se há algum campo vazio. Caso não, ele salva no banco
            {
                if (string.IsNullOrWhiteSpace(txtProduto.Text))
                {
                    MessageBox.Show("O campo 'Produto' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtProduto.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskPreco.Text))
                {
                    MessageBox.Show("O campo 'Preço' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskPreco.Focus();
                    return;
                }
               
                List<object> param = new List<object>();
                //
                param.Add((string)txtProduto.Text);
                param.Add((string)txtCategoria.Text);
                param.Add((string)mskPreco.Text);

                //definindo o insert
                sql = "insert into produto ( " +
                    "nome_prod, " +
                    "categoria, " +
                    "preco_prod)" +
                        "values ( @1, @2, @3);";

                //insertando
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Produto salvo com sucesso!",
                                "McDevs",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                limpaCampo();

            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                            "\n\nMais informações:" + ex.Message,
                       "McDevs",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
