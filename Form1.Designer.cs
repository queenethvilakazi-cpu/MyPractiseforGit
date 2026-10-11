namespace MyPractiseforGit
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
            this.Connected = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connected
            // 
            this.Connected.Location = new System.Drawing.Point(440, 205);
            this.Connected.Name = "Connected";
            this.Connected.Size = new System.Drawing.Size(162, 101);
            this.Connected.TabIndex = 0;
            this.Connected.Text = "btnConnect";
            this.Connected.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(53, 105);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Connected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connected;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox1;
    }
}

