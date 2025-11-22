namespace EXP_Project19_DVLD.People
{
    partial class frmAddNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPerson));
            this.ctlAddPerson1 = new EXP_Project19_DVLD.People.ctlAddPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PersonID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlAddPerson1
            // 
            this.ctlAddPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlAddPerson1.Location = new System.Drawing.Point(20, 96);
            this.ctlAddPerson1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.ctlAddPerson1.Name = "ctlAddPerson1";
            this.ctlAddPerson1.Size = new System.Drawing.Size(1032, 434);
            this.ctlAddPerson1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(378, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Person ID:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(123, 52);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 35;
            this.pictureBox9.TabStop = false;
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Location = new System.Drawing.Point(158, 52);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(42, 24);
            this.PersonID.TabIndex = 36;
            this.PersonID.Text = "N/A";
            // 
            // frmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 547);
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlAddPerson1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAddNewPerson";
            this.Text = "frmAddNewPerson";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlAddPerson ctlAddPerson1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label PersonID;
    }
}