namespace FileSorter
{
    partial class InfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blogBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Sorter V.0.4\r\n\r\n파일을 정리하는 프로그램입니다.\r\n버그 발견시 개발자 블로그에 글 남겨주세요.\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "copyrightⓒ 2020 All rights reserved by Switch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blogBtn
            // 
            this.blogBtn.Location = new System.Drawing.Point(173, 258);
            this.blogBtn.Name = "blogBtn";
            this.blogBtn.Size = new System.Drawing.Size(101, 27);
            this.blogBtn.TabIndex = 1;
            this.blogBtn.Text = "제작자 블로그";
            this.blogBtn.UseVisualStyleBackColor = true;
            this.blogBtn.Click += new System.EventHandler(this.blogBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 182);
            this.label3.TabIndex = 2;
            this.label3.Text = "v.0.1\r\n초기버전\r\n\r\nv.0.2\r\n버그 픽스, 하위 디렉토리 선택,\r\n전체선택, 전체해제,\r\n빈폴더 제거 기능 추가\r\n\r\nv.0.3\r\n버그픽" +
    "스\r\n\r\nv.0.4\r\n중복실행방지 기능 추가";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.blogBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("NanumBarunGothicOTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button blogBtn;
        private System.Windows.Forms.Label label3;
    }
}