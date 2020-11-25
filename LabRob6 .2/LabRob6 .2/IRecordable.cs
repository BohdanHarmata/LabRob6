using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace LabRob6._2
{
    public interface IRecordable
    {
        void Record();

        void Pause();

        void Stop();
    }
}
