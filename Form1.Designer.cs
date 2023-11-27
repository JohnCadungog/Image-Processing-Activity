namespace ImageProcessingActivity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageHistogram = new System.Windows.Forms.PictureBox();
            this.orignalImage = new System.Windows.Forms.PictureBox();
            this.processedImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.showHistogram = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtractedImage = new System.Windows.Forms.PictureBox();
            this.backgroundImageBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadBackgroundBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.loadBackgroundImageBox = new System.Windows.Forms.PictureBox();
            this.camSubtract = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cameraButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orignalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBackgroundImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageHistogram
            // 
            this.imageHistogram.Location = new System.Drawing.Point(82, 53);
            this.imageHistogram.Name = "imageHistogram";
            this.imageHistogram.Size = new System.Drawing.Size(249, 183);
            this.imageHistogram.TabIndex = 0;
            this.imageHistogram.TabStop = false;
            // 
            // orignalImage
            // 
            this.orignalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orignalImage.Location = new System.Drawing.Point(51, 343);
            this.orignalImage.Name = "orignalImage";
            this.orignalImage.Size = new System.Drawing.Size(311, 250);
            this.orignalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orignalImage.TabIndex = 1;
            this.orignalImage.TabStop = false;
            // 
            // processedImage
            // 
            this.processedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedImage.Location = new System.Drawing.Point(407, 27);
            this.processedImage.Name = "processedImage";
            this.processedImage.Size = new System.Drawing.Size(311, 250);
            this.processedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.processedImage.TabIndex = 2;
            this.processedImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1403, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.sepiaToolStripMenuItem});
            this.copyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.copyToolStripMenuItem.Text = "Menu";
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.greyScaleToolStripMenuItem.Text = "Grey Scale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(249, 36);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(264, 599);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(98, 34);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(620, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 28);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // showHistogram
            // 
            this.showHistogram.AutoSize = true;
            this.showHistogram.Location = new System.Drawing.Point(228, 242);
            this.showHistogram.Name = "showHistogram";
            this.showHistogram.Size = new System.Drawing.Size(103, 17);
            this.showHistogram.TabIndex = 6;
            this.showHistogram.Text = "Show Histogram";
            this.showHistogram.UseVisualStyleBackColor = true;
            this.showHistogram.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Histogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Processed Image Filters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loaded Image";
            // 
            // subtractedImage
            // 
            this.subtractedImage.Location = new System.Drawing.Point(750, 27);
            this.subtractedImage.Name = "subtractedImage";
            this.subtractedImage.Size = new System.Drawing.Size(608, 566);
            this.subtractedImage.TabIndex = 10;
            this.subtractedImage.TabStop = false;
            // 
            // backgroundImageBox
            // 
            this.backgroundImageBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundImageBox.Name = "backgroundImageBox";
            this.backgroundImageBox.Size = new System.Drawing.Size(100, 50);
            this.backgroundImageBox.TabIndex = 0;
            this.backgroundImageBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Load BackGround Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subtracted Image";
            // 
            // loadBackgroundBtn
            // 
            this.loadBackgroundBtn.Location = new System.Drawing.Point(601, 599);
            this.loadBackgroundBtn.Name = "loadBackgroundBtn";
            this.loadBackgroundBtn.Size = new System.Drawing.Size(117, 34);
            this.loadBackgroundBtn.TabIndex = 14;
            this.loadBackgroundBtn.Text = "Load Background";
            this.loadBackgroundBtn.UseVisualStyleBackColor = true;
            this.loadBackgroundBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1275, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Subtract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // loadBackgroundImageBox
            // 
            this.loadBackgroundImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadBackgroundImageBox.Location = new System.Drawing.Point(409, 343);
            this.loadBackgroundImageBox.Name = "loadBackgroundImageBox";
            this.loadBackgroundImageBox.Size = new System.Drawing.Size(311, 250);
            this.loadBackgroundImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadBackgroundImageBox.TabIndex = 16;
            this.loadBackgroundImageBox.TabStop = false;
            // 
            // camSubtract
            // 
            this.camSubtract.Location = new System.Drawing.Point(1194, 599);
            this.camSubtract.Name = "camSubtract";
            this.camSubtract.Size = new System.Drawing.Size(75, 35);
            this.camSubtract.TabIndex = 17;
            this.camSubtract.Text = "Camera Subtract";
            this.camSubtract.UseVisualStyleBackColor = true;
            this.camSubtract.Click += new System.EventHandler(this.camSubtract_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cameraButton
            // 
            this.cameraButton.Location = new System.Drawing.Point(197, 598);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(61, 35);
            this.cameraButton.TabIndex = 18;
            this.cameraButton.Text = "camera";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(1175, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 63);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Subtracted Camera wont work unless your loaded image \r\nresolution matches with th" +
    "e resolution of the background image";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(992, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Image Resolution did not match";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 801);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cameraButton);
            this.Controls.Add(this.camSubtract);
            this.Controls.Add(this.loadBackgroundImageBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadBackgroundBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subtractedImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showHistogram);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.processedImage);
            this.Controls.Add(this.orignalImage);
            this.Controls.Add(this.imageHistogram);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orignalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBackgroundImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageHistogram;
        private System.Windows.Forms.PictureBox orignalImage;
        private System.Windows.Forms.PictureBox processedImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox showHistogram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox subtractedImage;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadBackgroundBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.PictureBox backgroundImageBox;
        private System.Windows.Forms.PictureBox loadBackgroundImageBox;
        private System.Windows.Forms.Button camSubtract;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}

