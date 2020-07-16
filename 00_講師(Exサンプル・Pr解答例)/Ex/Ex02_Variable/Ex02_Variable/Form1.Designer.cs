namespace Ex02_Variable
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.hensuButton = new System.Windows.Forms.Button();
            this.teisuButton = new System.Windows.Forms.Button();
            this.arrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hensuButton
            // 
            this.hensuButton.Location = new System.Drawing.Point(30, 39);
            this.hensuButton.Name = "hensuButton";
            this.hensuButton.Size = new System.Drawing.Size(219, 81);
            this.hensuButton.TabIndex = 0;
            this.hensuButton.Text = "変数表示";
            this.hensuButton.UseVisualStyleBackColor = true;
            this.hensuButton.Click += new System.EventHandler(this.hensuButton_Click);
            // 
            // teisuButton
            // 
            this.teisuButton.Location = new System.Drawing.Point(30, 144);
            this.teisuButton.Name = "teisuButton";
            this.teisuButton.Size = new System.Drawing.Size(219, 81);
            this.teisuButton.TabIndex = 1;
            this.teisuButton.Text = "定数表示";
            this.teisuButton.UseVisualStyleBackColor = true;
            this.teisuButton.Click += new System.EventHandler(this.teisuButton_Click);
            // 
            // arrayButton
            // 
            this.arrayButton.Location = new System.Drawing.Point(30, 255);
            this.arrayButton.Name = "arrayButton";
            this.arrayButton.Size = new System.Drawing.Size(219, 81);
            this.arrayButton.TabIndex = 2;
            this.arrayButton.Text = "配列表示";
            this.arrayButton.UseVisualStyleBackColor = true;
            this.arrayButton.Click += new System.EventHandler(this.arrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 378);
            this.Controls.Add(this.arrayButton);
            this.Controls.Add(this.teisuButton);
            this.Controls.Add(this.hensuButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hensuButton;
        private System.Windows.Forms.Button teisuButton;
        private System.Windows.Forms.Button arrayButton;
    }
}

