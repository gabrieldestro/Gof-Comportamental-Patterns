using Strategy;

CompressionContext ctx = new CompressionContext(new CompressionRar());
ctx.CompressFile("file.txt");

ctx.DefineStrategy(new CompressionZip());
ctx.CompressFile("file.txt");

ctx.DefineStrategy(new CompressionGzip());
ctx.CompressFile("file.txt");
