using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class VideoMkv : VideoPlayer
    {
        public override void DecodeFormat()
        {
            Console.WriteLine("Decoding Mkv video.");
        }
    }
}
