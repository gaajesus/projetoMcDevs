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
namespace McDevs
{
    public partial class frmCadCliente : Form
    {
        Thread nt;
        public frmCadCliente()
        {
            InitializeComponent();
            txtNomeCliente.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            txtEmailCliente.Clear();
            txtNomeCliente.Clear();
            mskCPFcliente.Clear();
            txtSenhaCliente.Clear();
            txtNomeCliente.Focus();
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
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
            string sql;
            try //Verifica se há algum campo vazio. Caso não, ele salva no banco
            {
                if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                {
                    MessageBox.Show("O campo 'Nome' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtNomeCliente.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskCPFcliente.Text))
                {
                    MessageBox.Show("O campo 'CPF' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskCPFcliente.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmailCliente.Text))
                {
                    MessageBox.Show("O campo 'Endereço' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtEmailCliente.Focus();
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(txtSenhaCliente.Text))
                {
                    MessageBox.Show("O campo 'Senha' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtSenhaCliente.Focus();
                    return;
                }
               
                List<object> param = new List<object>();
                //
                param.Add((string)txtNomeCliente.Text);
                param.Add((string)mskCPFcliente.Text);
                param.Add((string)txtSenhaCliente.Text);
                param.Add((string)txtEmailCliente.Text);
                

                //definindo o insert
                sql = "insert into cliente ( " +
                    "nome_cliente , " +
                    "cpf_cliente, " +
                    "senha_cli," +
                    "email_cli ) " +
                        "values ( @1, @2, @3, @4 );";

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
