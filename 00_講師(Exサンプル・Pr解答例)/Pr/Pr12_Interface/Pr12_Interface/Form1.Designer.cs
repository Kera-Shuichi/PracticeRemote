namespace Pr12_Interface
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btnPlain = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlain
            // 
            this.btnPlain.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlain.Location = new System.Drawing.Point(31, 143);
            this.btnPlain.Name = "btnPlain";
            this.btnPlain.Size = new System.Drawing.Size(223, 74);
            this.btnPlain.TabIndex = 9;
            this.btnPlain.Text = "Plain";
            this.btnPlain.UseVisualStyleBackColor = true;
            this.btnPlain.Click += new System.EventHandler(this.btnPlain_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConsole.Location = new System.Drawing.Point(31, 44);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(223, 74);
            this.btnConsole.TabIndex = 8;
            this.btnConsole.Text = "Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPlain);
            this.Controls.Add(this.btnConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlain;
        private System.Windows.Forms.Button btnConsole;
    }
}

