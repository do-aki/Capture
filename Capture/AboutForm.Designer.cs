namespace Capture
{
    partial class AboutForm
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
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_Changelog = new System.Windows.Forms.TextBox();
            this.label_PublishVersion = new System.Windows.Forms.Label();
            this.label_ProductVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Close.Location = new System.Drawing.Point(211, 302);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(89, 33);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close(&C)";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Changelog
            // 
            this.textBox_Changelog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Changelog.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Changelog.Location = new System.Drawing.Point(18, 113);
            this.textBox_Changelog.Multiline = true;
            this.textBox_Changelog.Name = "textBox_Changelog";
            this.textBox_Changelog.ReadOnly = true;
            this.textBox_Changelog.Size = new System.Drawing.Size(476, 167);
            this.textBox_Changelog.TabIndex = 8;
            // 
            // label_PublishVersion
            // 
            this.label_PublishVersion.AutoSize = true;
            this.label_PublishVersion.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PublishVersion.Location = new System.Drawing.Point(70, 69);
            this.label_PublishVersion.Name = "label_PublishVersion";
            this.label_PublishVersion.Size = new System.Drawing.Size(162, 19);
            this.label_PublishVersion.TabIndex = 7;
            this.label_PublishVersion.Text = "pubilsh version xxx";
            // 
            // label_ProductVersion
            // 
            this.label_ProductVersion.AutoSize = true;
            this.label_ProductVersion.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ProductVersion.Location = new System.Drawing.Point(256, 21);
            this.label_ProductVersion.Name = "label_ProductVersion";
            this.label_ProductVersion.Size = new System.Drawing.Size(101, 19);
            this.label_ProductVersion.TabIndex = 6;
            this.label_ProductVersion.Text = "version xxx";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelProductName.Location = new System.Drawing.Point(12, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(238, 33);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "ApplicationName";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 347);
            this.Controls.Add(this.textBox_Changelog);
            this.Controls.Add(this.label_PublishVersion);
            this.Controls.Add(this.label_ProductVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.button_Close);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_Changelog;
        private System.Windows.Forms.Label label_PublishVersion;
        private System.Windows.Forms.Label label_ProductVersion;
        private System.Windows.Forms.Label labelProductName;
    }
}