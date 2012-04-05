namespace Capture
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_UploadUri = new System.Windows.Forms.TextBox();
            this.button_About = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "upload uri";
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Save.Location = new System.Drawing.Point(283, 113);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 27);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "OK(&O)";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // textBox_UploadUri
            // 
            this.textBox_UploadUri.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Capture.Properties.Settings.Default, "UploadUri", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_UploadUri.Location = new System.Drawing.Point(89, 57);
            this.textBox_UploadUri.Name = "textBox_UploadUri";
            this.textBox_UploadUri.Size = new System.Drawing.Size(236, 19);
            this.textBox_UploadUri.TabIndex = 0;
            this.textBox_UploadUri.Text = global::Capture.Properties.Settings.Default.UploadUri;
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Location = new System.Drawing.Point(283, 12);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(94, 27);
            this.button_About.TabIndex = 3;
            this.button_About.Text = "About(&A)";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.Location = new System.Drawing.Point(149, 113);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(94, 27);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Close(&C)";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(405, 164);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UploadUri);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_UploadUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button button_Close;

    }
}