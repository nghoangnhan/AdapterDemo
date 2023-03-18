using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AdapterDemo
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdaper;
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public void play(String audioType, String fileName)
        {
            if (audioType == "mp3")
            {
                player.URL = fileName;
                player.controls.play();
            } 
            else if(audioType == "mp4")
            {
                mediaAdaper = new MediaAdapter(audioType);
                mediaAdaper.play(audioType, fileName);
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }
    }
}
