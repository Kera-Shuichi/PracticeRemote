namespace Ex16_Exception
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
            this.tbxValue1 = new System.Windows.Forms.TextBox();
            this.tbxValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxValue1
            // 
            this.tbxValue1.Location = new System.Drawing.Point(163, 92);
            this.tbxValue1.Name = "tbxValue1";
            this.tbxValue1.Size = new System.Drawing.Size(100, 19);
            this.tbxValue1.TabIndex = 0;
            // 
            // tbxValue2
            // 
            this.tbxValue2.Location = new System.Drawing.Point(292, 92);
            this.tbxValue2.Name = "tbxValue2";
            this.tbxValue2.Size = new System.Drawing.Size(100, 19);
            this.tbxValue2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "÷";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(398, 90);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxValue2);
            this.Controls.Add(this.tbxValue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxValue1;
        private System.Windows.Forms.TextBox tbxValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
    }
}

