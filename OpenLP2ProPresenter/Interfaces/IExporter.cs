using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    interface IExporter
    {
        void export(List<ProPresenterItem> parsedSongs);
    }
}
