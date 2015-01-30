using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceBag
{
    public partial class Form1 : Form
    {
        DiceBag bag;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bag = new DiceBag();
        }
        private void RollBtn_Click(object sender, EventArgs e)
        {
            int sides = 0;
            try
            {
                 sides = Convert.ToInt32(sidesTbx.Text.ToString());
            }
            catch
            {

            }
            int result = bag.Roll(sides);
            resultsLbx.Items.Add(result.ToString());
        }

    
    }
}
