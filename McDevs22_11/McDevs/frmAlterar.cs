using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace McDevs
{
    public partial class frmAlterar : Form
    {
        private int cod_cli;

        public frmAlterar()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            string sql;
            
            try
            {
                if (!String.IsNullOrWhiteSpace(txtID.Text))
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(txtID.Text));
                    sql = "select * from funcionario where id_func = @1";

                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    if (dr.HasRows)
                    {
                       while (dr.Read())
                       {
                            txtNomeFunc.Text = dr["nome_func"].ToString();
                            mskCPF.Text = dr["cpf_func"].ToString();
                            mskRG.Text = dr["rg_func"].ToString();
                            txtDress.Text = dr["endereco_func"].ToString();
                            mskNiver.Text = dr["data_nasc_func"].ToString();
                            txtEmail.Text = dr["email_func"].ToString();
                            txtSenha.Text = dr["senha_func"].ToString();
                            txtGen.Text = dr["genero_func"].ToString();
                       }
                    }
                    else
                    {
                        MessageBox.Show("Funcionario não encontrado", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LimpaForm();
                        //txtId_Produto.Focus();
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                "\n\nMais informações:" + ex.Message,
                           "celular CTI 72A",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        public void buscar1()
        {
            string sql;

            try
            {
                if (!String.IsNullOrWhiteSpace(txtID_cli.Text))
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(txtID_cli.Text));
                    sql = "select * from cliente where id_cliente = @1";

                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    if (dr.Read())
                    {
                        txtNomeCliente.Text = dr["nome_cliente"].ToString();
                        mskCPFcliente.Text = dr["cpf_cliente"].ToString();
                        txtEmailCliente.Text = dr["email_cli"].ToString();
                        txtSenhaCliente.Text = dr["senha_cli"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LimpaForm();
                        //txtId_Produto.Focus();
                    }
                    dr.Close();
                    //HabilitarBotoes(true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                "\n\nMais informações:" + ex.Message,
                           "celular CTI 72A",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        public void buscar2()
        {
            string sql;

            try
            {
                if (!String.IsNullOrWhiteSpace(txtId_prod.Text))
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(txtId_prod.Text));
                    sql = "select * from produto where id_prod = @1";
                    //string aux;
                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    if (dr.Read())
                    {
                        txtProduto.Text = dr["nome_prod"].ToString();
                        txtCatg.Text = dr["categoria"].ToString();
                        mskPreco.Text = dr["preco_prod"].ToString();
                        //aux = dr["categoria"].ToString();
                        //dr.Close();

                        //DataTable dt = ConexaoBanco.selecionarDataTable(sql);

                        // cmbCat.DataSource = dt;
                        //cmbCat.ValueMember = "categoria";
                        //cmbCat.SelectedText = aux;
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LimpaForm();
                        //txtId_Produto.Focus();
                    }
                    dr.Close();
                    //HabilitarBotoes(true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                "\n\nMais informações:" + ex.Message,
                           "celular CTI 72A",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        public void Alterar()
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
                param.Add(Convert.ToInt64(txtID.Text));

                //definindo o insert
                sql = "update funcionario set " +
                    "nome_func=@1 , " +
                    "cpf_func=@2 , " +
                    "rg_func=@3 , " +
                    "endereco_func=@4 , " +
                    "genero_func=@5 , " +
                    "data_nasc_func=@6 , " +
                    "email_func=@7 , " +
                    "senha_func=@8 " +
                    "where id_func = @9;";


                //insertando
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Produto salvo com sucesso!",
                                "McDevs",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                //limpaCampo();

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

        public void Alterar1()
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
                    txtNomeFunc.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(mskCPFcliente.Text))
                {
                    MessageBox.Show("O campo 'CPF' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    mskCPF.Focus();
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(txtEmailCliente.Text))
                {
                    MessageBox.Show("O campo 'Email' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtDress.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSenhaCliente.Text))
                {
                    MessageBox.Show("O campo 'Senha' está vazio! Por favor preencha-o!",
                                   "McDevs",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return;
                }
                List<object> param = new List<object>();
                //
                param.Add((string)txtNomeCliente.Text);
                param.Add((string)mskCPFcliente.Text);
                param.Add((string)txtEmailCliente.Text);
                param.Add((string)txtSenhaCliente.Text);
                param.Add(Convert.ToInt64(txtID_cli.Text));

                //definindo o insert
                sql = "update cliente set " +
                    "nome_cliente=@1 , " +
                    "cpf_cliente=@2 , " +
                    "email_cli=@3 , " +
                    "senha_cli=@4 " +
                    "where id_cliente = @5;";


                //insertando
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Dados alterados com sucesso!",
                                "McDevs",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                //limpaCampo();

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
        public void Alterar2()
        {
            string sql;
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
                if (string.IsNullOrWhiteSpace(txtCatg.Text))
                {
                    MessageBox.Show("O campo 'Categoria' está vazio! Por favor preencha-o!",
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
                param.Add((string)txtCatg.Text);
                param.Add((string)mskPreco.Text);
                param.Add(Convert.ToInt64(txtId_prod.Text));

                //definindo o insert
                sql = "update produto set " +
                    "nome_prod=@1 , " +
                    "categoria=@2 , " +
                    "preco_prod=@3 " +
                    "where id_prod = @4;";


                //insertando
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Produto salvo com sucesso!",
                                "McDevs",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                //limpaCampo();

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
    
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            buscar1();
        }

        private void btnBusc_prod_Click(object sender, EventArgs e)
        {
            buscar2();
        }

        private void btnAlt_prod_Click(object sender, EventArgs e)
        {
            Alterar2();
        }

        private void btnAltCli_Click(object sender, EventArgs e)
        {
            Alterar1();
        }

        private void BtnExc_prod_Click(object sender, EventArgs e)
        {
            excluir2();
        }
        public void excluir()
        {
            string sql;
            try //Verifica se há algum campo vazio. Caso não, ele salva no banco
            {
                List<object> param = new List<object>();
                //
                param.Add(Convert.ToInt64(txtID.Text));

                //definindo o insert
                sql = "update funcionario set " +
                    "excluido = TRUE " +
                    "where id_func = @1;";


                //insertando
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Funcionario excluído com sucesso!",
                                "McDevs",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                //limpaCampo();

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
    
        public void excluir1()
        {
                string sql;
                try //Verifica se há algum campo vazio. Caso não, ele salva no banco
                {
                    List<object> param = new List<object>();
                    //
                    param.Add(Convert.ToInt64(txtID_cli.Text));

                    //definindo o insert
                    sql = "update cliente set " +
                        "excluido = TRUE " +
                        "where id_cliente = @1;";


                    //insertando
                    ConexaoBanco.executar(sql, param);
                    MessageBox.Show("Cliente excluido com sucesso!",
                                    "McDevs",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    //limpaCampo();

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
        public void excluir2()
            {
                string sql;
                try //Verifica se há algum campo vazio. Caso não, ele salva no banco
                {
                    List<object> param = new List<object>();
                    //
                    param.Add(Convert.ToInt64(txtId_prod.Text));

                    //definindo o insert
                    sql = "update produto set " +
                        "excluido = TRUE " +
                        "where id_prod = @1;";


                    //insertando
                    ConexaoBanco.executar(sql, param);
                    MessageBox.Show("Produto excluido com sucesso!",
                                    "McDevs",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    //limpaCampo();

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

        private void BtnExcCli_Click(object sender, EventArgs e)
        {
            excluir1();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            excluir();
        }
    }
}
