using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class VideoPlayer
    {
        public abstract void DecodeFormat();

        public void ExecuteVideo()
        {
            LoadVideo();
            DecodeFormat();
            InitReprodution();
        }

        public void LoadVideo()
        {
            Console.WriteLine("Loading video.");
        }

        public void InitReprodution()
        {
            Console.WriteLine("Initializing video reproduction.");
        }
    }
}
