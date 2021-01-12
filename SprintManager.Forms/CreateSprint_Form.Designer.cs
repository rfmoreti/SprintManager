namespace SprintManager.Forms
{
    partial class CreateSprint_Form
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
            this.SprintName_txt = new System.Windows.Forms.TextBox();
            this.SprintName_lbl = new System.Windows.Forms.Label();
            this.SprintTime_lbl = new System.Windows.Forms.Label();
            this.FirstDay_picker = new System.Windows.Forms.DateTimePicker();
            this.LastDay_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveSprint_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SprintName_txt
            // 
            this.SprintName_txt.Location = new System.Drawing.Point(124, 33);
            this.SprintName_txt.Name = "SprintName_txt";
            this.SprintName_txt.Size = new System.Drawing.Size(125, 27);
            this.SprintName_txt.TabIndex = 0;
            // 
            // SprintName_lbl
            // 
            this.SprintName_lbl.AutoSize = true;
            this.SprintName_lbl.Location = new System.Drawing.Point(23, 36);
            this.SprintName_lbl.Name = "SprintName_lbl";
            this.SprintName_lbl.Size = new System.Drawing.Size(95, 20);
            this.SprintName_lbl.TabIndex = 1;
            this.SprintName_lbl.Text = "Sprint Name:";
            // 
            // SprintTime_lbl
            // 
            this.SprintTime_lbl.AutoSize = true;
            this.SprintTime_lbl.Location = new System.Drawing.Point(23, 91);
            this.SprintTime_lbl.Name = "SprintTime_lbl";
            this.SprintTime_lbl.Size = new System.Drawing.Size(63, 20);
            this.SprintTime_lbl.TabIndex = 2;
            this.SprintTime_lbl.Text = "Periodo:";
            // 
            // FirstDay_picker
            // 
            this.FirstDay_picker.Location = new System.Drawing.Point(23, 124);
            this.FirstDay_picker.Name = "FirstDay_picker";
            this.FirstDay_picker.Size = new System.Drawing.Size(250, 27);
            this.FirstDay_picker.TabIndex = 3;
            // 
            // LastDay_picker
            // 
            this.LastDay_picker.Location = new System.Drawing.Point(23, 212);
            this.LastDay_picker.Name = "LastDay_picker";
            this.LastDay_picker.Size = new System.Drawing.Size(250, 27);
            this.LastDay_picker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // SaveSprint_btn
            // 
            this.SaveSprint_btn.Location = new System.Drawing.Point(179, 277);
            this.SaveSprint_btn.Name = "SaveSprint_btn";
            this.SaveSprint_btn.Size = new System.Drawing.Size(94, 29);
            this.SaveSprint_btn.TabIndex = 5;
            this.SaveSprint_btn.Text = "Save";
            this.SaveSprint_btn.UseVisualStyleBackColor = true;
            // 
            // CreateSprint_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 318);
            this.Controls.Add(this.SaveSprint_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastDay_picker);
            this.Controls.Add(this.FirstDay_picker);
            this.Controls.Add(this.SprintTime_lbl);
            this.Controls.Add(this.SprintName_lbl);
            this.Controls.Add(this.SprintName_txt);
            this.Name = "CreateSprint_Form";
            this.Text = "Create Sprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SprintName_txt;
        private System.Windows.Forms.Label SprintName_lbl;
        private System.Windows.Forms.Label SprintTime_lbl;
        private System.Windows.Forms.DateTimePicker FirstDay_picker;
        private System.Windows.Forms.DateTimePicker LastDay_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveSprint_btn;
    }
}