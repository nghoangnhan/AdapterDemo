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

        private byte[] ConvertMp4ToWav(String fileName, int bufferSize)
        {
            MediaFoundationReader reader = new MediaFoundationReader(fileName);
            WaveStream waveStream = WaveFormatConversionStream.CreatePcmStream(reader);

            MemoryStream memoryStream = new MemoryStream();

            WaveFileWriter writer = new WaveFileWriter(memoryStream, waveStream.WaveFormat);

            byte[] buffer = new byte[bufferSize];
            int bytesRead = 0;

            while((bytesRead = waveStream.Read(buffer,0, buffer.Length)) > 0)
            {
                writer.Write(buffer, 0, bytesRead);
            }
            byte[] byteArray = memoryStream.ToArray();

            return byteArray;
        }


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
