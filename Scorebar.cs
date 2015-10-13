using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class Scorebar : Form ,View
    {
        public Scorebar()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            label1.Text = ((TwoZeroFourEightModel)m).Score.ToString();
        }
        private void Scorebar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
