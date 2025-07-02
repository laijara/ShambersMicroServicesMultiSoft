using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class SoundPaths
    {
        public readonly Dictionary<int, string> soundPaths = new Dictionary<int, string>
        {
            {1, @".\libraries\ZvonokSoft\Sounds\zvonok.wav"},
            {2, @".\libraries\ZvonokSoft\Sounds\sirena.wav"}
        };
    }
}
