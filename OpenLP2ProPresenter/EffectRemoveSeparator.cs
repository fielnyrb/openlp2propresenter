using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    class EffectRemoveSeparator : Interfaces.ITextGeneratorEffect
    {
        public OpenLPVerse apply(OpenLPVerse original)
        {
            original.Content = original.Content.Replace("[---]", "");

            return original;
        }

    }
}
