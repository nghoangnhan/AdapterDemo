using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public interface AdvancedMediaPlayer
    {
        void PlayMp4(AudioFile audioFile);
        void PlayWav(AudioFile audioFile);
    }
}
