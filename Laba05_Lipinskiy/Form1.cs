using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using Microsoft.Win32;
using System.IO;

namespace Laba05_Lipinskiy
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        tTime.Visible = false;
    }

    private void bInFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = openFileDialog.FileName;
            tInFilePath.Text = fileName;

            decimal sizeFile = SizeFile(fileName, "Mb");
            if (sizeFile == 0)
                tSizeInFile.Text = "0";
            else
                tSizeInFile.Text = "≈ " + sizeFile.ToString() + "...";
        }
    }

    private void bOutFile_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "txt файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
        saveFileDialog.FilterIndex = 1;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = saveFileDialog.FileName;
            tOutFilePath.Text = fileName;

            decimal sizeFile = SizeFile(fileName, "Bytes");
            if (sizeFile == 0)
                tSizeOutFile.Text = "0";
            else
                tSizeOutFile.Text =  "≈ " + sizeFile.ToString() + "...";
        }
    }

    private void bStart_Click(object sender, EventArgs e)
    {
        if (myCheck() == false) return;        

        byte[] inArr = File.ReadAllBytes(tInFilePath.Text); 

        
        tTime.Visible = false;
        DateTime dt = DateTime.Now;
       
        byte[] outArr = { 0 };
        outArr = myEncoding(inArr); 

        TimeSpan ts = DateTime.Now - dt;
        tTime.Text = ts.ToString("G"); 
        tTime.Visible = true;
        

        File.WriteAllBytes(tOutFilePath.Text, outArr);        

        decimal sizeFile = SizeFile(tOutFilePath.Text, "Bytes");
        if (sizeFile == 0)
            tSizeOutFile.Text = "0";
        else
            tSizeOutFile.Text = "≈ " + sizeFile.ToString();

        string result = BitConverter.ToString(outArr).Replace("-", "");
        MessageBox.Show("У файлі записане число (контрольна сума вхідного файлу):\n" + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void bClean_Click(object sender, EventArgs e)
    {
        tInFilePath.Text = "";
        tOutFilePath.Text = "";

        tSizeInFile.Text = "";
        tSizeOutFile.Text = "";
    }

    private decimal SizeFile(string fileName, string sizeFile)
    {
        FileInfo fi = new FileInfo(fileName);
        if (fi.Exists)
        {
            decimal filesizeInBytes = fi.Length; 
                                                 
            decimal filesizeInMegaBytes = Math.Round(filesizeInBytes / (1024 * 1024), 3);
            if (sizeFile == "Mb")
                return filesizeInMegaBytes;
            else
                return filesizeInBytes;
        }
        return 0;
    }

    private bool myCheck()
    {
        if (tInFilePath.Text == "" || tOutFilePath.Text == "")
        {
            MessageBox.Show("Вкажіть шлях до файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        FileInfo fi = new FileInfo(tInFilePath.Text);
        if (fi.Exists == false)
        {
            MessageBox.Show("Вхідний файл відсутній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        FileInfo fo = new FileInfo(tOutFilePath.Text);
        if (fo.Exists == false)
        {
            File.Create(tOutFilePath.Text).Dispose(); 
            tSizeOutFile.Text = "0";
        }

        return true;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show("Кириєнко Дарій", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private byte[] myEncoding(byte[] inArr)
    {
        byte[] result = { 0 };

        if (rB_CRC32.Checked == true)
        {
            uint a = Crc.Crc32(inArr);
            return BitConverter.GetBytes(a);
        }
        if (rB_HAVAL.Checked == true)
        {
            HashAlgorithm sha = KeyedHashAlgorithm.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_RIPEMD160.Checked == true)
        {
            HashAlgorithm sha = RIPEMD160.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_MD5.Checked == true)
        {
            HashAlgorithm sha = MD5.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_SHA1.Checked == true)
        {
            HashAlgorithm sha = SHA1.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_SHA256.Checked == true)
        {
            HashAlgorithm sha = SHA256.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_SHA384.Checked == true)
        {
            HashAlgorithm sha = SHA384.Create();
            return sha.ComputeHash(inArr);
        }
        if (rB_SHA512.Checked == true)
        {
            HashAlgorithm sha = SHA512.Create();
            return sha.ComputeHash(inArr);
        }

        return result;
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        string str = @"Виконав студент Липинский Юрий";
        MessageBox.Show(str, "Опис", MessageBoxButtons.OK, MessageBoxIcon.Information);        
    }
}
}
