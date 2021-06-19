namespace FileSorter
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.currentPathTextBox = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.extListBox = new System.Windows.Forms.CheckedListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderSelBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPanel1 = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extDataGrid = new System.Windows.Forms.DataGridView();
            this.btnPanel2 = new System.Windows.Forms.Panel();
            this.DelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deselectBtn = new System.Windows.Forms.Button();
            this.allDirOrThisDir = new System.Windows.Forms.CheckBox();
            this.delEmptyFolder = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.btnPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extDataGrid)).BeginInit();
            this.btnPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.currentPathTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentPathTextBox.Font = new System.Drawing.Font("NanumBarunGothicOTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentPathTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentPathTextBox.Location = new System.Drawing.Point(0, 0);
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.Size = new System.Drawing.Size(534, 24);
            this.currentPathTextBox.TabIndex = 0;
            this.currentPathTextBox.Text = "C:\\폴더를 선택해주세요";
            this.currentPathTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("NanumBarunGothicOTF UltraLight", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logTextBox.Location = new System.Drawing.Point(0, 24);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(364, 242);
            this.logTextBox.TabIndex = 4;
            this.logTextBox.TabStop = false;
            this.logTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // extListBox
            // 
            this.extListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(129)))));
            this.extListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extListBox.CheckOnClick = true;
            this.extListBox.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.extListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.extListBox.Font = new System.Drawing.Font("NanumBarunGothicOTF Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.extListBox.ForeColor = System.Drawing.Color.White;
            this.extListBox.FormattingEnabled = true;
            this.extListBox.HorizontalScrollbar = true;
            this.extListBox.Location = new System.Drawing.Point(3, 3);
            this.extListBox.Name = "extListBox";
            this.extListBox.Size = new System.Drawing.Size(156, 90);
            this.extListBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(3, 93);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(156, 18);
            this.progressBar.TabIndex = 4;
            // 
            // folderSelBtn
            // 
            this.folderSelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderSelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.folderSelBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.folderSelBtn.Location = new System.Drawing.Point(3, 157);
            this.folderSelBtn.Name = "folderSelBtn";
            this.folderSelBtn.Size = new System.Drawing.Size(156, 30);
            this.folderSelBtn.TabIndex = 2;
            this.folderSelBtn.Text = "폴더선택";
            this.folderSelBtn.UseVisualStyleBackColor = true;
            this.folderSelBtn.Click += new System.EventHandler(this.folderSelBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.startBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.Location = new System.Drawing.Point(3, 111);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(156, 46);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "정리시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(364, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(170, 242);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPanel1);
            this.tabPage1.Controls.Add(this.folderSelBtn);
            this.tabPage1.Controls.Add(this.startBtn);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.extListBox);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(162, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPanel1
            // 
            this.btnPanel1.Controls.Add(this.deselectBtn);
            this.btnPanel1.Controls.Add(this.InfoBtn);
            this.btnPanel1.Controls.Add(this.selectAllBtn);
            this.btnPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel1.Location = new System.Drawing.Point(3, 187);
            this.btnPanel1.Name = "btnPanel1";
            this.btnPanel1.Size = new System.Drawing.Size(156, 27);
            this.btnPanel1.TabIndex = 6;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF UltraLight", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoBtn.Location = new System.Drawing.Point(120, 0);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(36, 27);
            this.InfoBtn.TabIndex = 3;
            this.InfoBtn.Text = "정보";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectAllBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectAllBtn.Location = new System.Drawing.Point(0, 0);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(60, 27);
            this.selectAllBtn.TabIndex = 3;
            this.selectAllBtn.Text = "전체선택";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.extDataGrid);
            this.tabPage2.Controls.Add(this.delEmptyFolder);
            this.tabPage2.Controls.Add(this.allDirOrThisDir);
            this.tabPage2.Controls.Add(this.btnPanel2);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(162, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // extDataGrid
            // 
            this.extDataGrid.AllowUserToResizeColumns = false;
            this.extDataGrid.AllowUserToResizeRows = false;
            this.extDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.extDataGrid.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("NanumBarunGothicOTF", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.extDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.extDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extDataGrid.Location = new System.Drawing.Point(3, 35);
            this.extDataGrid.MultiSelect = false;
            this.extDataGrid.Name = "extDataGrid";
            this.extDataGrid.RowHeadersVisible = false;
            this.extDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.extDataGrid.RowTemplate.Height = 23;
            this.extDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.extDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extDataGrid.Size = new System.Drawing.Size(156, 152);
            this.extDataGrid.TabIndex = 0;
            // 
            // btnPanel2
            // 
            this.btnPanel2.Controls.Add(this.DelBtn);
            this.btnPanel2.Controls.Add(this.saveBtn);
            this.btnPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel2.Location = new System.Drawing.Point(3, 187);
            this.btnPanel2.Name = "btnPanel2";
            this.btnPanel2.Size = new System.Drawing.Size(156, 26);
            this.btnPanel2.TabIndex = 1;
            // 
            // DelBtn
            // 
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DelBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DelBtn.Location = new System.Drawing.Point(108, 0);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(48, 26);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "삭제";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveBtn.Location = new System.Drawing.Point(0, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 26);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deselectBtn
            // 
            this.deselectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deselectBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deselectBtn.Font = new System.Drawing.Font("NanumBarunGothicOTF Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deselectBtn.Location = new System.Drawing.Point(60, 0);
            this.deselectBtn.Name = "deselectBtn";
            this.deselectBtn.Size = new System.Drawing.Size(60, 27);
            this.deselectBtn.TabIndex = 4;
            this.deselectBtn.Text = "전체해제";
            this.deselectBtn.UseVisualStyleBackColor = true;
            this.deselectBtn.Click += new System.EventHandler(this.deselectBtn_Click);
            // 
            // allDirOrThisDir
            // 
            this.allDirOrThisDir.AutoSize = true;
            this.allDirOrThisDir.Checked = true;
            this.allDirOrThisDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allDirOrThisDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.allDirOrThisDir.Location = new System.Drawing.Point(3, 3);
            this.allDirOrThisDir.Name = "allDirOrThisDir";
            this.allDirOrThisDir.Size = new System.Drawing.Size(156, 16);
            this.allDirOrThisDir.TabIndex = 2;
            this.allDirOrThisDir.Text = "하위 디렉토리까지 정리";
            this.allDirOrThisDir.UseVisualStyleBackColor = true;
            this.allDirOrThisDir.CheckedChanged += new System.EventHandler(this.allDirOrThisDir_CheckedChanged);
            // 
            // delEmptyFolder
            // 
            this.delEmptyFolder.AutoSize = true;
            this.delEmptyFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.delEmptyFolder.Location = new System.Drawing.Point(3, 19);
            this.delEmptyFolder.Name = "delEmptyFolder";
            this.delEmptyFolder.Size = new System.Drawing.Size(156, 16);
            this.delEmptyFolder.TabIndex = 3;
            this.delEmptyFolder.Text = "경로안 빈 폴더 삭제";
            this.delEmptyFolder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(534, 266);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.currentPathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Sorter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.btnPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extDataGrid)).EndInit();
            this.btnPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentPathTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.CheckedListBox extListBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button folderSelBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        public System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel btnPanel2;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView extDataGrid;
        private System.Windows.Forms.Panel btnPanel1;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button deselectBtn;
        private System.Windows.Forms.CheckBox allDirOrThisDir;
        private System.Windows.Forms.CheckBox delEmptyFolder;
    }
}

