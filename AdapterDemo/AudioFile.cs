using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class AudioFile
    {
        public String audioType;
        public String fileName;
        public byte[] audioData;
        public WaveOutEvent waveOut = new WaveOutEvent();

        public AudioFile()
        {

        }

    }
}
