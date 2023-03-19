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
        public AudioFile audioFile = new AudioFile();
        AudioPlayer audioPlayer;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        bool isPause = true;


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

            if (audioFile.fileName != null)
                audioPlayer.play(audioFile);
            else
                MessageBox.Show("Open an audio file !!!");

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                audioFile.fileName = openFileDialog.FileName;

                if (audioFile.fileName.Contains(".mp3"))
                    audioFile.audioType = "mp3";

                else if (audioFile.fileName.Contains(".mp4"))
                    audioFile.audioType = "mp4";

                else if (audioFile.fileName.Contains(".wav"))
                    audioFile.audioType = "wav";

                else
                    audioFile.audioType = "Other type";


                lbType.Text = "Type: " + audioFile.audioType;
                lbSong.Text = "Song: " + audioFile.fileName;

                audioFile.audioData = File.ReadAllBytes(audioFile.fileName);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WaveOutEvent waveOut = audioFile.waveOut;
            waveOut.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WaveOutEvent waveOut = audioFile.waveOut;
            if (isPause)
            {
                waveOut.Pause();
                isPause = false;
            }
            else
            {
                waveOut.Play();
                isPause = true;
            }
        }
    }
}
