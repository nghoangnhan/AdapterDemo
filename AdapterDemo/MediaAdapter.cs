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
            advancedMediaPlayer = new MP4Player();
        }

        public void play(String audioType, String fileName)
        {
            advancedMediaPlayer.PlayMp4(fileName);
        }

    }
}
