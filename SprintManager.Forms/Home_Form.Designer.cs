namespace SprintManager.Forms
{
    partial class Home_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateSprint_btn = new System.Windows.Forms.Button();
            this.OpenSprint_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateSprint_btn
            // 
            this.CreateSprint_btn.Location = new System.Drawing.Point(133, 53);
            this.CreateSprint_btn.Name = "CreateSprint_btn";
            this.CreateSprint_btn.Size = new System.Drawing.Size(183, 52);
            this.CreateSprint_btn.TabIndex = 0;
            this.CreateSprint_btn.Text = "Create Sprint";
            this.CreateSprint_btn.UseVisualStyleBackColor = true;
            this.CreateSprint_btn.Click += new System.EventHandler(this.CreateSprint_btn_Click);
            // 
            // OpenSprint_btn
            // 
            this.OpenSprint_btn.Location = new System.Drawing.Point(392, 53);
            this.OpenSprint_btn.Name = "OpenSprint_btn";
            this.OpenSprint_btn.Size = new System.Drawing.Size(179, 52);
            this.OpenSprint_btn.TabIndex = 0;
            this.OpenSprint_btn.Text = "Open Sprint";
            this.OpenSprint_btn.UseVisualStyleBackColor = true;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenSprint_btn);
            this.Controls.Add(this.CreateSprint_btn);
            this.Name = "Home_Form";
            this.Text = "Sprint Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateSprint_btn;
        private System.Windows.Forms.Button OpenSprint_btn;
    }
}

