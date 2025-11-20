namespace EXP_Project19_DVLD.Before_start_project._3Simple_event_with_parametar
{
    partial class EventFrm1
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
            this.ctlCalculator1 = new EXP_Project19_DVLD.Before_start_project._3Simple_event_with_parametar.ctlCalculator();
            this.SuspendLayout();
            // 
            // ctlCalculator1
            // 
            this.ctlCalculator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctlCalculator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlCalculator1.Location = new System.Drawing.Point(109, 15);
            this.ctlCalculator1.Margin = new System.Windows.Forms.Padding(6);
            this.ctlCalculator1.Name = "ctlCalculator1";
            this.ctlCalculator1.Size = new System.Drawing.Size(882, 426);
            this.ctlCalculator1.TabIndex = 0;
            this.ctlCalculator1.OnCalculationComplete += new System.Action<int>(this.ctlCalculator1_OnCalculationComplete);
            // 
            // EventFrm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 516);
            this.Controls.Add(this.ctlCalculator1);
            this.Name = "EventFrm1";
            this.Text = "EventFrm1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlCalculator ctlCalculator1;
    }
}