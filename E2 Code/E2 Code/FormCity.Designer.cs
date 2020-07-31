namespace E2_Code
{
    partial class FormCity
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
            this.labelSelectedState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectedState
            // 
            this.labelSelectedState.AutoSize = true;
            this.labelSelectedState.Location = new System.Drawing.Point(49, 50);
            this.labelSelectedState.Name = "labelSelectedState";
            this.labelSelectedState.Size = new System.Drawing.Size(129, 25);
            this.labelSelectedState.TabIndex = 0;
            this.labelSelectedState.Text = "Change Me!";
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectedState);
            this.Name = "FormCity";
            this.Text = "Select a city";
            this.Load += new System.EventHandler(this.FormCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedState;
    }
}