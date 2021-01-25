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
    public partial class frmSplash : Form
    {
        int cont = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            cont++;
            pnlWalk.Left += 10;
            if (pnlWalk.Left > 220)
            {
                pnlWalk.Left = 0;
            }

            if (cont==50)
            {
                tmrSplash.Enabled = false;
                this.Close();
            }


        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrSplash.Start();
        }
    }
}
