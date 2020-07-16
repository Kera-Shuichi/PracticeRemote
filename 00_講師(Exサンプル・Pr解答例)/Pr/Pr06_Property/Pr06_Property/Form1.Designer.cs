namespace Pr06_Property
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblKumi = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tbxKumi = new System.Windows.Forms.TextBox();
            this.tbxGrade = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(193, 52);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "登録";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(148, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(120, 19);
            this.tbxName.TabIndex = 37;
            // 
            // lblKumi
            // 
            this.lblKumi.AutoSize = true;
            this.lblKumi.Location = new System.Drawing.Point(125, 34);
            this.lblKumi.Name = "lblKumi";
            this.lblKumi.Size = new System.Drawing.Size(17, 12);
            this.lblKumi.TabIndex = 36;
            this.lblKumi.Text = "組";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(64, 33);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(17, 12);
            this.lblGrade.TabIndex = 35;
            this.lblGrade.Text = "年";
            // 
            // tbxKumi
            // 
            this.tbxKumi.Location = new System.Drawing.Point(87, 27);
            this.tbxKumi.Name = "tbxKumi";
            this.tbxKumi.Size = new System.Drawing.Size(32, 19);
            this.tbxKumi.TabIndex = 34;
            // 
            // tbxGrade
            // 
            this.tbxGrade.Location = new System.Drawing.Point(25, 27);
            this.tbxGrade.Name = "tbxGrade";
            this.tbxGrade.Size = new System.Drawing.Size(32, 19);
            this.tbxGrade.TabIndex = 33;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(194, 220);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 41;
            this.btnOutput.Text = "表示";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 12;
            this.lbxOutput.Location = new System.Drawing.Point(26, 90);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(243, 124);
            this.lbxOutput.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 333);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblKumi);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.tbxKumi);
            this.Controls.Add(this.tbxGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblKumi;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox tbxKumi;
        private System.Windows.Forms.TextBox tbxGrade;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxOutput;
    }
}

