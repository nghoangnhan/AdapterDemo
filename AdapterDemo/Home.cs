using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AdapterDemo
{
    public partial class Home : Form
    {
        String fileName, audioType;
        AudioPlayer audioPlayer;
        public Home()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            audioPlayer = new AudioPlayer();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {         

            if (fileName != null)
                audioPlayer.play(audioType, fileName);
            else
                MessageBox.Show("Open an audio file !!!");

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"D:\Rhymth";
            openFileDialog.Filter = "Audio files (*.mp3)|*.mp3|MP4 files (*.mp4)|*.mp4|WAV files (*.wav)|*.wav";
            openFileDialog.Title = "Select a song";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                lbSong.Text = "Song: " + fileName;

                if (fileName.Contains(".mp3"))
                    audioType = "mp3";
                else if (fileName.Contains(".mp4"))
                    audioType = "mp4";
                else
                    audioType = "Other type";

                lbType.Text = "Type: " + audioType;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = audioPlayer.player;
            player.controls.pause();
        }
    }
}
