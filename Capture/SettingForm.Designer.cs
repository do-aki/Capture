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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_EnableCopy = new System.Windows.Forms.CheckBox();
            this.checkBox_EnableUpload = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_UploadUri = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Save.Location = new System.Drawing.Point(315, 301);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 27);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "OK(&O)";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Location = new System.Drawing.Point(315, 12);
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
            this.button_Close.Location = new System.Drawing.Point(14, 301);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(94, 27);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "終了(&Q)";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload URL";
            // 
            // checkBox_EnableCopy
            // 
            this.checkBox_EnableCopy.AutoSize = true;
            this.checkBox_EnableCopy.Checked = global::Capture.Properties.Settings.Default.EnableCopy;
            this.checkBox_EnableCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EnableCopy.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Capture.Properties.Settings.Default, "EnableCopy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_EnableCopy.Location = new System.Drawing.Point(20, 21);
            this.checkBox_EnableCopy.Name = "checkBox_EnableCopy";
            this.checkBox_EnableCopy.Size = new System.Drawing.Size(76, 16);
            this.checkBox_EnableCopy.TabIndex = 5;
            this.checkBox_EnableCopy.Text = "有効にする";
            this.checkBox_EnableCopy.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnableUpload
            // 
            this.checkBox_EnableUpload.AutoSize = true;
            this.checkBox_EnableUpload.Checked = global::Capture.Properties.Settings.Default.EnableUpload;
            this.checkBox_EnableUpload.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Capture.Properties.Settings.Default, "EnableUpload", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_EnableUpload.Location = new System.Drawing.Point(20, 21);
            this.checkBox_EnableUpload.Name = "checkBox_EnableUpload";
            this.checkBox_EnableUpload.Size = new System.Drawing.Size(76, 16);
            this.checkBox_EnableUpload.TabIndex = 6;
            this.checkBox_EnableUpload.Tag = "";
            this.checkBox_EnableUpload.Text = "有効にする";
            this.checkBox_EnableUpload.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_EnableCopy);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "クリップボードにコピー";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_EnableUpload);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_UploadUri);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gyazo形式でのアップロード";
            // 
            // textBox_UploadUri
            // 
            this.textBox_UploadUri.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Capture.Properties.Settings.Default, "UploadUri", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_UploadUri.Location = new System.Drawing.Point(97, 50);
            this.textBox_UploadUri.Name = "textBox_UploadUri";
            this.textBox_UploadUri.Size = new System.Drawing.Size(292, 19);
            this.textBox_UploadUri.TabIndex = 0;
            this.textBox_UploadUri.Text = global::Capture.Properties.Settings.Default.UploadUri;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(421, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Save);
            this.Name = "SettingForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UploadUri;
        private System.Windows.Forms.CheckBox checkBox_EnableCopy;
        private System.Windows.Forms.CheckBox checkBox_EnableUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}