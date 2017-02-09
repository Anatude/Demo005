using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi data = new Albumi();

            data.Artist = "SoD.Andeby";
            data.Albumname = "Ebin L4n Biisit";            
            
            // create new track
            Track track1 = new Track
            {
                Trackname = "Hoponpoppoo",
                Tracklenght = "5:17"
            };
            Track track2 = new Track
            {
                Trackname = "Simon salaisuudet",
                Tracklenght = "13:37"
            };
            Track track3 = new Track
            {
                Trackname = "Huamenta pojka (intro)",
                Tracklenght = "0:42"
            };
            Track track4 = new Track
            {
                Trackname = "Huamenta pojka",
                Tracklenght = "4:20"
            };
            Track track5 = new Track
            {
                Trackname = "Hoponpoppoo OUTRO",
                Tracklenght = "1:12"
            };
            Albumi biisi = new Albumi();
            // Add track to tracks collection
            biisi.AddTrack(track1);
            biisi.AddTrack(track2);
            biisi.AddTrack(track3);
            biisi.AddTrack(track4);
            biisi.AddTrack(track5);





            Console.WriteLine("Album data:");
            Console.WriteLine("Album name: " + data.Albumname);
            Console.WriteLine("Artist: " + data.Artist);
            Console.WriteLine("Tracks: ");
            biisi.PrintCollection();
        }
    }
}
