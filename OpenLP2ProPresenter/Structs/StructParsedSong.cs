using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    struct StructParsedSong
    {
        public StructParsedSong(String title, String content)
        {
            Title = title;
            Content = content;
        }

        public String Title;
        public String Content;
    }
}
