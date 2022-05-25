using System;
using System.IO;
using System.Data;
using ImageMagick;
using System.Diagnostics;
using Console = Colorful.Console;
using System.Drawing;
using System.Net;
using Xabe.FFmpeg;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;
using NLog;

namespace W_ImageConverter
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static string applocation = AppDomain.CurrentDomain.BaseDirectory;
        public static string tarih = DateTime.Now.Hour + ":"  + DateTime.Now.Minute + ":" + DateTime.Now.Second;

        public static string log_error = "[ERROR " + tarih + "]";
        public static string log_info = "[INFO " + tarih + "]";
        public static string log_warning = "[WARN " + tarih + "]";
        public static string log_success = "[SUCCESS " + tarih + "]";
        

        static void Main(string[] args)
        {

          //  move();

            Console.Title = "Heic2Jpg By Warss78";

Console.WriteLine(@"    __         _     ___     _               ");
Console.WriteLine(@"   / /_  ___  (_)___|__ \   (_)___  ____ _   ");
Console.WriteLine(@"  / __ \/ _ \/ / ___/_/ /  / / __ \/ __ `/   ");
Console.WriteLine(@" / / / /  __/ / /__/ __/  / / /_/ / /_/ /    ");
Console.WriteLine(@"/_/ /_/\___/_/\___/____/_/ / .___/\__, /  ");
Console.WriteLine(@"                      /___/_/    /____/   ");
            Console.WriteLine(string.Empty);
            Console.Write("                                ");
 Typewrite("By Warss78",Color.Red);
Console.WriteLine(string.Empty);

            Console.WriteLine(log_info + " Klasörler Aranıyor", Color.Turquoise);
            if (!Directory.Exists(applocation + "heic") && !Directory.Exists(applocation + "jpg"))
            {

                Console.WriteLine(log_warning + " Klasör Bulunamadı", Color.Orange);

                Console.WriteLine(log_info + " Klasörler Oluşturuluyor",Color.Orange);
                Directory.CreateDirectory(applocation + "heic");
                Directory.CreateDirectory(applocation + "jpg");
                Console.WriteLine(log_success + " Klasörler Oluşturldu", Color.Green);

                Main(null);
            }

            else
            {
                move();
            }

        }

        public static void move()
        {
            Typewrite(log_info + " Standart Dosyalar Taranıyor Lütfen Bekleyiniz \n",Color.Green);
            int mp4 = Directory.GetFiles(applocation + "heic", "*.mp4*", SearchOption.AllDirectories).Length;
            int jpg = Directory.GetFiles(applocation + "heic", "*.jpg*", SearchOption.AllDirectories).Length;
            int png = Directory.GetFiles(applocation + "heic", "*.png*", SearchOption.AllDirectories).Length;

            if (mp4 > 0  || jpg > 0 || png > 0)
            {
                Console.WriteLine(log_warning + " {0} adet mp4 dosyası bulundu jpg klasörüne taşınıyor",mp4, Color.Orange);
                Console.WriteLine(log_warning + " {0} adet jpg dosyası bulundu jpg klasörüne taşınıyor",jpg, Color.Orange);
                Console.WriteLine(log_warning + " {0} adet png dosyası bulundu jpg klasörüne taşınıyor",png, Color.Orange);

                Console.WriteLine(log_info + " Taşımaya Hazırlanıyor..", Color.Turquoise);


                List<string> imageFiles = new List<string>();

                var allowedExtensions = new[] { ".jpg", ".gif", ".png", ".mp4", "mp3"};

                //string[] allfiles = Directory.GetFiles(applocation + "heic", @"*.jpg", SearchOption.AllDirectories);
                var allfiles = Directory.EnumerateFiles(applocation + "heic", "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".mp4") || s.EndsWith(".png")|| s.EndsWith(".jpg") || s.EndsWith(".gif"));

                foreach (var file in allfiles)
                {
                    FileInfo info = new FileInfo(file);
                   
                            imageFiles.Add(file);
                            Console.WriteLine(log_info + $" Taşınıyor {info.Name}",Color.Turquoise);
                            File.Move(info.FullName,applocation + $"jpg/{info.Name}",true);
                }
                Console.WriteLine(log_success + " Tamamlandı", Color.Green);
                    Get();
            }
            else 
            {

                Console.WriteLine(log_info + " Standart Dosya Bulunamadı", Color.Turquoise);
                Get();
            }
        }
        public static void temizle()
        {
            bool sil;
            Console.WriteLine(log_info + "Eski Heic Ve Mov Dosyaları Silinsinmi",Color.Turquoise);
            var docPath = applocation + "heic";
            double size = 0;
            var myDir = $@"{docPath}";

            var dirInfo = new DirectoryInfo(myDir);

            foreach (FileInfo fi in dirInfo.GetFiles("*", SearchOption.AllDirectories))
            {
                size += fi.Length;
            }

            size  = size / 1024 / 1024 ;
            
            size = Math.Round(size, 2);
            int boyut = (int)size / 1024;
            string type = "";
            if (boyut >= 1)
            {
                type = "GB";
            }
            else
            {
                type = "MB";
            }
            Console.WriteLine(log_info  + $"Klasör Boyutu : {size}" + type ,Color.Turquoise);
            Console.WriteLine(log_info + "Evet için (E) Hayır İçin (H) Tusuna Basınız",Color.Orange);
            String cevap = Console.ReadLine();

            string[] allfiles = Directory.GetFiles(applocation + "heic", "*.heic", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                using (MagickImage image = new MagickImage(info.FullName))
                {
                    Console.WriteLine(log_info + " Dosya: " + $"{info.Name}", Color.Turquoise);
                    info.Name.Split(new[] { ".heic" }, StringSplitOptions.None);

                    image.Write(applocation + "/jpg/" + $" {info.Name}.jpg");

                }


            }

            if (cevap == "E"|| cevap == "e" )
            {
                Console.WriteLine(log_info + "Siliniyor..",Color.Turquoise);
                System.IO.DirectoryInfo di = new DirectoryInfo(applocation+"heic");

                foreach (FileInfo file in di.GetFiles())
                {
                    Console.WriteLine("Sİliniyor:{0}", file.Name,Color.Red);
                     file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    Console.WriteLine("Sİliniyor:{0}", dir.Name, Color.Red);

                    dir.Delete(true);
                }
                Console.WriteLine(log_success  + "Silindi" ,Color.Green);
                Console.ReadLine();
            }

            else if (cevap == "H" ||cevap == "h")
            {
                
                
                Console.WriteLine(log_success+ " Tamamlandı" ,Color.Green);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
                temizle();
            }


        }
        public static  void Get()
        {


            int png = Directory.GetFiles(applocation + "heic", "*.MOV*", SearchOption.AllDirectories).Length;

            int fileCount = Directory.GetFiles(applocation + "heic", "*.heic*", SearchOption.AllDirectories).Length;
            int fCount = Directory.GetFiles(applocation + "heic", "*.MOV*", SearchOption.AllDirectories).Length;

            if (fileCount >= 1 || fCount >=   1) {

                check();

            }

            else
            {
                Console.WriteLine(log_error + "Resim Yada Bulunamadı lütfen {0} klasörüne resim veya video ekleyiniz", applocation + "heic", Color.Red);
                Console.ReadKey();
           }
        }

        public static void Convertt()
        {
            Console.WriteLine(log_info + " Dönüştürülüyor",Color.Turquoise);
            string[] allfiles = Directory.GetFiles(applocation + "heic", "*.heic", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                using (MagickImage image = new MagickImage(info.FullName))
                {
                    Console.WriteLine(log_info + " Dosya: " + $"{info.Name}", Color.Turquoise);
                    info.Name.Split(new[] { ".heic" }, StringSplitOptions.None);

                    image.Write( applocation + "/jpg/" + $" {info.Name}.jpg");
                    
                }


            }
            Console.WriteLine(log_success + " Tamamlandı",Color.Green);
            
            log();
           

        }

        public static void log()
        {
            if (File.Exists(applocation + "logs/latest.log")) {
                DateTime creation = File.GetCreationTime(applocation + "logs/latest.log");

                //File.Move(applocation + "logs/latest.log", applocation + $"logs/logs{creation}.log");
            }
            else
            {
                Directory.CreateDirectory(applocation + "logs");
                Trace.Listeners.Clear();

                TextWriterTraceListener twtl = new TextWriterTraceListener(applocation + "logs");
                twtl.Name = "TextLogger";
                twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;

                ConsoleTraceListener ctl = new ConsoleTraceListener(false);
                ctl.TraceOutputOptions = TraceOptions.DateTime;

                Trace.Listeners.Add(twtl);
                Trace.Listeners.Add(ctl);
                Trace.AutoFlush = true;

                Trace.WriteLine("The first line to be in the logfile and on the console.");
                Process.Start("explorer.exe", applocation + "jpg");
                Console.ReadKey();
                Environment.Exit(1);
            }
           
        }
        public static void Typewrite(string message , Color color )
        {
            for (int i = 0; i < message.Length; i++)
            {
                Colorful.Console.Write(message[i],color);

                System.Threading.Thread.Sleep(60);
            }

        }

        public static void check()
        {


            if (Directory.Exists(applocation + "ffmpeg"))
            {
                if (File.Exists(applocation + "ffmpeg/ffmpeg.exe"))
                {
                    int fileCount = Directory.GetFiles(applocation + "heic", "*.MOV*", SearchOption.AllDirectories).Length;

                    Console.WriteLine(log_info + " Video bulundu : {0} adet", fileCount, Color.Orange);

                    Console.WriteLine(log_info + " Dönüştürülüyor", Color.Turquoise);
                    string[] allfiles = Directory.GetFiles(applocation + "heic", "*.MOV", SearchOption.AllDirectories);



                    foreach (var file in allfiles)
                    {
                        FileInfo info = new FileInfo(file);

                        Console.WriteLine(log_info + $" Dosya:{info.Name}", Color.Turquoise);
                        Convert_video($"{info.FullName}", applocation + $"jpg/{info.Name}.mp4");


                    }
                    Console.WriteLine(log_success + " Tamamlandı", Color.Green);
                    ffmpeg_kill();
                    Convertt();
                }

            } 

            else
            {
                Console.WriteLine(log_warning + " Eksik Dosya Tespit Edildi Onarılıyorur", Color.Tomato);
                Console.WriteLine(log_info + " Dosyalar Kopyalanıyor", Color.Tomato);
                Directory.CreateDirectory(applocation + "temp");
                File.WriteAllBytes(applocation + "temp/ffmpeg.zip", Properties.Resources.ffmpeg_zip);
                Console.WriteLine(log_info + " Dosyalar Çıkartılıyor", Color.Turquoise);

                ZipFile.ExtractToDirectory(applocation + "temp/ffmpeg.zip", applocation + "ffmpeg");
                Directory.CreateDirectory(applocation + "ffmpeg");
                Console.WriteLine(log_success + " Dosyalar Çıkartıldı", Color.Green);
                Thread.Sleep(10);

            }
            Process.Start(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Environment.Exit(1);

        }

        private static void Convert_video(string source,string output)
        {
            Process p = new Process();
            p.StartInfo.FileName = applocation + "ffmpeg/ffmpeg.exe";
            p.StartInfo.Arguments = $"-i  {source} {output} -y";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true  ;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += P_OutputDataReceived;
            p.Start();
            p.WaitForExit();
   
        }

        private static void ffmpeg_kill()
        {
            Process[] workers = Process.GetProcessesByName("ffmpeg");
foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
            }
        }

        private static void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
    }
}
