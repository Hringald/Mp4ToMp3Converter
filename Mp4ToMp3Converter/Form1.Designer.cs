﻿
namespace Mp4ToMp3Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathVideo = new System.Windows.Forms.TextBox();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input videos path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save to:";
            // 
            // txtPathVideo
            // 
            this.txtPathVideo.Location = new System.Drawing.Point(83, 70);
            this.txtPathVideo.Name = "txtPathVideo";
            this.txtPathVideo.Size = new System.Drawing.Size(262, 27);
            this.txtPathVideo.TabIndex = 2;
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Location = new System.Drawing.Point(83, 155);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.Size = new System.Drawing.Size(262, 27);
            this.txtSaveTo.TabIndex = 3;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Location = new System.Drawing.Point(386, 70);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(133, 27);
            this.btnOpenVideo.TabIndex = 4;
            this.btnOpenVideo.Text = "Open Video";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(83, 212);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(436, 27);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 291);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.txtSaveTo);
            this.Controls.Add(this.txtPathVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MP4 to MP3 Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathVideo;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConvert;
    }
}

