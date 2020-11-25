using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

namespace LabRob6._2
{
    class Mp3 : IRecordable, IMedia
    {

        public string filePath { get; set; }

        public string name { get; set; }

        public void Record()
        {
           WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.URL = filePath + @"\" + name;
            WMP.controls.play();
        }

        public void Pause()
        {
            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.controls.pause();
        }

        public void Stop()
        {
            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            WMP.controls.stop();
        }
    }
}
