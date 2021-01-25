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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
            CarregaDados();
            CarregaDados1();
            CarregaDados2();
            CarregaDados3();

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlterar alterar = new frmAlterar();
            alterar.ShowDialog();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemover remover = new frmRemover();
            remover.ShowDialog();

        }

        private void frmMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

  
        public void CarregaDados()
        {
            string sql;

            sql = "select id_prod,nome_prod," +
                    " preco_prod,qtd_prod FROM produto";


            DataTable dt = new DataTable();

            dt = ConexaoBanco.selecionarDataTable(sql);

            dtgLanches.DataSource = dt;
        }
        public void CarregaDados1()
        {
            string sql;

            sql = "select *" +
                    " FROM cliente";


            DataTable dt = new DataTable();

            dt = ConexaoBanco.selecionarDataTable(sql);

            dtgClientes.DataSource = dt;
        }
        public void CarregaDados2()
        {
            string sql;

            sql = "select id_func, nome_func, rg_func, endereco_func, data_nasc_func" +
                    " FROM funcionario ORDER BY id_func";


            DataTable dt = new DataTable();

            dt = ConexaoBanco.selecionarDataTable(sql);

            dtgFuncionarios.DataSource = dt;
        }
        public void CarregaDados3()
        {
            string sql;

            sql = "select *" +
                    " FROM pedido";


            DataTable dt = new DataTable();

            dt = ConexaoBanco.selecionarDataTable(sql);

            dtgPedidos.DataSource = dt;
        }
    }
}
