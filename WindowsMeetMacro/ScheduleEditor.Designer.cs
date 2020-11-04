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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.scheduleTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // scheduleTable
            // 
            this.scheduleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.scheduleTable.ColumnCount = 6;
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.Controls.Add(this.monLabel, 1, 0);
            this.scheduleTable.Controls.Add(this.tueLabel, 2, 0);
            this.scheduleTable.Controls.Add(this.wedLabel, 3, 0);
            this.scheduleTable.Controls.Add(this.thuLabel, 4, 0);
            this.scheduleTable.Controls.Add(this.friLabel, 5, 0);
            this.scheduleTable.Controls.Add(this.label1, 0, 1);
            this.scheduleTable.Controls.Add(this.label2, 0, 2);
            this.scheduleTable.Controls.Add(this.label3, 0, 3);
            this.scheduleTable.Controls.Add(this.label4, 0, 4);
            this.scheduleTable.Controls.Add(this.label5, 0, 5);
            this.scheduleTable.Controls.Add(this.label6, 0, 6);
            this.scheduleTable.Controls.Add(this.label7, 0, 7);
            this.scheduleTable.Location = new System.Drawing.Point(12, 15);
            this.scheduleTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowCount = 8;
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.scheduleTable.Size = new System.Drawing.Size(776, 438);
            this.scheduleTable.TabIndex = 0;
            // 
            // monLabel
            // 
            this.monLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monLabel.AutoSize = true;
            this.monLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monLabel.Location = new System.Drawing.Point(133, 1);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(122, 53);
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
            this.tueLabel.Location = new System.Drawing.Point(262, 1);
            this.tueLabel.Name = "tueLabel";
            this.tueLabel.Size = new System.Drawing.Size(122, 53);
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
            this.wedLabel.Location = new System.Drawing.Point(391, 1);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(122, 53);
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
            this.thuLabel.Location = new System.Drawing.Point(520, 1);
            this.thuLabel.Name = "thuLabel";
            this.thuLabel.Size = new System.Drawing.Size(122, 53);
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
            this.friLabel.Location = new System.Drawing.Point(649, 1);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(123, 53);
            this.friLabel.TabIndex = 4;
            this.friLabel.Text = "금요일";
            this.friLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "1교시";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 53);
            this.label2.TabIndex = 6;
            this.label2.Text = "2교시";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "3교시";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 53);
            this.label4.TabIndex = 8;
            this.label4.Text = "4교시";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 53);
            this.label5.TabIndex = 9;
            this.label5.Text = "5교시";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 53);
            this.label6.TabIndex = 10;
            this.label6.Text = "6교시";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 58);
            this.label7.TabIndex = 11;
            this.label7.Text = "7교시";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 461);
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
            this.openButton.AutoSize = true;
            this.openButton.Location = new System.Drawing.Point(602, 461);
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
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.scheduleTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ScheduleEditor";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}