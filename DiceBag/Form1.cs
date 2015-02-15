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
            //Constants used for the index of the die row array;
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
            if (sidesDvarTbx.Text.ToString() == "" )
                return;
            int result=0;
            string output;
            
            if (modDvarTbx.Text.ToString() != "" && modDvarTbx.Text.ToString() != "0")
            {
                if (amountDvarTbx.Text.ToString() != "" && amountDvarTbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(Convert.ToInt32(sidesDvarTbx.Text.ToString()), Convert.ToInt32(amountDvarTbx.Text.ToString()), Convert.ToInt32(modDvarTbx.Text.ToString()));
                    output = result.ToString() + " = " + amountDvarTbx.Text.ToString() + " d" + sidesDvarTbx.Text.ToString() + " + " + modDvarTbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(Convert.ToInt32(sidesDvarTbx.Text.ToString()), Convert.ToInt32(modDvarTbx.Text.ToString()));
                    output =  result.ToString() + " = " + "1 d" + sidesDvarTbx.Text.ToString() + " + " + modDvarTbx.Text.ToString();
                }
            }
            else if (amountDvarTbx.Text.ToString() != "" && amountDvarTbx.Text.ToString() != "0")
            {
                result = bag.Roll(Convert.ToInt32(sidesDvarTbx.Text.ToString()), Convert.ToInt32(amountDvarTbx.Text.ToString()));
                output = result.ToString() + " = " + amountDvarTbx.Text.ToString() + " d" + sidesDvarTbx.Text.ToString();
            }
            else
            {
                result = bag.Roll(Convert.ToInt32(sidesDvarTbx.Text.ToString()));
                output = result.ToString() + " = " + "1 d" + sidesDvarTbx.Text.ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rollAllBtn_Click(object sender, EventArgs e)
        {
            int tempResult = 0;
            int result = 0;
            for (int i = 0; i < NUM_OF_DICE; i++)
            {
                tempResult = 0;
                if (dice[i].GetMod() != 0)
                {
                    if (dice[i].GetNumber() != 0)
                    {
                        tempResult = bag.RollMod(dice[i].GetSides(), dice[i].GetNumber(), dice[i].GetMod());
                    }
                    else
                    {
                        tempResult = bag.RollMod(dice[i].GetSides(),  dice[i].GetMod());
                    }
                }
                else if (dice[i].GetNumber() != 0)
                {
                    tempResult = bag.Roll(dice[i].GetSides(),dice[i].GetNumber());
                }
               
                result += tempResult;
            }
            resultsLbx.Items.Insert(0, result.ToString());
        }

        private void roll3Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD3Tbx.Text.ToString() != "" && modD3Tbx.Text.ToString() != "0")
            {
                if (amountD3Tbx.Text.ToString() != "" && amountD3Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D3].GetSides(), Convert.ToInt32(amountD3Tbx.Text.ToString()), Convert.ToInt32(modD3Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD3Tbx.Text.ToString() + " d" + dice[D3].GetSides().ToString() + " + " + modD3Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D3].GetSides(), Convert.ToInt32(modD3Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D3].GetSides().ToString() + " + " + modD3Tbx.Text.ToString();
                }
            }
            else if (amountD3Tbx.Text.ToString() != "" && amountD3Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D3].GetSides(), Convert.ToInt32(amountD3Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD3Tbx.Text.ToString() + " d" + dice[D3].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D3].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D3].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll4Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD4Tbx.Text.ToString() != "" && modD4Tbx.Text.ToString() != "0")
            {
                if (amountD4Tbx.Text.ToString() != "" && amountD4Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D4].GetSides(), Convert.ToInt32(amountD4Tbx.Text.ToString()), Convert.ToInt32(modD4Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD4Tbx.Text.ToString() + " d" + dice[D4].GetSides().ToString() + " + " + modD4Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D4].GetSides(), Convert.ToInt32(modD4Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D4].GetSides().ToString() + " + " + modD4Tbx.Text.ToString();
                }
            }
            else if (amountD4Tbx.Text.ToString() != "" && amountD4Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D4].GetSides(), Convert.ToInt32(amountD4Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD4Tbx.Text.ToString() + " d" + dice[D4].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D4].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D4].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll6Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD6Tbx.Text.ToString() != "" && modD6Tbx.Text.ToString() != "0")
            {
                if (amountD6Tbx.Text.ToString() != "" && amountD6Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D6].GetSides(), Convert.ToInt32(amountD6Tbx.Text.ToString()), Convert.ToInt32(modD6Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD6Tbx.Text.ToString() + " d" + dice[D6].GetSides().ToString() + " + " + modD6Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D6].GetSides(), Convert.ToInt32(modD6Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D6].GetSides().ToString() + " + " + modD6Tbx.Text.ToString();
                }
            }
            else if (amountD6Tbx.Text.ToString() != "" && amountD6Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D6].GetSides(), Convert.ToInt32(amountD6Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD6Tbx.Text.ToString() + " d" + dice[D6].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D6].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D6].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll8Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD8Tbx.Text.ToString() != "" && modD8Tbx.Text.ToString() != "0")
            {
                if (amountD8Tbx.Text.ToString() != "" && amountD8Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D8].GetSides(), Convert.ToInt32(amountD8Tbx.Text.ToString()), Convert.ToInt32(modD8Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD8Tbx.Text.ToString() + " d" + dice[D8].GetSides().ToString() + " + " + modD8Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D8].GetSides(), Convert.ToInt32(modD8Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D8].GetSides().ToString() + " + " + modD8Tbx.Text.ToString();
                }
            }
            else if (amountD8Tbx.Text.ToString() != "" && amountD8Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D8].GetSides(), Convert.ToInt32(amountD8Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD8Tbx.Text.ToString() + " d" + dice[D8].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D8].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D8].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll10Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD10Tbx.Text.ToString() != "" && modD10Tbx.Text.ToString() != "0")
            {
                if (amountD10Tbx.Text.ToString() != "" && amountD10Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D10].GetSides(), Convert.ToInt32(amountD10Tbx.Text.ToString()), Convert.ToInt32(modD10Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD10Tbx.Text.ToString() + " d" + dice[D10].GetSides().ToString() + " + " + modD10Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D10].GetSides(), Convert.ToInt32(modD10Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D10].GetSides().ToString() + " + " + modD10Tbx.Text.ToString();
                }
            }
            else if (amountD10Tbx.Text.ToString() != "" && amountD10Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D10].GetSides(), Convert.ToInt32(amountD10Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD10Tbx.Text.ToString() + " d" + dice[D10].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D10].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D10].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll12Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD12Tbx.Text.ToString() != "" && modD12Tbx.Text.ToString() != "0")
            {
                if (amountD12Tbx.Text.ToString() != "" && amountD12Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D12].GetSides(), Convert.ToInt32(amountD12Tbx.Text.ToString()), Convert.ToInt32(modD12Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD12Tbx.Text.ToString() + " d" + dice[D12].GetSides().ToString() + " + " + modD12Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D12].GetSides(), Convert.ToInt32(modD12Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D12].GetSides().ToString() + " + " + modD12Tbx.Text.ToString();
                }
            }
            else if (amountD12Tbx.Text.ToString() != "" && amountD12Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D12].GetSides(), Convert.ToInt32(amountD12Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD12Tbx.Text.ToString() + " d" + dice[D12].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D12].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D12].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void roll20Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD20Tbx.Text.ToString() != "" && modD20Tbx.Text.ToString() != "0")
            {
                if (amountD20Tbx.Text.ToString() != "" && amountD20Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D20].GetSides(), Convert.ToInt32(amountD20Tbx.Text.ToString()), Convert.ToInt32(modD20Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD20Tbx.Text.ToString() + " d" + dice[D20].GetSides().ToString() + " + " + modD20Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D20].GetSides(), Convert.ToInt32(modD20Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D20].GetSides().ToString() + " + " + modD20Tbx.Text.ToString();
                }
            }
            else if (amountD20Tbx.Text.ToString() != "" && amountD20Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D20].GetSides(), Convert.ToInt32(amountD20Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD20Tbx.Text.ToString() + " d" + dice[D20].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D20].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D20].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

        private void AmountTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[DVAR].SetNumber(Convert.ToInt32(amountDvarTbx.Text.ToString()));
            }
            catch(Exception exp)
            {
                dice[DVAR].SetNumber(0);// if user enters blank into the textbox
                string whyFail = exp.ToString();
            }
        }

        private void amountD3Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D3].SetNumber(Convert.ToInt32(amountD3Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D3].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }


        private void amountD6Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D6].SetNumber(Convert.ToInt32(amountD6Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D6].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD4Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D4].SetNumber(Convert.ToInt32(amountD4Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D4].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD8Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D8].SetNumber(Convert.ToInt32(amountD8Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D8].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD10Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D10].SetNumber(Convert.ToInt32(amountD10Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D10].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD12Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D12].SetNumber(Convert.ToInt32(amountD12Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D12].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD20Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D20].SetNumber(Convert.ToInt32(amountD20Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D20].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void amountD100Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D100].SetNumber(Convert.ToInt32(amountD100Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D100].SetNumber(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void sidesDvarTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[DVAR].SetSides(Convert.ToInt32(sidesDvarTbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[DVAR].SetSides(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD3Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D3].SetMod(Convert.ToInt32(modD3Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D3].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modDvarTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[DVAR].SetMod(Convert.ToInt32(modDvarTbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[DVAR].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD4Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D4].SetMod(Convert.ToInt32(modD4Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D4].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD6Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D6].SetMod(Convert.ToInt32(modD6Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D6].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD8Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D8].SetMod(Convert.ToInt32(modD8Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D8].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD10Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D10].SetMod(Convert.ToInt32(modD10Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D10].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD12Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D12].SetMod(Convert.ToInt32(modD12Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D12].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD20Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D20].SetMod(Convert.ToInt32(modD20Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D20].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void modD100Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dice[D100].SetMod(Convert.ToInt32(modD100Tbx.Text.ToString()));
            }
            catch (Exception exp)
            {
                dice[D100].SetMod(0);
                string whyFail = exp.ToString();
            }
            
        }

        private void roll100Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string output;

            if (modD100Tbx.Text.ToString() != "" && modD100Tbx.Text.ToString() != "0")
            {
                if (amountD100Tbx.Text.ToString() != "" && amountD100Tbx.Text.ToString() != "0")
                {
                    result = bag.RollMod(dice[D100].GetSides(), Convert.ToInt32(amountD100Tbx.Text.ToString()), Convert.ToInt32(modD100Tbx.Text.ToString()));
                    output = result.ToString() + " = " + amountD100Tbx.Text.ToString() + " d" + dice[D100].GetSides().ToString() + " + " + modD100Tbx.Text.ToString();
                }
                else
                {
                    result = bag.RollMod(dice[D100].GetSides(), Convert.ToInt32(modD100Tbx.Text.ToString()));
                    output = result.ToString() + " = " + "1 d" + dice[D100].GetSides().ToString() + " + " + modD100Tbx.Text.ToString();
                }
            }
            else if (amountD100Tbx.Text.ToString() != "" && amountD100Tbx.Text.ToString() != "0")
            {
                result = bag.Roll(dice[D100].GetSides(), Convert.ToInt32(amountD100Tbx.Text.ToString()));
                output = result.ToString() + " = " + amountD100Tbx.Text.ToString() + " d" + dice[D100].GetSides().ToString();
            }
            else
            {
                result = bag.Roll(dice[D100].GetSides());
                output = result.ToString() + " = " + "1 d" + dice[D100].GetSides().ToString(); ;
            }
            resultsLbx.Items.Insert(0, output.ToString());
        }

    
    }
}
