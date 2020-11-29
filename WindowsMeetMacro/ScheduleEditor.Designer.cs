namespace WindowsMeetMacro
{
    partial class ScheduleEditor
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
            this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.monLabel = new System.Windows.Forms.Label();
            this.tueLabel = new System.Windows.Forms.Label();
            this.wedLabel = new System.Windows.Forms.Label();
            this.thuLabel = new System.Windows.Forms.Label();
            this.friLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.scheduleTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // scheduleTable
            // 
            this.scheduleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleTable.AutoSize = true;
            this.scheduleTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.scheduleTable.ColumnCount = 6;
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.scheduleTable.Controls.Add(this.monLabel, 1, 0);
            this.scheduleTable.Controls.Add(this.tueLabel, 2, 0);
            this.scheduleTable.Controls.Add(this.wedLabel, 3, 0);
            this.scheduleTable.Controls.Add(this.thuLabel, 4, 0);
            this.scheduleTable.Controls.Add(this.friLabel, 5, 0);
            this.scheduleTable.Location = new System.Drawing.Point(12, 15);
            this.scheduleTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowCount = 1;
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.scheduleTable.Size = new System.Drawing.Size(758, 52);
            this.scheduleTable.TabIndex = 0;
            // 
            // monLabel
            // 
            this.monLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monLabel.AutoSize = true;
            this.monLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monLabel.Location = new System.Drawing.Point(130, 1);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(119, 50);
            this.monLabel.TabIndex = 0;
            this.monLabel.Text = "월요일";
            this.monLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tueLabel
            // 
            this.tueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tueLabel.AutoSize = true;
            this.tueLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tueLabel.Location = new System.Drawing.Point(256, 1);
            this.tueLabel.Name = "tueLabel";
            this.tueLabel.Size = new System.Drawing.Size(119, 50);
            this.tueLabel.TabIndex = 1;
            this.tueLabel.Text = "화요일";
            this.tueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wedLabel
            // 
            this.wedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wedLabel.AutoSize = true;
            this.wedLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wedLabel.Location = new System.Drawing.Point(382, 1);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(119, 50);
            this.wedLabel.TabIndex = 2;
            this.wedLabel.Text = "수요일";
            this.wedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thuLabel
            // 
            this.thuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thuLabel.AutoSize = true;
            this.thuLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thuLabel.Location = new System.Drawing.Point(508, 1);
            this.thuLabel.Name = "thuLabel";
            this.thuLabel.Size = new System.Drawing.Size(119, 50);
            this.thuLabel.TabIndex = 3;
            this.thuLabel.Text = "목요일";
            this.thuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friLabel
            // 
            this.friLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friLabel.AutoSize = true;
            this.friLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friLabel.Location = new System.Drawing.Point(634, 1);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(120, 50);
            this.friLabel.TabIndex = 4;
            this.friLabel.Text = "금요일";
            this.friLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(695, 75);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.AutoSize = true;
            this.openButton.Location = new System.Drawing.Point(584, 75);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(105, 29);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "메모장으로 열기";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 112);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.scheduleTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ScheduleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "시간표";
            this.Load += new System.EventHandler(this.ScheduleEditor_Load);
            this.scheduleTable.ResumeLayout(false);
            this.scheduleTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel scheduleTable;
        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Label tueLabel;
        private System.Windows.Forms.Label wedLabel;
        private System.Windows.Forms.Label thuLabel;
        private System.Windows.Forms.Label friLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}