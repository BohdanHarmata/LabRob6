using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRob6._2
{
    class Program
    {
        public ObservableCollection<IMedia> FileCollection { get; set; } 

        static void Main(string[] args)
        {
            var AudioVideoiles = new List<IMedia>();
            AudioVideoiles.Add(new PlayItem() { filePath = @"C:\Users\Роман Коновал\Desktop\HW\LabRob6 .2\LabRob6 .2\bin\Debug\Media", name = "Keichi Okabe - Song of the ancients atonement" });
            AudioVideoiles.Add(new PlayItem() { filePath = @"C:\Users\Роман Коновал\Desktop\HW\LabRob6 .2\LabRob6 .2\bin\Debug\Media", name = "Shrek.II.2004.RUS.BDRip.XviD.AC3.-HQ-ViDEO" });
            AudioVideoiles.Add(new PlayItem() { filePath = @"C:\Users\Роман Коновал\Desktop\HW\LabRob6 .2\LabRob6 .2\bin\Debug\Media", name = "Yugo Kanno - il vento d oro mp3.mn" });


            var FileCollection = new ObservableCollection<IMedia>();
            Console.WriteLine(AudioVideoiles[0].name);
            Console.WriteLine(AudioVideoiles[1].name);
            Console.WriteLine(AudioVideoiles[2].name);
            Console.WriteLine("Choose the file: 1, 2, 3");
            var File = Console.ReadLine();

                
                switch (File)
                {
                    case "1":
                        Console.WriteLine("Choose sattus: Record, Stop, Play, Pause");
                        string satusmp3 = Console.ReadLine();
                        Mp3 myMp3 = new Mp3();
                        if (satusmp3 == "Record")
                        {
                            myMp3.Record();
                        }
                        else if (satusmp3 == "Pause")
                        {
                            myMp3.Pause();
                        }
                        else if (satusmp3 == "Stop")
                        {
                            myMp3.Stop();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Choose sattus: Record, Stop, Play, Pause");
                        string satuswav = Console.ReadLine();
                        Wav myWav = new Wav();
                        if (satuswav == "Record")
                        {
                            myWav.Record();
                        }
                        else if (satuswav == "Pause")
                        {
                            myWav.Pause();
                        }
                        else if (satuswav == "Stop")
                        {
                            myWav.Stop();
                        }
                        else if (satuswav == "Play")
                        {
                            myWav.Play();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Choose sattus: Record, Stop, Play, Pause");
                        string satusmkv = Console.ReadLine();
                        Mkv myMkv = new Mkv();
                        if (satusmkv == "Pause")
                        {
                            myMkv.Pause();
                        }
                        else if (satusmkv == "Stop")
                        {
                            myMkv.Stop();
                        }
                        else if (satusmkv == "Play")
                        {
                            myMkv.Play();
                        }
                        break;
                }
            Console.ReadKey();
        }
            
    }

   
}
