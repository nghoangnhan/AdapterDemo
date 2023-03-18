using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace AdapterDemo
{
    public class MP4Player : AdvancedMediaPlayer
    {
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public void PlayMp4(String fileName)
        {
            player.URL = fileName;
            player.controls.play();

        }
    }
}
