using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OpenLP2ProPresenter
{
    class OpenLPSQLiteImporter : IOpenLPDataImporter
    {
        List<OpenLPItem> IOpenLPDataImporter.getData()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            return ReadData(sqlite_conn);
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=songs.sqlite;");

            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }


        static List<OpenLPItem> ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader dataReader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM songs";

            List<OpenLPItem> songs = new List<OpenLPItem>();

            

            dataReader = sqlite_cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string title = dataReader.GetString(1);
                string content = dataReader.GetString(3);

                OpenLPItem song = new OpenLPItem(title, content);

                songs.Add(song);
            }
            conn.Close();

            return songs;
        }
    }
}