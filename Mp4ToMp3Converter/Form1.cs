using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp4ToMp3Converter
{
    public partial class Form1 : Form
    {
        string videoPath, videoName, musicPath, musicName;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            convert.ConvertMedia(txtPathVideo.Text.Trim(), txtSaveTo.Text.Trim(), "mp3");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicPath = folderBrowserDialog.SelectedPath;
                musicName = videoName.Substring(0, videoName.Length - 4);
                musicPath += (@"\\" + musicName + ".mp3");
            }
            txtSaveTo.Text = musicPath;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4" };
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }
            txtPathVideo.Text = videoPath;
        }
    }
}
