using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpenLP2ProPresenter
{
    class XMLSongParser : ISongContentParser
    {
        List<StructParsedSong> ISongContentParser.parseContent(List<StructUnparsedSong> unparsedSongs)
        {
            List<StructParsedSong> parsedSongs = new List<StructParsedSong>();

            unparsedSongs.ForEach(delegate(StructUnparsedSong song)
            {
                XDocument unparsed = new XDocument();
                unparsed = XDocument.Parse(song.UnparsedContent);

                var parsed = unparsed.Element("song")
                .Descendants("verse")
                .Select(x => new
                {
                    vv = x.Value
                });


                StructParsedSong parsedSong = new StructParsedSong(song.Title, song.UnparsedContent);
                parsedSongs.Add(parsedSong);
            });

            return parsedSongs;
        }
    }
}
