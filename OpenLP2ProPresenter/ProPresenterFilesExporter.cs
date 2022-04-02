using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OpenLP2ProPresenter
{
    class ProPresenterFilesExporter : ISongExporter
    {
        public void exportSongs(List<StructParsedSong> parsedSongs)
        {
            parsedSongs.ForEach(delegate(StructParsedSong song) {
                try
                {
                    File.WriteAllText("songs/" + song.Title + ".txt", song.Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
