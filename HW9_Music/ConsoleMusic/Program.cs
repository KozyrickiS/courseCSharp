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

            var item = Song.GetSongData(song);
            Console.WriteLine(item);
            Console.WriteLine(item.GetType());
            var output = JsonConvert.SerializeObject(item);
            Console.WriteLine(output);

            var item2 = Song.GetSongData(song2);
            Console.WriteLine(item2);
            var output2 = JsonConvert.SerializeObject(item2, Formatting.Indented);
            Console.WriteLine(output2);

            var item3 = Song.GetSongData(song3);
            Console.WriteLine(item3);
            var output3 = JsonConvert.SerializeObject(item3, Formatting.None);
            Console.WriteLine(output3);

            var item4 = Song.GetSongDataByTitle("Creep");
            Console.WriteLine(item4);
            var output4 = JsonConvert.SerializeObject(item4, Formatting.Indented);
            Console.WriteLine(output4);

            Console.ReadKey();

        }
    }
}
