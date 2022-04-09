using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace OpenLP2ProPresenter
{
    class ProPresenterFilesExporter : IExporter
    {
        public void export(List<ProPresenterItem> parsedItems)
        {
            parsedItems.ForEach(delegate(ProPresenterItem item) {
                try
                {
                    String fileName = "songs/" + item.Title + ".txt";

                    if(!Directory.Exists("songs"))
                    {
                        Directory.CreateDirectory("songs");
                    }

                    if(File.Exists(fileName)) {
                        fileName = "songs/" + item.Title + "(1).txt";
                    }

                    File.WriteAllText(fileName, "Title: " + item.Title + "\n\n" + item.Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
