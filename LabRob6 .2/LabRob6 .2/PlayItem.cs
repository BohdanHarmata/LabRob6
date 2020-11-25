using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Collections.ObjectModel;

namespace LabRob6._2
{


    class PlayItem : IMedia
    {
        public string filePath { get; set; }

        public string name { get; set; }

        
    }
}
