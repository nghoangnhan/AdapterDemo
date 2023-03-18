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
        public WaveOutEvent waveOut = new WaveOutEvent();
        MediaAdapter mediaAdapter;


        public void play(String audioType, byte[] audioData)
        {
            MemoryStream stream = new MemoryStream(audioData);
            if (audioType == "mp3")
            {
                // Create a new WaveStream from the stream
                WaveStream waveStream = new Mp3FileReader(stream);

                // Create a new WaveOutEvent object and set the audio stream
                waveOut.Init(waveStream);
                waveOut.Play();
            } 
            else if(audioType == "mp4")
            {


            }
            else if (audioType == "wav")
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, audioData);
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }
    }
}
