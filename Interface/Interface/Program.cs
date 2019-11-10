using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
namespace Interface
{
    //class Program
    //{
    //  static void Main(string[] args)
    //    {
    //        SoundPlayer player = new SoundPlayer();
    //        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\yourmusic.wav";
    //        player.Play();
    //    }
    //}
    // For the pauses, you can use the threading:

    class BeepMethodSample
    {
        [STAThread]
        static void Main()
        {
           // IPlaylabel music1 = null;
           // IRecordable music2 = null;
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ResetColor();
            // First, let's determine the keys and the corresponding frequencies:
            // I have found these frequency values somewhere on the web with Google,
            // but I don't remember where exactly.
            int C = 264;
            int D = 297;
            int E = 330;
            int F = 352;
            int G = 396;
            int A = 440;
            int Bb = 466;
            int B = 495;
            int C2 = 528;

            // Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
            int note = 1000;
            int half = 1000 / 2;
            int quarter = 1000 / 4;
            int eighth = 1000 / 8;

            // Now we can already "sing" a scale to warm up:
            Console.WriteLine("Warming up the voice ...");
            Thread.Sleep(2000);
            Console.Beep(C, quarter);
            Console.Beep(D, quarter);
            Console.Beep(E, quarter);
            Console.Beep(F, quarter);
            Console.Beep(G, quarter);
            Console.Beep(A, quarter);
            Console.Beep(B, quarter);
            Console.Beep(C2, half);
            Thread.Sleep(quarter);
            Console.Beep(C2, quarter);
            Console.Beep(B, quarter);
            Console.Beep(A, quarter);
            Console.Beep(G, quarter);
            Console.Beep(F, quarter);
            Console.Beep(E, quarter);
            Console.Beep(D, quarter);
            Console.Beep(C, half);

            ConsoleColor background2 = Console.BackgroundColor;
            ConsoleColor foreground2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ResetColor();

            // Let's sing happy birthday, just because Ged Mead turned 60 some days ago:
            Console.WriteLine("We're warmed up, so then let's sing ...");
            Thread.Sleep(2000);
            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(E, note);
            Thread.Sleep(quarter);

            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);

            ConsoleColor background3 = Console.BackgroundColor;
            ConsoleColor foreground3 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ResetColor();

            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(C2, half);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, half);
            Thread.Sleep(eighth);
            Console.Beep(D, note);
            ConsoleColor background4 = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ResetColor();

            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);
            ConsoleColor background5 = Console.BackgroundColor;
            ConsoleColor foreground5 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ResetColor();

            // Some random sounds that should remind you of some old, old games:
            Console.WriteLine("Perhaps you prefer something from the" +
                " late 70's or early 80's ...");
            Thread.Sleep(2000);
            Random randomSounds = new Random();
            for (int index = 0; index < 100; index++)
            {
                Console.Beep(randomSounds.Next(1000) + 100, 100);
            }
        }
    }
}

