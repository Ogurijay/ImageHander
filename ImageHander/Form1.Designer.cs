namespace ImageHander
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.lbFileUrl = new System.Windows.Forms.Label();
            this.tbModelUrl = new System.Windows.Forms.TextBox();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMask1Url = new System.Windows.Forms.TextBox();
            this.btnOpenFile3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMask2Url = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.Label();
            this.btnWarm = new System.Windows.Forms.Button();
            this.btnComic = new System.Windows.Forms.Button();
            this.btnNostalgic = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemoveTag2 = new System.Windows.Forms.Button();
            this.btnRemoveTag1 = new System.Windows.Forms.Button();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Location = new System.Drawing.Point(841, 12);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(56, 30);
            this.btnOpenFile1.TabIndex = 0;
            this.btnOpenFile1.Text = "上传";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbFileUrl
            // 
            this.lbFileUrl.AutoSize = true;
            this.lbFileUrl.Location = new System.Drawing.Point(17, 21);
            this.lbFileUrl.Name = "lbFileUrl";
            this.lbFileUrl.Size = new System.Drawing.Size(89, 12);
            this.lbFileUrl.TabIndex = 1;
            this.lbFileUrl.Text = "选择图片路径：";
            // 
            // tbModelUrl
            // 
            this.tbModelUrl.Font = new System.Drawing.Font("宋体", 12F);
            this.tbModelUrl.Location = new System.Drawing.Point(106, 12);
            this.tbModelUrl.Multiline = true;
            this.tbModelUrl.Name = "tbModelUrl";
            this.tbModelUrl.ReadOnly = true;
            this.tbModelUrl.Size = new System.Drawing.Size(729, 30);
            this.tbModelUrl.TabIndex = 2;
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(841, 48);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(56, 30);
            this.btnOpenFile2.TabIndex = 0;
            this.btnOpenFile2.Text = "上传";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择水印1路径：";
            // 
            // tbMask1Url
            // 
            this.tbMask1Url.Font = new System.Drawing.Font("宋体", 12F);
            this.tbMask1Url.Location = new System.Drawing.Point(106, 48);
            this.tbMask1Url.Multiline = true;
            this.tbMask1Url.Name = "tbMask1Url";
            this.tbMask1Url.ReadOnly = true;
            this.tbMask1Url.Size = new System.Drawing.Size(729, 30);
            this.tbMask1Url.TabIndex = 2;
            // 
            // btnOpenFile3
            // 
            this.btnOpenFile3.Location = new System.Drawing.Point(841, 84);
            this.btnOpenFile3.Name = "btnOpenFile3";
            this.btnOpenFile3.Size = new System.Drawing.Size(56, 30);
            this.btnOpenFile3.TabIndex = 0;
            this.btnOpenFile3.Text = "上传";
            this.btnOpenFile3.UseVisualStyleBackColor = true;
            this.btnOpenFile3.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择水印2路径：";
            // 
            // tbMask2Url
            // 
            this.tbMask2Url.Font = new System.Drawing.Font("宋体", 12F);
            this.tbMask2Url.Location = new System.Drawing.Point(106, 84);
            this.tbMask2Url.Multiline = true;
            this.tbMask2Url.Name = "tbMask2Url";
            this.tbMask2Url.ReadOnly = true;
            this.tbMask2Url.Size = new System.Drawing.Size(729, 30);
            this.tbMask2Url.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(884, 544);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "滤镜操作：";
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Location = new System.Drawing.Point(17, 679);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(65, 12);
            this.lbAction.TabIndex = 12;
            this.lbAction.Text = "图片操作：";
            // 
            // btnWarm
            // 
            this.btnWarm.Location = new System.Drawing.Point(246, 710);
            this.btnWarm.Name = "btnWarm";
            this.btnWarm.Size = new System.Drawing.Size(75, 30);
            this.btnWarm.TabIndex = 4;
            this.btnWarm.Text = "暖化";
            this.btnWarm.UseVisualStyleBackColor = true;
            this.btnWarm.Click += new System.EventHandler(this.btnWarm_Click);
            // 
            // btnComic
            // 
            this.btnComic.Location = new System.Drawing.Point(165, 710);
            this.btnComic.Name = "btnComic";
            this.btnComic.Size = new System.Drawing.Size(75, 30);
            this.btnComic.TabIndex = 5;
            this.btnComic.Text = "连环画";
            this.btnComic.UseVisualStyleBackColor = true;
            this.btnComic.Click += new System.EventHandler(this.btnComic_Click);
            // 
            // btnNostalgic
            // 
            this.btnNostalgic.Location = new System.Drawing.Point(82, 710);
            this.btnNostalgic.Name = "btnNostalgic";
            this.btnNostalgic.Size = new System.Drawing.Size(77, 30);
            this.btnNostalgic.TabIndex = 6;
            this.btnNostalgic.Text = "怀旧";
            this.btnNostalgic.UseVisualStyleBackColor = true;
            this.btnNostalgic.Click += new System.EventHandler(this.btnNostalgic_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(82, 670);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "还原";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemoveTag2
            // 
            this.btnRemoveTag2.Location = new System.Drawing.Point(403, 670);
            this.btnRemoveTag2.Name = "btnRemoveTag2";
            this.btnRemoveTag2.Size = new System.Drawing.Size(90, 30);
            this.btnRemoveTag2.TabIndex = 8;
            this.btnRemoveTag2.Text = "去水印(mix)";
            this.btnRemoveTag2.UseVisualStyleBackColor = true;
            this.btnRemoveTag2.Click += new System.EventHandler(this.btnRemoveTag2_Click);
            // 
            // btnRemoveTag1
            // 
            this.btnRemoveTag1.Location = new System.Drawing.Point(278, 670);
            this.btnRemoveTag1.Name = "btnRemoveTag1";
            this.btnRemoveTag1.Size = new System.Drawing.Size(119, 30);
            this.btnRemoveTag1.TabIndex = 9;
            this.btnRemoveTag1.Text = "去水印(反色中和)";
            this.btnRemoveTag1.UseVisualStyleBackColor = true;
            this.btnRemoveTag1.Click += new System.EventHandler(this.btnRemoveTag1_Click);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Location = new System.Drawing.Point(165, 670);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(107, 30);
            this.btnRemoveTag.TabIndex = 10;
            this.btnRemoveTag.Text = "去水印(inpaint)";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "图片打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 544);
            this.panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(328, 710);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 30);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.Location = new System.Drawing.Point(372, 710);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 30);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 755);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.btnWarm);
            this.Controls.Add(this.btnComic);
            this.Controls.Add(this.btnNostalgic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemoveTag2);
            this.Controls.Add(this.btnRemoveTag1);
            this.Controls.Add(this.btnRemoveTag);
            this.Controls.Add(this.tbMask2Url);
            this.Controls.Add(this.tbMask1Url);
            this.Controls.Add(this.tbModelUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFileUrl);
            this.Controls.Add(this.btnOpenFile3);
            this.Controls.Add(this.btnOpenFile2);
            this.Controls.Add(this.btnOpenFile1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Label lbFileUrl;
        private System.Windows.Forms.TextBox tbModelUrl;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMask1Url;
        private System.Windows.Forms.Button btnOpenFile3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMask2Url;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btnWarm;
        private System.Windows.Forms.Button btnComic;
        private System.Windows.Forms.Button btnNostalgic;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveTag2;
        private System.Windows.Forms.Button btnRemoveTag1;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

