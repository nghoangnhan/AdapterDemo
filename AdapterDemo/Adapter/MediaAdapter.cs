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

        public MediaAdapter(AudioFile audioFile)
        {
            if (audioFile.audioType == "wav")
            {
                advancedMediaPlayer = new WavPlayer();
            }
            else
            {
                advancedMediaPlayer = new MP4Player();
            }
        }

        public void play(AudioFile audioFile)
        {
            if(audioFile.audioType == "wav")
            {
                advancedMediaPlayer.PlayWav(audioFile);
            }
            else
            {
                advancedMediaPlayer.PlayMp4(audioFile);
            }
            
        }

    }
}
