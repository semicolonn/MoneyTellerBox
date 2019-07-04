namespace tellerApp
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
            this.grpBoxTeller = new System.Windows.Forms.GroupBox();
            this.lab_ch = new System.Windows.Forms.Label();
            this.labAfs = new System.Windows.Forms.Label();
            this.txtBox_ch = new System.Windows.Forms.TextBox();
            this.userEnter = new System.Windows.Forms.Label();
            this.comBoxCurr = new System.Windows.Forms.ComboBox();
            this.txtCurr = new System.Windows.Forms.TextBox();
            this.grpBoxTeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTeller
            // 
            this.grpBoxTeller.Controls.Add(this.lab_ch);
            this.grpBoxTeller.Controls.Add(this.labAfs);
            this.grpBoxTeller.Controls.Add(this.txtBox_ch);
            this.grpBoxTeller.Controls.Add(this.userEnter);
            this.grpBoxTeller.Controls.Add(this.comBoxCurr);
            this.grpBoxTeller.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTeller.Location = new System.Drawing.Point(42, 31);
            this.grpBoxTeller.Name = "grpBoxTeller";
            this.grpBoxTeller.Size = new System.Drawing.Size(586, 140);
            this.grpBoxTeller.TabIndex = 0;
            this.grpBoxTeller.TabStop = false;
            this.grpBoxTeller.Text = "Change Currency with Teller Box";
            // 
            // lab_ch
            // 
            this.lab_ch.AutoSize = true;
            this.lab_ch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ch.Location = new System.Drawing.Point(499, 67);
            this.lab_ch.Name = "lab_ch";
            this.lab_ch.Size = new System.Drawing.Size(78, 18);
            this.lab_ch.TabIndex = 9;
            this.lab_ch.Text = "curTypes";
            // 
            // labAfs
            // 
            this.labAfs.AutoSize = true;
            this.labAfs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAfs.Location = new System.Drawing.Point(138, 66);
            this.labAfs.Name = "labAfs";
            this.labAfs.Size = new System.Drawing.Size(34, 18);
            this.labAfs.TabIndex = 10;
            this.labAfs.Text = "Afs";
            // 
            // txtBox_ch
            // 
            this.txtBox_ch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ch.Location = new System.Drawing.Point(391, 63);
            this.txtBox_ch.Name = "txtBox_ch";
            this.txtBox_ch.Size = new System.Drawing.Size(100, 27);
            this.txtBox_ch.TabIndex = 8;
            // 
            // userEnter
            // 
            this.userEnter.AutoSize = true;
            this.userEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEnter.Location = new System.Drawing.Point(8, 42);
            this.userEnter.Name = "userEnter";
            this.userEnter.Size = new System.Drawing.Size(127, 18);
            this.userEnter.TabIndex = 5;
            this.userEnter.Text = "Enter Currency";
            // 
            // comBoxCurr
            // 
            this.comBoxCurr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxCurr.FormattingEnabled = true;
            this.comBoxCurr.Location = new System.Drawing.Point(200, 63);
            this.comBoxCurr.Name = "comBoxCurr";
            this.comBoxCurr.Size = new System.Drawing.Size(185, 26);
            this.comBoxCurr.TabIndex = 7;
            this.comBoxCurr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCurr
            // 
            this.txtCurr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurr.Location = new System.Drawing.Point(53, 94);
            this.txtCurr.Name = "txtCurr";
            this.txtCurr.Size = new System.Drawing.Size(124, 27);
            this.txtCurr.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(676, 190);
            this.Controls.Add(this.txtCurr);
            this.Controls.Add(this.grpBoxTeller);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teller Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxTeller.ResumeLayout(false);
            this.grpBoxTeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTeller;
        private System.Windows.Forms.Label userEnter;
        private System.Windows.Forms.Label lab_ch;
        private System.Windows.Forms.TextBox txtBox_ch;
        private System.Windows.Forms.TextBox txtCurr;
        private System.Windows.Forms.ComboBox comBoxCurr;
        private System.Windows.Forms.Label labAfs;

    }
}

