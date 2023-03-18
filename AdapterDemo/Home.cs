using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AdapterDemo
{
    public partial class Home : Form
    {
        public String fileName, audioType;
        AudioPlayer audioPlayer;
        byte[] audioData;
        OpenFileDialog openFileDialog = new OpenFileDialog();


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

            openFileDialog.Filter = "Audio files (*.mp3)|*.mp3|MP4 files (*.mp4)|*.mp4|WAV files (*.wav)|*.wav";
            openFileDialog.Title = "Select an audio file";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (fileName != null)
                audioPlayer.play(audioType, audioData);
            else
                MessageBox.Show("Open an audio file !!!");

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                if (fileName.Contains(".mp3"))
                    audioType = "mp3";
                else if (fileName.Contains(".mp4"))
                    audioType = "mp4";
                else if (fileName.Contains(".wav"))
                    audioType = "wav";
                else
                    audioType = "Other type";


                lbType.Text = "Type: " + audioType;
                lbSong.Text = "Song: " + fileName;

                audioData = File.ReadAllBytes(fileName);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WaveOutEvent waveOut = audioPlayer.waveOut;
            waveOut.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WaveOutEvent waveOut = audioPlayer.waveOut;
            waveOut.Pause();
        }
    }
}
