
namespace winform_open_cv_sharp_video_extracting_frame {
  partial class frmMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textFilepath = new System.Windows.Forms.TextBox();
      this.btnFileSelect = new System.Windows.Forms.Button();
      this.textFrameCount = new System.Windows.Forms.TextBox();
      this.btnExtracingImage = new System.Windows.Forms.Button();
      this.textLog = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnLogClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "视频文件";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "帧频";
      // 
      // textFilepath
      // 
      this.textFilepath.Location = new System.Drawing.Point(62, 31);
      this.textFilepath.Name = "textFilepath";
      this.textFilepath.Size = new System.Drawing.Size(779, 23);
      this.textFilepath.TabIndex = 2;
      // 
      // btnFileSelect
      // 
      this.btnFileSelect.Location = new System.Drawing.Point(847, 31);
      this.btnFileSelect.Name = "btnFileSelect";
      this.btnFileSelect.Size = new System.Drawing.Size(88, 23);
      this.btnFileSelect.TabIndex = 3;
      this.btnFileSelect.Text = "选择视频文件";
      this.btnFileSelect.UseVisualStyleBackColor = true;
      this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
      // 
      // textFrameCount
      // 
      this.textFrameCount.Location = new System.Drawing.Point(62, 70);
      this.textFrameCount.Name = "textFrameCount";
      this.textFrameCount.Size = new System.Drawing.Size(31, 23);
      this.textFrameCount.TabIndex = 4;
      this.textFrameCount.Text = "12";
      // 
      // btnExtracingImage
      // 
      this.btnExtracingImage.Location = new System.Drawing.Point(99, 71);
      this.btnExtracingImage.Name = "btnExtracingImage";
      this.btnExtracingImage.Size = new System.Drawing.Size(75, 23);
      this.btnExtracingImage.TabIndex = 5;
      this.btnExtracingImage.Text = "提取图片";
      this.btnExtracingImage.UseVisualStyleBackColor = true;
      this.btnExtracingImage.Click += new System.EventHandler(this.btnExtracingImage_Click);
      // 
      // textLog
      // 
      this.textLog.Location = new System.Drawing.Point(0, 129);
      this.textLog.Multiline = true;
      this.textLog.Name = "textLog";
      this.textLog.Size = new System.Drawing.Size(922, 363);
      this.textLog.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(0, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "日志信息";
      // 
      // btnLogClear
      // 
      this.btnLogClear.Location = new System.Drawing.Point(99, 106);
      this.btnLogClear.Name = "btnLogClear";
      this.btnLogClear.Size = new System.Drawing.Size(75, 23);
      this.btnLogClear.TabIndex = 8;
      this.btnLogClear.Text = "清除日志";
      this.btnLogClear.UseVisualStyleBackColor = true;
      this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(934, 504);
      this.Controls.Add(this.btnLogClear);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textLog);
      this.Controls.Add(this.btnExtracingImage);
      this.Controls.Add(this.textFrameCount);
      this.Controls.Add(this.btnFileSelect);
      this.Controls.Add(this.textFilepath);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmMain";
      this.Text = "winform-open-cv-sharp-video-extracting-frame";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textFilepath;
    private System.Windows.Forms.Button btnFileSelect;
    private System.Windows.Forms.TextBox textFrameCount;
    private System.Windows.Forms.Button btnExtracingImage;
    private System.Windows.Forms.TextBox textLog;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnLogClear;
  }
}

