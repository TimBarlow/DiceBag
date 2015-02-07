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

            if (sidesTbx.Text.ToString() == "")
                return;
            sides = Convert.ToInt32(sidesTbx.Text.ToString());
            int result = bag.Roll(sides);
            resultsLbx.Items.Insert(0,result.ToString());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rollAllBtn_Click(object sender, EventArgs e)
        {
            RollBtn_Click(sender, e);
        }

        private void roll3Btn_Click(object sender, EventArgs e)
        {

            resultsLbx.Items.Insert(0,bag.Roll(3).ToString());
        }

        private void roll4Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(4).ToString());
        }

        private void roll6Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(6).ToString());
        }

        private void roll8Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(8).ToString());
        }

        private void roll10Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(10).ToString());
        }

        private void roll12Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(12).ToString());
        }

        private void roll20Btn_Click(object sender, EventArgs e)
        {
            resultsLbx.Items.Insert(0,bag.Roll(20).ToString());
        }

    
    }
}
