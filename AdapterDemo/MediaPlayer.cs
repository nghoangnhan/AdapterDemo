using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public interface MediaPlayer
    {
        void play(AudioFile audioFile);
    }
}
