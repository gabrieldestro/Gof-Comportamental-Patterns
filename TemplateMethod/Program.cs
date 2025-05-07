using TemplateMethod;

Console.WriteLine("Playing Mp4 video.");
VideoPlayer vpMp4 = new VideoMp4();
vpMp4.ExecuteVideo();

Console.WriteLine("\nPlaying Mkv video.");
VideoPlayer vpMkv = new VideoMkv();
vpMkv.ExecuteVideo();
