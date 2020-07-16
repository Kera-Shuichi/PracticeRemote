namespace Pr14_Delegate
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
            this.label4 = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.dispTypeCombo = new System.Windows.Forms.ComboBox();
            this.averageButton = new System.Windows.Forms.Button();
            this.registButton = new System.Windows.Forms.Button();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "出力食品分類";
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(37, 323);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(64, 25);
            this.listButton.TabIndex = 50;
            this.listButton.Text = "一覧";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(35, 46);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(148, 19);
            this.nameText.TabIndex = 46;
            // 
            // dispTypeCombo
            // 
            this.dispTypeCombo.FormattingEnabled = true;
            this.dispTypeCombo.Location = new System.Drawing.Point(37, 279);
            this.dispTypeCombo.Name = "dispTypeCombo";
            this.dispTypeCombo.Size = new System.Drawing.Size(148, 20);
            this.dispTypeCombo.TabIndex = 56;
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(121, 323);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(64, 25);
            this.averageButton.TabIndex = 51;
            this.averageButton.Text = "平均";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(35, 193);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(64, 25);
            this.registButton.TabIndex = 45;
            this.registButton.Text = "登録";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(37, 97);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(148, 19);
            this.priceText.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "食品名";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(37, 149);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(148, 20);
            this.typeCombo.TabIndex = 54;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 193);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 25);
            this.clearButton.TabIndex = 52;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 49;
            this.label2.Text = "値段";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "食品分類";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 375);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.dispTypeCombo);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.ComboBox dispTypeCombo;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

