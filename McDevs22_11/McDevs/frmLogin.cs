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
    public partial class frmLogin : Form
    {
        Thread nt;

        public frmLogin()
        {

            InitializeComponent();

        }

        private void run()
        {
            Application.Run(new frmSplash());

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbLista.SelectedIndex = 0;
        }


        public void limpaForm()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtEmail.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaForm();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadCliente cadastro = new frmCadCliente();
            cadastro.Show();
        }

        private void lblCadCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            nt = new Thread(voltar);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void voltar()
        {
            Application.Run(new frmCadCliente());
        }

        private void lblCadFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            nt = new Thread(voltar1);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }
        private void voltar1()
        {
            Application.Run(new frmCadFunc());
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente sair?", "McDevs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Entrar();
        }

        public void Entrar()
        {
                string sql;
            try //verifica se o email tá vazio
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("O campo E-mail' está vazio! \nPor favor preencha-o!", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    return;
                }

                //verifica se a senha tá vazia
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("O campo 'Senha' está vazio! \nPor favor preencha-o!", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return;
                }

                //se for cliente
                if (cmbLista.Text == "Cliente")
                {
                    //define o sql
                    sql = "select * from cliente where email_cli = @1 and senha_cli = @2 and excluido = false;";

                    List<object> param = new List<object>();
                    param.Add(txtEmail.Text);
                    param.Add(txtSenha.Text);

                    
                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    //se logou
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            int cod_cli =  Convert.ToInt32(dr["id_cliente"].ToString());
                            this.Visible = false;
                            frmCardapio cardapio = new frmCardapio();
                            cardapio.ShowDialog();
                           // frmAlterar admin = new frmAlterar();
                           // admin.ShowDialog();

                        }
                    }

                    //se nao logou
                     else
                     {
                         MessageBox.Show("Dados invalidos! \nDigite Novamente.", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         txtEmail.Focus();
                    }
                }


                //se for funcionário
                else 
                {
                    //define o sql
                    sql = "select * from funcionario where email_func = @1 and senha_func = @2 and excluido = false;";


                    List<object> param = new List<object>();
                    param.Add(txtEmail.Text);
                    param.Add(txtSenha.Text);

                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);

                    //se logou
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (txtEmail.Text == "admin@mcdevs.com" && txtSenha.Text == "mcdevs")
                            {
                                this.Visible = false;
                                frmMenuAdmin admin = new frmMenuAdmin();
                                admin.ShowDialog();
                            }
                            this.Hide();
                            frmCadCardapio cardapio = new frmCadCardapio();
                            cardapio.ShowDialog();
                        }
                    }

                    //se nao logou
                    else
                    {
                        MessageBox.Show("Dados invalidos! \nDigite Novamente.", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Focus();
                    }
                }

            }//try
            catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                "\n\nMais informações: " + ex.Message,
                           "McDevs",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }//catch
            }//Entrar
     }
}
        


