namespace WindowsMeetMacro
{
    partial class SettingForm
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
            this.viewLog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.classroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elementLoadTimeout = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startOffset = new System.Windows.Forms.NumericUpDown();
            this.endOffset = new System.Windows.Forms.NumericUpDown();
            this.scheduleType = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openSaveDirButton = new System.Windows.Forms.Button();
            this.openNotePadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementLoadTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // viewLog
            // 
            this.viewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewLog.AutoSize = true;
            this.viewLog.Location = new System.Drawing.Point(4, 160);
            this.viewLog.Name = "viewLog";
            this.viewLog.Size = new System.Drawing.Size(99, 19);
            this.viewLog.TabIndex = 0;
            this.viewLog.Text = "로그 보기";
            this.viewLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "로딩 타임 아웃";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "기본 학급";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.classroom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elementLoadTimeout, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewLog, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startOffset, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.endOffset, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.scheduleType, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 189);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // classroom
            // 
            this.classroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classroom.Location = new System.Drawing.Point(110, 34);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(224, 23);
            this.classroom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "기본 시간표 타입";
            // 
            // elementLoadTimeout
            // 
            this.elementLoadTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementLoadTimeout.Location = new System.Drawing.Point(110, 4);
            this.elementLoadTimeout.Name = "elementLoadTimeout";
            this.elementLoadTimeout.Size = new System.Drawing.Size(224, 23);
            this.elementLoadTimeout.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "시작 오프셋 (분)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "종료 오프셋 (분)";
            // 
            // startOffset
            // 
            this.startOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startOffset.Location = new System.Drawing.Point(110, 94);
            this.startOffset.Name = "startOffset";
            this.startOffset.Size = new System.Drawing.Size(224, 23);
            this.startOffset.TabIndex = 8;
            // 
            // endOffset
            // 
            this.endOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endOffset.Location = new System.Drawing.Point(110, 124);
            this.endOffset.Name = "endOffset";
            this.endOffset.Size = new System.Drawing.Size(224, 23);
            this.endOffset.TabIndex = 9;
            // 
            // scheduleType
            // 
            this.scheduleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scheduleType.Location = new System.Drawing.Point(110, 64);
            this.scheduleType.Name = "scheduleType";
            this.scheduleType.Size = new System.Drawing.Size(224, 23);
            this.scheduleType.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(275, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openSaveDirButton
            // 
            this.openSaveDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openSaveDirButton.AutoSize = true;
            this.openSaveDirButton.Location = new System.Drawing.Point(101, 205);
            this.openSaveDirButton.Name = "openSaveDirButton";
            this.openSaveDirButton.Size = new System.Drawing.Size(81, 25);
            this.openSaveDirButton.TabIndex = 7;
            this.openSaveDirButton.Text = "데이터 폴더";
            this.openSaveDirButton.UseVisualStyleBackColor = true;
            this.openSaveDirButton.Click += new System.EventHandler(this.openSaveDirButton_Click);
            // 
            // openNotePadButton
            // 
            this.openNotePadButton.AutoSize = true;
            this.openNotePadButton.Location = new System.Drawing.Point(188, 205);
            this.openNotePadButton.Name = "openNotePadButton";
            this.openNotePadButton.Size = new System.Drawing.Size(81, 25);
            this.openNotePadButton.TabIndex = 8;
            this.openNotePadButton.Text = "메모장 열기";
            this.openNotePadButton.UseVisualStyleBackColor = true;
            this.openNotePadButton.Click += new System.EventHandler(this.openNotePadButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 238);
            this.Controls.Add(this.openNotePadButton);
            this.Controls.Add(this.openSaveDirButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설정";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementLoadTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox viewLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;        
        private System.Windows.Forms.TextBox classroom;
        private System.Windows.Forms.NumericUpDown elementLoadTimeout;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startOffset;
        private System.Windows.Forms.NumericUpDown endOffset;
        private System.Windows.Forms.ComboBox scheduleType;
        private System.Windows.Forms.Button openSaveDirButton;
        private System.Windows.Forms.Button openNotePadButton;
    }
}