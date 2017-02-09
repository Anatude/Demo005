using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumiApplication
{
    class Albumi
    {
        public string Albumname { get; set; }
        public string Artist { get; set; }

        private List<Track> tracks;
        public Albumi()
        {
            tracks = new List<Track>();
        }
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }
        public Track GetTrack(int index)
        {
            if (index < tracks.Count) return tracks.ElementAt(index);
            else return null;
        }
        public void PrintCollection()
        {
            foreach(Track track in tracks)
            {
                Console.WriteLine(track.ToString());
            }
        }
    }
}
