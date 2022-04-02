using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    interface ISongContentParser
    {
        List<StructParsedSong> parseContent(List<StructUnparsedSong> unparsedSongs);
    }
}
