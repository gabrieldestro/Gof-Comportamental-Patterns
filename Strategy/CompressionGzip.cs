using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CompressionGzip : ICompression
    {
        public void CompressFile(string fileName)
        {
            Console.WriteLine("Compression using the Gzip format.");
        }
    }
}
