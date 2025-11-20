namespace EXP_Project19_DVLD.Before_start_project._3Simple_event_with_parametar
{
    partial class ctlCalculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(120, 88);
            this.labelNumber1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(94, 24);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Number1:";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(120, 250);
            this.labelNumber2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(94, 24);
            this.labelNumber2.TabIndex = 1;
            this.labelNumber2.Text = "Number1:";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(396, 163);
            this.plus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(21, 24);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(639, 163);
            this.equal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(21, 24);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(682, 163);
            this.result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 24);
            this.result.TabIndex = 4;
            this.result.Text = "???";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(223, 88);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(387, 29);
            this.txtNumber1.TabIndex = 5;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(223, 245);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(387, 29);
            this.txtNumber2.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(324, 342);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(174, 55);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ctlCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ctlCalculator";
            this.Size = new System.Drawing.Size(882, 426);
            this.Load += new System.EventHandler(this.ctlCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnCalculate;
    }
}
