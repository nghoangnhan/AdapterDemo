using AxWMPLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using NAudio.Wave;

namespace AdapterDemo
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;


        public void play(AudioFile audioFile)
        {
            MemoryStream stream = new MemoryStream(audioFile.audioData);
            if (audioFile.audioType == "mp3")
            {
                // Create a new WaveStream from the stream
                WaveStream waveStream = new Mp3FileReader(stream);

                // Create a new WaveOutEvent object and set the audio stream
                audioFile.waveOut.Init(waveStream);
                audioFile.waveOut.Play();
            } 
            else if(audioFile.audioType == "mp4")
            {
                mediaAdapter = new MediaAdapter(audioFile);
                mediaAdapter.play(audioFile);

            }
            else if (audioFile.audioType == "wav")
            {
                mediaAdapter = new MediaAdapter(audioFile);
                mediaAdapter.play(audioFile);
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }
    }
}
