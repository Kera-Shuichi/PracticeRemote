namespace Ex04_ControlStatements
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
            this.tbxIf = new System.Windows.Forms.TextBox();
            this.tbxSwitch = new System.Windows.Forms.TextBox();
            this.tbxWhile = new System.Windows.Forms.TextBox();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxIf
            // 
            this.tbxIf.Location = new System.Drawing.Point(79, 73);
            this.tbxIf.Name = "tbxIf";
            this.tbxIf.Size = new System.Drawing.Size(100, 19);
            this.tbxIf.TabIndex = 0;
            // 
            // tbxSwitch
            // 
            this.tbxSwitch.Location = new System.Drawing.Point(79, 134);
            this.tbxSwitch.Name = "tbxSwitch";
            this.tbxSwitch.Size = new System.Drawing.Size(100, 19);
            this.tbxSwitch.TabIndex = 1;
            // 
            // tbxWhile
            // 
            this.tbxWhile.Location = new System.Drawing.Point(79, 199);
            this.tbxWhile.Name = "tbxWhile";
            this.tbxWhile.Size = new System.Drawing.Size(100, 19);
            this.tbxWhile.TabIndex = 2;
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(257, 68);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(75, 23);
            this.btnIf.TabIndex = 3;
            this.btnIf.Text = "if文";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(257, 130);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "switch文";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(257, 199);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "while文";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(257, 270);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(75, 23);
            this.btnForeach.TabIndex = 6;
            this.btnForeach.Text = "foreach文";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.tbxWhile);
            this.Controls.Add(this.tbxSwitch);
            this.Controls.Add(this.tbxIf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIf;
        private System.Windows.Forms.TextBox tbxSwitch;
        private System.Windows.Forms.TextBox tbxWhile;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnForeach;
    }
}

