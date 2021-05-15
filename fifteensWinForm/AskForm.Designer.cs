
namespace fifteensWinForm
{
    partial class AskForm
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
            this.Ask = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ask
            // 
            this.Ask.AutoSize = true;
            this.Ask.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ask.Location = new System.Drawing.Point(105, 90);
            this.Ask.Name = "Ask";
            this.Ask.Size = new System.Drawing.Size(371, 51);
            this.Ask.TabIndex = 0;
            this.Ask.Text = "Enter your name:";
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(333, 241);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(271, 81);
            this.Input.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.OK.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(114, 422);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(186, 111);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(627, 422);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(186, 111);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ask);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Location = new System.Drawing.Point(173, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 611);
            this.panel1.TabIndex = 4;
            // 
            // AskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 721);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1275, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1275, 800);
            this.Name = "AskForm";
            this.Text = "Enter info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ask;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
    }
}