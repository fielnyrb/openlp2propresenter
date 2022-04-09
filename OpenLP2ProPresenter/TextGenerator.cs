using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    class TextGenerator : IProPresenterTextGenerator
    {
        public TextGenerator(Interfaces.ITextGeneratorEffect effectComposite)
        {
            EffectComposite = effectComposite;
        }

        public string generate(IEnumerable<OpenLPVerse> verses)
        {
            StringBuilder sb = new();

            foreach (OpenLPVerse verse in verses)
            {
                OpenLPVerse changedVerse = EffectComposite.apply(verse);
                sb.Append(changedVerse.Content);
                sb.Append("\n\n\n");
            }

            return sb.ToString().TrimEnd();
        }

        private readonly Interfaces.ITextGeneratorEffect EffectComposite;
    }
}
