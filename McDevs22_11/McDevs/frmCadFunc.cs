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
    public partial class frmCadFunc : Form
    {
        Thread nt;
        public frmCadFunc()
        {
            InitializeComponent();
            txtNomeFunc.Focus();
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {
            
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
            txtNomeFunc.Clear();
            txtEmail.Clear();
            txtDress.Clear();
            txtSenha.Clear();
            mskCPF.Clear();
            mskNiver.Clear();
            mskRG.Clear();
            txtNomeFunc.Focus();
        }

        private void frmCadFunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente sair?", "McDevs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmCadFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
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
                if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                {
                    MessageBox.Show("O campo 'Nome' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtNomeFunc.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskCPF.Text))
                {
                    MessageBox.Show("O campo 'CPF' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskCPF.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskRG.Text))
                {
                    MessageBox.Show("O campo 'RG' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskRG.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskNiver.Text))
                {
                    MessageBox.Show("O campo 'Nascimento' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskNiver.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDress.Text))
                {
                    MessageBox.Show("O campo 'Endereço' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtDress.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("O campo 'Email' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtDress.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("O campo 'Senha' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtGen.Text))
                {
                    MessageBox.Show("O campo 'Gênero' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtGen.Focus();
                    return;
                }
                List<object> param = new List<object>();
                //
                param.Add((string)txtNomeFunc.Text);
                param.Add((string)mskCPF.Text);
                param.Add((string)mskRG.Text);
                param.Add((string)txtDress.Text);
                param.Add((string)txtGen.Text);
                param.Add((string)mskNiver.Text);
                param.Add((string)txtEmail.Text);
                param.Add((string)txtSenha.Text);

                //definindo o insert
                sql = "insert into funcionario ( " +
                    "nome_func , " +
                    "cpf_func, " +
                    "rg_func, " +
                    "endereco_func, " +
                    "genero_func, " +
                    "data_nasc_func, " +
                    "email_func, " +
                    "senha_func ) " +
                        "values ( @1, @2, @3, @4, @5, @6, @7, @8  );";

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
