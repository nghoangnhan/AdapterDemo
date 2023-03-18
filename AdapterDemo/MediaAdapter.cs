using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    internal class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(String audioType)
        {
            if (audioType == "wav")
            {
                advancedMediaPlayer = new WavPlayer();
            }
            else
            {
                advancedMediaPlayer = new MP4Player();
            }
        }

        public void play(String audioType, byte[] audioData)
        {
            if(audioType == "wav")
            {
                advancedMediaPlayer.PlayWav(audioData);
            }
            else
            {
                advancedMediaPlayer.PlayMp4(audioData);
            }
            
        }

    }
}
