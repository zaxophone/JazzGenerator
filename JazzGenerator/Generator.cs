using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Threading;
using System.Threading.Tasks;

namespace JazzGenerator
{
    class Generator
    {
        /// <summary>
        /// Generates freestyle jazz based on a selection of files.
        /// </summary>
        public static void GenerateJazz()
        {
            string dir = Directory.GetCurrentDirectory();

            string currentLeadIDir = (dir + "\\Lead");

            string currentChordsIDir = (dir + "\\Chords");

            string currentBassIDir = (dir + "\\Bass");

            string currentDrumsDir = (dir + "\\Drums");

            Directory.CreateDirectory(currentDrumsDir);

            Directory.CreateDirectory(currentBassIDir);

            Directory.CreateDirectory(currentChordsIDir);

            Directory.CreateDirectory(currentLeadIDir);

            string[] drumFilesDir = Directory.GetFiles(currentDrumsDir);
            if (drumFilesDir.Length == 0)
            {
                error newError = new error();
                newError.Activate();
                Thread.Sleep(2000);
            }
            string[] bassFilesDir = Directory.GetFiles(currentDrumsDir);
            if (bassFilesDir.Length == 0)
            {
                error newError = new error();
                newError.Activate();
                Thread.Sleep(2000);
            }
            string[] chordsFilesDir = Directory.GetFiles(currentDrumsDir);
            if (chordsFilesDir.Length == 0)
            {
                error newError = new error();
                newError.Activate();
                Thread.Sleep(2000);
            }
            string[] leadFilesDir = Directory.GetFiles(currentDrumsDir);
            if (leadFilesDir.Length == 0)
            {
                error newError = new error();
                newError.Activate();
                Thread.Sleep(2000);
            }
            MediaPlayer MediaPlayer1 = new MediaPlayer();
            MediaPlayer MediaPlayer2 = new MediaPlayer();
            MediaPlayer MediaPlayer3 = new MediaPlayer();
            MediaPlayer MediaPlayer4 = new MediaPlayer();

            if (Checked.LeadIsOn) { GenerateLead(); }
            if (Checked.DrumsIsOn) { GenerateDrums(); }
            if (Checked.ChordsIsOn) { GenerateChords(); }
            if (Checked.BassIsOn) { GenerateBass(); }
            void GenerateDrums()
            {
                var rand = new Random();
                var drumFiles = Directory.GetFiles(currentDrumsDir);
                string rnFile = drumFiles[rand.Next(drumFiles.Length)];
                MediaPlayer1.Open(new Uri(rnFile));
                MediaPlayer1.Play();
            }
            MediaPlayer1.MediaEnded += delegate (object o, EventArgs a)
            {
                GenerateDrums();
            };
            void GenerateBass()
            {
                var rand = new Random();
                var bassFiles = Directory.GetFiles(currentBassIDir);
                string rnFile = bassFiles[rand.Next(bassFiles.Length)];
                MediaPlayer2.Open(new Uri(rnFile));
                MediaPlayer2.Play();
            }
            MediaPlayer2.MediaEnded += delegate (object o, EventArgs a)
            {
                GenerateBass();
            };
            void GenerateChords()
            {
                var rand = new Random();
                var chordFiles = Directory.GetFiles(currentChordsIDir);
                string rnFile = chordFiles[rand.Next(chordFiles.Length)];
                MediaPlayer3.Open(new Uri(rnFile));
                MediaPlayer3.Play();
            }
            MediaPlayer3.MediaEnded += delegate (object o, EventArgs a)
            {
                GenerateChords();
            };
            void GenerateLead()
            {
                var rand = new Random();
                var leadFiles = Directory.GetFiles(currentLeadIDir);
                string rnFile = leadFiles[rand.Next(leadFiles.Length)];
                MediaPlayer4.Open(new Uri(rnFile));
                MediaPlayer4.Play();
            }
            MediaPlayer4.MediaEnded += delegate (object o, EventArgs a)
            {
                GenerateLead();
            };
        }
    }
}