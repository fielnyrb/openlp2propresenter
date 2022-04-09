using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    class EffectAddTitles : Interfaces.ITextGeneratorEffect
    {
        public OpenLPVerse apply(OpenLPVerse original)
        {
            if (original.Type != "")
            {
                String title = mapTypes(original.Type) + " " + original.Label;
                title = title.Trim();

                original.Content = title + "\n" + original.Content;
            }

            return original;
        }

        private String mapTypes(String type)
        {
            if (type == "v")
            {
                return "Verse";
            }
            if (type == "c")
            {
                return "Chorus";
            }
            if (type == "b")
            {
                return "Bridge";
            }
            if(type == "o")
            {
                return "Outro";
            }
            if(type == "p")
            {
                return "PreChorus";
            }
            return "";
        }
    }
}
