using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comteco.Tv
{
    public class PlayList
    {
        private readonly List<Video> _videos;
        public PlayList(List<Video> videos)
        {
            _videos = videos;
        }
    }
    public class Video
    {
        public readonly string _title;
        public readonly string _path;

        public Video(string title, string path)
        {
            _title = title;
            _path = path;
        }
    }

}
