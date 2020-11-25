using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

namespace LabRob6._2
{
    class Wav : IPlayable, IRecordable, IMedia
    {

        public string filePath { get; set; }

        public string name { get; set; }


        public void Play() 
        {
            SoundPlayer sp = new SoundPlayer(filePath +@"\" +  name);
            sp.Play();
        }

        public void Pause()
        {
            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.controls.pause();
        }

        public void Stop()
        {
            SoundPlayer sp = new SoundPlayer(filePath + @"\" + name);
            sp.Stop();

            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.controls.stop();
        }

        public void Record()
        {
            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.URL = filePath + @"\" + name;
            WMP.controls.play();
        }
    }
}
