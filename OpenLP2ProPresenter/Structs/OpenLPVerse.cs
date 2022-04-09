using System;

namespace OpenLP2ProPresenter
{
    struct OpenLPVerse
    {
        public OpenLPVerse(String type, String label, String content)
        {
            Type = type;
            Label = label;
            Content = content;
        }

        public String Type { get; }
        public String Label { get; }
        public String Content { get; set; }
    }
}
