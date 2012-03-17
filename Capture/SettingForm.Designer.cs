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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "upload uri";
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(230, 113);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 27);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save(&S)";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_UploadUri
            // 
            this.textBox_UploadUri.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Capture.Properties.Settings.Default, "UploadUri", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_UploadUri.Location = new System.Drawing.Point(88, 38);
            this.textBox_UploadUri.Name = "textBox_UploadUri";
            this.textBox_UploadUri.Size = new System.Drawing.Size(236, 19);
            this.textBox_UploadUri.TabIndex = 0;
            this.textBox_UploadUri.Text = global::Capture.Properties.Settings.Default.UploadUri;
            this.textBox_UploadUri.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_UploadUri_KeyUp);
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Location = new System.Drawing.Point(88, 113);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(94, 27);
            this.button_About.TabIndex = 3;
            this.button_About.Text = "About(&A)";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 164);
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

    }
}