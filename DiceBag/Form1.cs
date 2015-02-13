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
        const int DVAR = 0;
        const int D3 = 1;
        const int D4 = 2;
        const int D6 = 3;
        const int D8 = 4;
        const int D10 = 5;
        const int D12 = 6;
        const int D20 = 7;
        const int D100 = 8;
        const int NUM_OF_DICE = 9;
        DieRow[] dice = new DieRow[NUM_OF_DICE];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dice[DVAR] = new DieRow();
            dice[D3] = new DieRow(0, 3, 0);
            dice[D4] = new DieRow(0, 4, 0);
            dice[D6] = new DieRow(0, 6, 0);
            dice[D8] = new DieRow(0, 8, 0);
            dice[D10] = new DieRow(0, 10, 0);
            dice[D12] = new DieRow(0, 12, 0);
            dice[D20] = new DieRow(0, 20, 0);
            dice[D100] = new DieRow(0, 100, 0);

            bag = new DiceBag();
            
        }
        private void RollBtn_Click(object sender, EventArgs e)
        {
            int sides = 0;

            if (sidesDvarTbx.Text.ToString() == "")
                return;
            sides = Convert.ToInt32(sidesDvarTbx.Text.ToString());
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

        private void AmountTbx_TextChanged(object sender, EventArgs e)
        {
            dice[DVAR].SetNumber(Convert.ToInt32(amountDvarTbx.Text.ToString()));
        }

        private void amountD3Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D3].SetNumber(Convert.ToInt32(amountD3Tbx.Text.ToString()));
        }


        private void amountD6Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D6].SetNumber(Convert.ToInt32(amountD6Tbx.Text.ToString()));
        }

        private void amountD4Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D4].SetNumber(Convert.ToInt32(amountD4Tbx.Text.ToString()));
        }

        private void amountD8Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D8].SetNumber(Convert.ToInt32(amountD8Tbx.Text.ToString()));
        }

        private void amountD10Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D10].SetNumber(Convert.ToInt32(amountD10Tbx.Text.ToString()));
        }

        private void amountD12Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D12].SetNumber(Convert.ToInt32(amountD12Tbx.Text.ToString()));
        }

        private void amountD20Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D20].SetNumber(Convert.ToInt32(amountD20Tbx.Text.ToString()));
        }

        private void amountD100Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D100].SetNumber(Convert.ToInt32(amountD100Tbx.Text.ToString()));
        }

        private void sidesDvarTbx_TextChanged(object sender, EventArgs e)
        {
            dice[DVAR].SetSides(Convert.ToInt32(sidesDvarTbx.Text.ToString()));
        }

        private void modD3Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D3].SetMod(Convert.ToInt32(modD3Tbx.Text.ToString()));
        }

        private void modDvarTbx_TextChanged(object sender, EventArgs e)
        {
            dice[DVAR].SetMod(Convert.ToInt32(modDvarTbx.Text.ToString()));
        }

        private void modD4Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D4].SetMod(Convert.ToInt32(modD4Tbx.Text.ToString()));
        }

        private void modD6Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D6].SetMod(Convert.ToInt32(modD6Tbx.Text.ToString()));
        }

        private void modD8Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D6].SetMod(Convert.ToInt32(modD6Tbx.Text.ToString()));
        }

        private void modD10Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D10].SetMod(Convert.ToInt32(modD10Tbx.Text.ToString()));
        }

        private void modD12Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D12].SetMod(Convert.ToInt32(modD12Tbx.Text.ToString()));
        }

        private void modD20Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D20].SetMod(Convert.ToInt32(modD20Tbx.Text.ToString()));
        }

        private void modD100Tbx_TextChanged(object sender, EventArgs e)
        {
            dice[D100].SetMod(Convert.ToInt32(modD100Tbx.Text.ToString()));
        }

    
    }
}
