namespace Pr02_Variable
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
            this.arrayButton = new System.Windows.Forms.Button();
            this.teisuButton = new System.Windows.Forms.Button();
            this.hensuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayButton
            // 
            this.arrayButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrayButton.Location = new System.Drawing.Point(377, 12);
            this.arrayButton.Name = "arrayButton";
            this.arrayButton.Size = new System.Drawing.Size(165, 47);
            this.arrayButton.TabIndex = 11;
            this.arrayButton.Text = "配列の出力";
            this.arrayButton.UseVisualStyleBackColor = true;
            this.arrayButton.Click += new System.EventHandler(this.arrayButton_Click);
            // 
            // teisuButton
            // 
            this.teisuButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.teisuButton.Location = new System.Drawing.Point(195, 12);
            this.teisuButton.Name = "teisuButton";
            this.teisuButton.Size = new System.Drawing.Size(165, 47);
            this.teisuButton.TabIndex = 10;
            this.teisuButton.Text = "定数の出力";
            this.teisuButton.UseVisualStyleBackColor = true;
            this.teisuButton.Click += new System.EventHandler(this.teisuButton_Click);
            // 
            // hensuButton
            // 
            this.hensuButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hensuButton.Location = new System.Drawing.Point(12, 12);
            this.hensuButton.Name = "hensuButton";
            this.hensuButton.Size = new System.Drawing.Size(165, 47);
            this.hensuButton.TabIndex = 9;
            this.hensuButton.Text = "変数の出力";
            this.hensuButton.UseVisualStyleBackColor = true;
            this.hensuButton.Click += new System.EventHandler(this.hensuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 70);
            this.Controls.Add(this.arrayButton);
            this.Controls.Add(this.teisuButton);
            this.Controls.Add(this.hensuButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arrayButton;
        private System.Windows.Forms.Button teisuButton;
        private System.Windows.Forms.Button hensuButton;
    }
}

