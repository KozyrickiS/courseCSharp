using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.genre = Genre.Indie;
            song.title = "Ughmerica";
            song.releaseDate = new DateTime(2007, 07, 15);
            song.composer = "Amanda Palmer";
            song.duration = TimeSpan.FromMinutes(3.14);
            Song song2 = new Song("DasPish", 4, 2004);
            Song song3 = new Song("HellBrokeLuce", 3, "Tom Waits", 2000, Genre.Blues);

            Console.WriteLine(Song.GetSongData(song));
            Console.WriteLine(Song.GetSongData(song).GetType());
            var output = JsonConvert.SerializeObject(Song.GetSongData(song));
            Console.WriteLine(output);

            Console.WriteLine(Song.GetSongData(song2));
            var output2 = JsonConvert.SerializeObject(Song.GetSongData(song2), Formatting.Indented);
            Console.WriteLine(output2);

            var itemBySong = Song.GetSongData(song3);
            Console.WriteLine(itemBySong);
            var output3 = JsonConvert.SerializeObject(itemBySong, Formatting.None);
            Console.WriteLine(output3);

            var itemByTitle = Song.GetSongDataByTitle("Creep");
            Console.WriteLine(itemByTitle);
            var output4 = JsonConvert.SerializeObject(itemByTitle, Formatting.Indented);
            Console.WriteLine(output4);

            Console.ReadKey();

        }
    }
}
