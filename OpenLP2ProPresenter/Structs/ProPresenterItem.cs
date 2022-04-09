using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    struct ProPresenterItem
    {
        public ProPresenterItem(String title, String content)
        {
            Title = title;
            Content = content;
        }

        public String Title;
        public String Content;
    }
}
