﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLP2ProPresenter
{
    class XMLSongParser : ISongContentParser
    {
        List<StructParsedSong> ISongContentParser.parseContent(List<StructUnparsedSong> unparsedSongs)
        {
            List<StructParsedSong> parsedSongs = new List<StructParsedSong>();

            unparsedSongs.ForEach(delegate(StructUnparsedSong song)
            {
                StructParsedSong parsedSong = new StructParsedSong(song.Title, song.UnparsedContent);
                parsedSongs.Add(parsedSong);
            });

            return parsedSongs;
        }
    }
}