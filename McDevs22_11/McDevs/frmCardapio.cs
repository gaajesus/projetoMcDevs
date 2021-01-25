using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDevs
{
    public partial class frmCardapio : Form

    {
        public decimal auxPreco = 0;
        public frmCardapio()
        {
            InitializeComponent();
            CarregaDadosCardapio();

        }
        public void CarregaDadosCardapio()
        {
            string sql;

            sql = "SELECT id_prod, nome_prod, categoria, preco_prod FROM produto where excluido = false";

            DataTable dt = new DataTable();

            dt = ConexaoBanco.selecionarDataTable(sql);

            dtgCardapio.DataSource = dt;
        }

        private void txtIDLanche_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insira o ID do produto que deseja comprar!", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIDLanche.Focus();
        }

        public void Buscar()
        {
            string sql;

            try
            {
                if (!String.IsNullOrWhiteSpace(txtIDLanche.Text))
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(txtIDLanche.Text));
                    sql = "select * from produto where id_prod = @1 and excluido = false";

                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    if (dr.Read())
                    {
                        txtNomeLanche.Text = dr["nome_prod"].ToString();
                        mskPrecoLanche.Text = dr["preco_prod"].ToString();
                        auxPreco = Convert.ToDecimal(dr["preco_prod"]);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!", "McDevs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaForm();
                        txtIDLanche.Focus();
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
        public void limpaForm()
        {
            txtIDLanche.Clear();
            txtNomeLanche.Clear();
            mskPrecoLanche.Clear();
            auxPreco = 0;
            mskTotalPedido.Clear();
            numQtdLanche.Value = 1;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
            if (auxPreco != 0)
            {
                decimal qtd = Convert.ToDecimal(numQtdLanche.Value);
                decimal total = auxPreco * qtd;
                mskTotalPedido.Text = total.ToString();
            }
            btnBuscar.Enabled = true;
            btnComprar.Enabled = true;
        }

        private void numQtdLanche_ValueChanged(object sender, EventArgs e)
        {
            decimal qtd = Convert.ToDecimal(numQtdLanche.Value);
            decimal total = auxPreco * qtd;
            mskTotalPedido.Text = total.ToString();
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnComprar.Enabled = false;
        }
    }
}
