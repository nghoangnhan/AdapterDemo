using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NAudio.Lame;

namespace AdapterDemo
{
    internal class WavPlayer : AdvancedMediaPlayer
    {
        public void PlayMp4(AudioFile audioFile)
        {
        
        }

        public void PlayWav(AudioFile audioFile) 
        {
            WaveOutEvent waveOut = audioFile.waveOut;
            MemoryStream stream = new MemoryStream(audioFile.audioData);

            // Create a new WaveStream from the stream
            WaveStream waveStream = new WaveFileReader(stream);

            // Create a new WaveOutEvent object and set the audio stream
            waveOut.Init(waveStream);

            waveOut.Play();
        }
    }
}
