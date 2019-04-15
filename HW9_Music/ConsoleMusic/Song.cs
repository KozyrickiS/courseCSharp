using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMusic
{
    class Song
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string Composer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Song(string title, string composer)
        {
            this.Title = title;
            this.Composer = composer;
        }
        public Song(string title, int minutes, int year)
        {
            this.Title = title;
            this.Duration = TimeSpan.FromMinutes(minutes);
            this.ReleaseDate = new DateTime(year, 01, 01);
            Genre = Genre.None;
        }
        public Song(string title, int minutes, string composer, int year, Genre genre)
        {
            this.Title = title;
            this.Duration = TimeSpan.FromMinutes(minutes);
            this.Composer = composer;
            this.ReleaseDate = new DateTime(year, 01, 01);
            this.Genre = genre;
        }

        public static object GetSongData(Song song)
        {
            var res = new
            {
                Title = song.Title,
                SongMinutes = song.Duration.Minutes,
                AlbumYear = song.ReleaseDate.Year,
                SongGenre = song.Genre
            };
            return res;
        }

        public static dynamic GetSongDataByTitle(string title)
        {
            Song song = new Song();
            List<Song> database = DBSongs();
            for (int i = 0; i < database.Count; i++)
            {
                if (title.Equals(database[i].Title))
                {
                    song = database[i];
                }
            }
            var res = new
            {
                Title = song.Title,
                Composer = song.Composer,
                SongSeconds = song.Duration.Seconds,
                AlbumYear = song.ReleaseDate.Year,
                SongGenre = song.Genre
            };
            return res;
        }

        private static List<Song> DBSongs()
        {
            List<Song> songs = new List<Song>();
            Song song0 = new Song("HellBrokeLuce", 4, "Jimi Hendrix", 1963, Genre.Blues);
            songs.Add(song0);
            Song song1 = new Song("Sonata №3", 10, "Beethoven", 1795, Genre.Classical);
            songs.Add(song1);
            Song song2 = new Song("Satura", 9, "Lacrimosa", 1993, Genre.Gothic);
            songs.Add(song2);
            Song song3 = new Song("Lampshades on Fire", 3, "Modest Mouse", 2015, Genre.Indie);
            songs.Add(song3);
            Song song4 = new Song("Dungeons Of Darkness", 5, "Burzum", 2000, Genre.Metal);
            songs.Add(song4);
            Song song5 = new Song("Black Metal", 3, "Cradle of Filth", 2002, Genre.Metal);
            songs.Add(song5);
            Song song6 = new Song("Hammer Smashed Face", 4, "Cannibal Corpse", 2000, Genre.Metal);
            songs.Add(song6);
            Song song7 = new Song("So Long, and Thanks for All the Fish", 5, "A Perfect Circle", 2018, Genre.Rock);
            songs.Add(song7);
            Song song8 = new Song("No Surprises", 3, "Radiohead", 1997, Genre.Rock);
            songs.Add(song8);
            Song song9 = new Song("Creep", 3, "Radiohead", 1993, Genre.Rock);
            songs.Add(song9);
            Song song10 = new Song("T.N.T.", 3, "AC/DC", 1975, Genre.Rock);
            songs.Add(song10);
            return songs;
        }

    }
}
