namespace E2_Code
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStates = new System.Windows.Forms.ListBox();
            this.buttonSeeTheCities = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a state";
            // 
            // listBoxStates
            // 
            this.listBoxStates.FormattingEnabled = true;
            this.listBoxStates.ItemHeight = 25;
            this.listBoxStates.Location = new System.Drawing.Point(32, 90);
            this.listBoxStates.Name = "listBoxStates";
            this.listBoxStates.Size = new System.Drawing.Size(432, 154);
            this.listBoxStates.TabIndex = 1;
            // 
            // buttonSeeTheCities
            // 
            this.buttonSeeTheCities.Location = new System.Drawing.Point(285, 290);
            this.buttonSeeTheCities.Name = "buttonSeeTheCities";
            this.buttonSeeTheCities.Size = new System.Drawing.Size(179, 45);
            this.buttonSeeTheCities.TabIndex = 2;
            this.buttonSeeTheCities.Text = "See the Cities";
            this.buttonSeeTheCities.UseVisualStyleBackColor = true;
            this.buttonSeeTheCities.Click += new System.EventHandler(this.buttonSeeTheCities_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(83, 290);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(179, 45);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonSeeTheCities;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(508, 374);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSeeTheCities);
            this.Controls.Add(this.listBoxStates);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "CSC 470 - E2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStates;
        private System.Windows.Forms.Button buttonSeeTheCities;
        private System.Windows.Forms.Button buttonExit;
    }
}

