
namespace fifteensWinForm
{
    partial class MenuForm
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
            this.Top10Time = new System.Windows.Forms.Button();
            this.Top10Steps = new System.Windows.Forms.Button();
            this.Last10 = new System.Windows.Forms.Button();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Top10Time
            // 
            this.Top10Time.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Top10Time.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top10Time.Location = new System.Drawing.Point(60, 78);
            this.Top10Time.Name = "Top10Time";
            this.Top10Time.Size = new System.Drawing.Size(172, 90);
            this.Top10Time.TabIndex = 0;
            this.Top10Time.Text = "Top 10 by time";
            this.Top10Time.UseVisualStyleBackColor = false;
            this.Top10Time.Click += new System.EventHandler(this.Top10Time_Click);
            // 
            // Top10Steps
            // 
            this.Top10Steps.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Top10Steps.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top10Steps.Location = new System.Drawing.Point(321, 78);
            this.Top10Steps.Name = "Top10Steps";
            this.Top10Steps.Size = new System.Drawing.Size(172, 90);
            this.Top10Steps.TabIndex = 1;
            this.Top10Steps.Text = "Top 10 by steps";
            this.Top10Steps.UseVisualStyleBackColor = false;
            this.Top10Steps.Click += new System.EventHandler(this.Top10Steps_Click);
            // 
            // Last10
            // 
            this.Last10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Last10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last10.Location = new System.Drawing.Point(582, 79);
            this.Last10.Name = "Last10";
            this.Last10.Size = new System.Drawing.Size(172, 90);
            this.Last10.TabIndex = 2;
            this.Last10.Text = "Last 10";
            this.Last10.UseVisualStyleBackColor = false;
            this.Last10.Click += new System.EventHandler(this.Last10_Click);
            // 
            // ClearHistory
            // 
            this.ClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearHistory.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClearHistory.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearHistory.Location = new System.Drawing.Point(854, 78);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(172, 90);
            this.ClearHistory.TabIndex = 3;
            this.ClearHistory.Text = "Clear history";
            this.ClearHistory.UseVisualStyleBackColor = false;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1104, 78);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(172, 90);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back to game";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Top10Time);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.ClearHistory);
            this.panel1.Controls.Add(this.Top10Steps);
            this.panel1.Controls.Add(this.Last10);
            this.panel1.Location = new System.Drawing.Point(213, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 247);
            this.panel1.TabIndex = 5;
            // 
            // GridResult
            // 
            this.GridResult.AllowUserToAddRows = false;
            this.GridResult.AllowUserToDeleteRows = false;
            this.GridResult.AllowUserToResizeColumns = false;
            this.GridResult.AllowUserToResizeRows = false;
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Location = new System.Drawing.Point(562, 340);
            this.GridResult.MultiSelect = false;
            this.GridResult.Name = "GridResult";
            this.GridResult.ReadOnly = true;
            this.GridResult.RowHeadersVisible = false;
            this.GridResult.RowHeadersWidth = 92;
            this.GridResult.RowTemplate.Height = 37;
            this.GridResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridResult.ShowCellErrors = false;
            this.GridResult.ShowCellToolTips = false;
            this.GridResult.ShowEditingIcon = false;
            this.GridResult.ShowRowErrors = false;
            this.GridResult.Size = new System.Drawing.Size(677, 361);
            this.GridResult.TabIndex = 6;
            this.GridResult.TabStop = false;
            this.GridResult.Visible = false;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(766, 282);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(279, 43);
            this.Results.TabIndex = 7;
            this.Results.Text = "Choose option";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1972, 821);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2000, 900);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Top10Time;
        private System.Windows.Forms.Button Top10Steps;
        private System.Windows.Forms.Button Last10;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.Label Results;
    }
}