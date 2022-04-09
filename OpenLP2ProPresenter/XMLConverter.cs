using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace OpenLP2ProPresenter
{
    class XMLConverter : IItemConverter
    {
        readonly IProPresenterTextGenerator TextGenerator;

        public XMLConverter(IProPresenterTextGenerator textGenerator)
        {
            TextGenerator = textGenerator;
        }

        List<ProPresenterItem> IItemConverter.convert(List<OpenLPItem> OpenLPItems)
        {
            List<ProPresenterItem> proPresenterItems = new();

            OpenLPItems.ForEach(delegate (OpenLPItem item)
            {
                IEnumerable<OpenLPVerse> verses = GetVerses(item);

                ProPresenterItem proPresenterItem = new(item.Title, TextGenerator.generate(verses));
                proPresenterItems.Add(proPresenterItem);
            });

            return proPresenterItems;
        }

        private IEnumerable<OpenLPVerse> GetVerses(OpenLPItem item)
        {
            XDocument unparsed = new();
            unparsed = XDocument.Parse(item.UnparsedContent);

            IEnumerable<OpenLPVerse> parsedItems = unparsed.Element("song")
                .Descendants("verse")
                .Select(x => new OpenLPVerse(x.Attribute("type").Value,
                    x.Attribute("label").Value,
                    x.Value)
                );

            return parsedItems;
        }
    }
}
