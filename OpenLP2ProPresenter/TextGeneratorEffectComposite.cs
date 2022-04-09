using System.Collections.Generic;

namespace OpenLP2ProPresenter
{
    class TextGeneratorEffectComposite : Interfaces.ITextGeneratorEffect
    {
        public TextGeneratorEffectComposite()
        {
            effects = new List<Interfaces.ITextGeneratorEffect>();
        }

        public void AddComponent(Interfaces.ITextGeneratorEffect effect)
        {
            effects.Add(effect);
        }

        public OpenLPVerse apply(OpenLPVerse original)
        {
            OpenLPVerse s = original;
            foreach(var effect in effects)
            {
                s = effect.apply(s);
            }

            return s;
        }

        private ICollection<Interfaces.ITextGeneratorEffect> effects;
    }
}
