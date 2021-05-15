
namespace fifteensWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.RepeatGame = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.NumberOfChanges = new System.Windows.Forms.Label();
            this.Changes = new System.Windows.Forms.Label();
            this.ShowTime = new System.Windows.Forms.Label();
            this.NameOfGame = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ColumnHeadersVisible = false;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(14, 194);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.RowTemplate.Height = 33;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(747, 715);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TabStop = false;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // RepeatGame
            // 
            this.RepeatGame.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatGame.Location = new System.Drawing.Point(807, 612);
            this.RepeatGame.Name = "RepeatGame";
            this.RepeatGame.Size = new System.Drawing.Size(258, 117);
            this.RepeatGame.TabIndex = 1;
            this.RepeatGame.Text = "Repeat game";
            this.RepeatGame.UseVisualStyleBackColor = true;
            this.RepeatGame.Click += new System.EventHandler(this.RepeatGame_Click);
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.Location = new System.Drawing.Point(1205, 612);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(259, 117);
            this.NewGame.TabIndex = 2;
            this.NewGame.Text = "New game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // NumberOfChanges
            // 
            this.NumberOfChanges.AutoSize = true;
            this.NumberOfChanges.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfChanges.Location = new System.Drawing.Point(1368, 255);
            this.NumberOfChanges.Name = "NumberOfChanges";
            this.NumberOfChanges.Size = new System.Drawing.Size(45, 51);
            this.NumberOfChanges.TabIndex = 3;
            this.NumberOfChanges.Text = "0";
            // 
            // Changes
            // 
            this.Changes.AutoSize = true;
            this.Changes.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changes.Location = new System.Drawing.Point(798, 255);
            this.Changes.Name = "Changes";
            this.Changes.Size = new System.Drawing.Size(442, 51);
            this.Changes.TabIndex = 4;
            this.Changes.Text = "Number of changes:";
            // 
            // ShowTime
            // 
            this.ShowTime.AutoSize = true;
            this.ShowTime.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTime.Location = new System.Drawing.Point(1372, 392);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(125, 51);
            this.ShowTime.TabIndex = 5;
            this.ShowTime.Text = "00:00";
            // 
            // NameOfGame
            // 
            this.NameOfGame.AutoSize = true;
            this.NameOfGame.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfGame.Location = new System.Drawing.Point(642, 38);
            this.NameOfGame.Name = "NameOfGame";
            this.NameOfGame.Size = new System.Drawing.Size(399, 74);
            this.NameOfGame.TabIndex = 6;
            this.NameOfGame.Text = "Barley-break";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(798, 392);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(126, 51);
            this.Time.TabIndex = 7;
            this.Time.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 1046);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.NameOfGame);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.Changes);
            this.Controls.Add(this.NumberOfChanges);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.RepeatGame);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RepeatGame;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label NumberOfChanges;
        private System.Windows.Forms.Label Changes;
        private System.Windows.Forms.Label ShowTime;
        private System.Windows.Forms.Label NameOfGame;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DataGridView dataGrid;
        //private System.Windows.Forms.DataGrid dataGrid;
    }
}

