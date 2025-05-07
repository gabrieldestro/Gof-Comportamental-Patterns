using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CompressionZip : ICompression
    {
        public void CompressFile(string fileName)
        {
            Console.WriteLine("Compression using the Zip format.");
        }
    }
}
