using NAudio.Dmo;
using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AdapterDemo
{
    public class MP4Player : AdvancedMediaPlayer
    {

        public void PlayMp4(AudioFile audioFile)
        {

            MemoryStream stream = new MemoryStream(audioFile.audioData);

            // Create a new WaveStream from the stream
            WaveStream waveStream = WaveFormatConversionStream.CreatePcmStream(new StreamMediaFoundationReader(stream));
            MessageBox.Show("worked");

            // Create a new WaveOutEvent object and set the audio stream
            audioFile.waveOut.Init(waveStream);

            audioFile.waveOut.Play();
        }

        public void PlayWav(AudioFile audioFile)
        {

        }
    }
}
