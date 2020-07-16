namespace Pr15_Dictionary
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
            this.lblScore = new System.Windows.Forms.Label();
            this.btnDisp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRequest = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxEnglish = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxScience = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxJapanese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoEllipsis = true;
            this.lblScore.Location = new System.Drawing.Point(36, 364);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(63, 101);
            this.lblScore.TabIndex = 83;
            this.lblScore.Text = "得点";
            // 
            // btnDisp
            // 
            this.btnDisp.Location = new System.Drawing.Point(168, 334);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(75, 23);
            this.btnDisp.TabIndex = 82;
            this.btnDisp.Text = "表示";
            this.btnDisp.UseVisualStyleBackColor = true;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 81;
            this.label9.Text = "◆表示";
            // 
            // tbxRequest
            // 
            this.tbxRequest.Location = new System.Drawing.Point(38, 336);
            this.tbxRequest.Name = "tbxRequest";
            this.tbxRequest.Size = new System.Drawing.Size(119, 19);
            this.tbxRequest.TabIndex = 80;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Location = new System.Drawing.Point(36, 289);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(207, 17);
            this.lblName.TabIndex = 79;
            this.lblName.Text = "登録者名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 78;
            this.label8.Text = "◆登録者一覧";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "登録";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxEnglish
            // 
            this.tbxEnglish.Location = new System.Drawing.Point(71, 164);
            this.tbxEnglish.Name = "tbxEnglish";
            this.tbxEnglish.Size = new System.Drawing.Size(172, 19);
            this.tbxEnglish.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 74;
            this.label7.Text = "英語";
            // 
            // tbxSocial
            // 
            this.tbxSocial.Location = new System.Drawing.Point(71, 139);
            this.tbxSocial.Name = "tbxSocial";
            this.tbxSocial.Size = new System.Drawing.Size(172, 19);
            this.tbxSocial.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "社会";
            // 
            // tbxScience
            // 
            this.tbxScience.Location = new System.Drawing.Point(71, 114);
            this.tbxScience.Name = "tbxScience";
            this.tbxScience.Size = new System.Drawing.Size(172, 19);
            this.tbxScience.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "理科";
            // 
            // tbxMath
            // 
            this.tbxMath.Location = new System.Drawing.Point(71, 89);
            this.tbxMath.Name = "tbxMath";
            this.tbxMath.Size = new System.Drawing.Size(172, 19);
            this.tbxMath.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "数学";
            // 
            // tbxJapanese
            // 
            this.tbxJapanese.Location = new System.Drawing.Point(71, 64);
            this.tbxJapanese.Name = "tbxJapanese";
            this.tbxJapanese.Size = new System.Drawing.Size(172, 19);
            this.tbxJapanese.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 66;
            this.label3.Text = "国語";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(71, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(172, 19);
            this.tbxName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "名前";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "◆入力";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 492);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnDisp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxRequest);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxEnglish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSocial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxScience);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxJapanese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnDisp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRequest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxEnglish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxScience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxJapanese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

