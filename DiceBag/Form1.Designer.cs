namespace DiceBag
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RollBtn = new System.Windows.Forms.Button();
            this.AmountTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sidesTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultsLbx = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollBtn
            // 
            this.RollBtn.Location = new System.Drawing.Point(13, 36);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(37, 23);
            this.RollBtn.TabIndex = 0;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = true;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // AmountTbx
            // 
            this.AmountTbx.Location = new System.Drawing.Point(56, 39);
            this.AmountTbx.Name = "AmountTbx";
            this.AmountTbx.Size = new System.Drawing.Size(43, 20);
            this.AmountTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "d";
            // 
            // sidesTbx
            // 
            this.sidesTbx.Location = new System.Drawing.Point(124, 39);
            this.sidesTbx.Name = "sidesTbx";
            this.sidesTbx.Size = new System.Drawing.Size(39, 20);
            this.sidesTbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sides";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            // 
            // modTbx
            // 
            this.modTbx.Location = new System.Drawing.Point(189, 39);
            this.modTbx.Name = "modTbx";
            this.modTbx.Size = new System.Drawing.Size(40, 20);
            this.modTbx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modifier";
            // 
            // resultsLbx
            // 
            this.resultsLbx.FormattingEnabled = true;
            this.resultsLbx.Location = new System.Drawing.Point(265, 36);
            this.resultsLbx.Name = "resultsLbx";
            this.resultsLbx.Size = new System.Drawing.Size(120, 199);
            this.resultsLbx.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultsLbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sidesTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountTbx);
            this.Controls.Add(this.RollBtn);
            this.Name = "Form1";
            this.Text = "Dice Bag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.TextBox AmountTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sidesTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox resultsLbx;
        private System.Windows.Forms.Label label6;
    }
}

