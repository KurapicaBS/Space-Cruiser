namespace Space_Cruiser
{
    partial class Form_Main
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
            this.space1 = new Space_Cruiser.Space();
            this.SuspendLayout();
            // 
            // space1
            // 
            this.space1.BackColor = System.Drawing.Color.Black;
            this.space1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.space1.Location = new System.Drawing.Point(0, 0);
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(598, 360);
            this.space1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 360);
            this.Controls.Add(this.space1);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Space space1;
    }
}

