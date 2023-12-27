
namespace Tyuiu.DreminIa.Sprint7.Project.V15
{
    partial class FormAboutDeveloper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutDeveloper));
            this.textBoxAboutProgram = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAboutProgram
            // 
            this.textBoxAboutProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAboutProgram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAboutProgram.Location = new System.Drawing.Point(75, 12);
            this.textBoxAboutProgram.Multiline = true;
            this.textBoxAboutProgram.Name = "textBoxAboutProgram";
            this.textBoxAboutProgram.ReadOnly = true;
            this.textBoxAboutProgram.Size = new System.Drawing.Size(290, 143);
            this.textBoxAboutProgram.TabIndex = 3;
            this.textBoxAboutProgram.TabStop = false;
            this.textBoxAboutProgram.Text = resources.GetString("textBoxAboutProgram.Text");
            this.textBoxAboutProgram.TextChanged += new System.EventHandler(this.textBoxAboutProgram_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(391, 188);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 27);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAboutDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 223);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAboutProgram);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutDeveloper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Разработчик";
            this.Load += new System.EventHandler(this.FormAboutDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAboutProgram;
        private System.Windows.Forms.Button buttonOK;
    }
}