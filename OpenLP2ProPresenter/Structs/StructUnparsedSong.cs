using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    struct StructUnparsedSong
    {
        public StructUnparsedSong(String title, String unparsedContent)
        {
            Title = title;
            UnparsedContent = unparsedContent;
        }

        public String Title { get; }
        public String UnparsedContent { get; }
    }
}
