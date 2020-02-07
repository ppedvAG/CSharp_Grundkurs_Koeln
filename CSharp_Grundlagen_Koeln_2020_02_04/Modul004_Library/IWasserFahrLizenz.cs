using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public interface IWasserFahrLizenz
    {
        DateTime LizenzWurdeAusgestellt { get; set; }
        void AnzeigeDerWasserLizent();
    }
}
