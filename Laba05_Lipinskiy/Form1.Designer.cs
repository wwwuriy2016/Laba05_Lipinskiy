
namespace Laba05_Lipinskiy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.bInFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tSizeInFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tSizeOutFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bStart = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вихідний файл:";
            // 
            // tInFilePath
            // 
            this.tInFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tInFilePath.Location = new System.Drawing.Point(150, 20);
            this.tInFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(310, 26);
            this.tInFilePath.TabIndex = 4;
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tOutFilePath.Location = new System.Drawing.Point(150, 58);
            this.tOutFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(310, 26);
            this.tOutFilePath.TabIndex = 5;
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(468, 21);
            this.bInFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(36, 26);
            this.bInFile.TabIndex = 6;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(468, 59);
            this.bOutFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(36, 26);
            this.bOutFile.TabIndex = 7;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_SHA512);
            this.groupBox1.Controls.Add(this.rB_SHA384);
            this.groupBox1.Controls.Add(this.rB_SHA256);
            this.groupBox1.Controls.Add(this.rB_MD5);
            this.groupBox1.Controls.Add(this.rB_RIPEMD160);
            this.groupBox1.Controls.Add(this.rB_HAVAL);
            this.groupBox1.Controls.Add(this.rB_SHA1);
            this.groupBox1.Controls.Add(this.rB_CRC32);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(17, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(245, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи:";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(148, 135);
            this.rB_SHA512.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA512.TabIndex = 7;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(148, 100);
            this.rB_SHA384.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA384.TabIndex = 6;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(148, 65);
            this.rB_SHA256.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA256.TabIndex = 5;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(8, 135);
            this.rB_MD5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(61, 24);
            this.rB_MD5.TabIndex = 4;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(8, 100);
            this.rB_RIPEMD160.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(117, 24);
            this.rB_RIPEMD160.TabIndex = 3;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(8, 65);
            this.rB_HAVAL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(132, 24);
            this.rB_HAVAL.TabIndex = 2;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Location = new System.Drawing.Point(148, 29);
            this.rB_SHA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(75, 24);
            this.rB_SHA1.TabIndex = 1;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Checked = true;
            this.rB_CRC32.Location = new System.Drawing.Point(9, 29);
            this.rB_CRC32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(79, 24);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tSizeInFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(270, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(242, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт):";
            // 
            // tSizeInFile
            // 
            this.tSizeInFile.AutoSize = true;
            this.tSizeInFile.Location = new System.Drawing.Point(158, 32);
            this.tSizeInFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSizeInFile.Name = "tSizeInFile";
            this.tSizeInFile.Size = new System.Drawing.Size(0, 20);
            this.tSizeInFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tSizeOutFile);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(270, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 57);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байти)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вихідного файлу:";
            // 
            // tSizeOutFile
            // 
            this.tSizeOutFile.AutoSize = true;
            this.tSizeOutFile.Location = new System.Drawing.Point(159, 31);
            this.tSizeOutFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSizeOutFile.Name = "tSizeOutFile";
            this.tSizeOutFile.Size = new System.Drawing.Size(0, 20);
            this.tSizeOutFile.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(269, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Тривалість кодування:";
            // 
            // tTime
            // 
            this.tTime.AutoSize = true;
            this.tTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tTime.Location = new System.Drawing.Point(269, 245);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(0, 20);
            this.tTime.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(22, 287);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Автор\r\n";
            this.toolTip1.SetToolTip(this.linkLabel1, "Кириєнко Дарій");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel2.Location = new System.Drawing.Point(146, 287);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 20);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Опис";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bStart.Location = new System.Drawing.Point(270, 272);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(112, 35);
            this.bStart.TabIndex = 21;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClean
            // 
            this.bClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bClean.Location = new System.Drawing.Point(403, 272);
            this.bClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(112, 35);
            this.bClean.TabIndex = 22;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(528, 316);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Циклічний надлишковий код (CRC)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tSizeInFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tSizeOutFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

