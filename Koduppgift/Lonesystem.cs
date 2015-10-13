using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Koduppgift
{
    public partial class Lonesystem : Form
    {
        private class Person
        {
            public string Profession { get; private set; }
            public int EmployementYears { get; private set; }
            public int StartingSalary { get; private set; }
            public int CurrentSalary { get; private set; }

            public Person(string profession, int employementYears, int startingSalary, int currentSalary)
            {
                Profession = profession;
                EmployementYears = employementYears;
                StartingSalary = startingSalary;
                CurrentSalary = currentSalary;
            }

            /// <summary>
            /// Beräkna löneökning per år
            /// </summary>
            /// <returns>Löneökningen per år</returns>
            public int Growth()
            {
                return (CurrentSalary - StartingSalary) / EmployementYears;
            }
        }

        //En yrkesgrupp med medellön och medianlön
        private struct ProfessionCategory
        {
            public string Profession;
            public double Average;
            public double Median;

            public ProfessionCategory(string profession, double average, double median)
            {
                Profession = profession;
                Average = average;
                Median = median;
            }
        };

        private static List<Person> PersonList = new List<Person>();
        private static List<ProfessionCategory> professions = new List<ProfessionCategory>();
        private static DateTime fileReadTime;
        private Thread checkFileThread;
        private delegate void del();
        private del refreshDel;

        public Lonesystem()
        {
            InitializeComponent();
            refreshDel = FillLists;
            checkFileThread = new Thread(CheckFile);
            checkFileThread.IsBackground = true;
            checkFileThread.Start();
        }

        //Körs i bakgrunden och kollar ifall det kommer en ny version av filen, läser in på nytt ifall den har förändrats.
        private void CheckFile()
        {
            while (true)
            {

                if (ReadFile("textfile.txt"))
                {
                    this.Invoke(refreshDel);
                }
                Thread.Sleep(10000);
            }
        }

        private static bool ReadFile(string filename)
        {
            FileInfo fi = new FileInfo(filename);

            if (fileReadTime == null || fi.LastWriteTime.CompareTo(fileReadTime) != 0)
            {
                PersonList.Clear();
                professions.Clear();

                try
                {
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        string line;
                        char[] delim = { '|' };
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] divided = line.Split(delim);

                            Person p = new Person(divided[0], Convert.ToInt32(divided[1]), Convert.ToInt32(divided[2]), Convert.ToInt32(divided[3]));
                            PersonList.Add(p);
                        }
                        fileReadTime = fi.LastWriteTime;
                    }
                    AddProfessions();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem med att läsa fil \n" + ex.Message);
                }
            }
            return false;
        }

        //körs vid inläsning
        private static void AddProfessions()
        {
            var v = (from p
                    in PersonList
                     select p.Profession).Distinct();

            double average, median;

            foreach (string prof in v)
            {
                Average(prof, out average, out median);
                professions.Add(new ProfessionCategory(prof, average, median));
            }

            
        }

        private void Lonesystem_Load(object sender, EventArgs e)
        {

            FillLists();
            
        }

        private void FillLists()
        {
            var prof = from p
                    in professions
                       select p.Profession;

            lbAvg.DataSource = prof.ToList();
            lbGrowth.DataSource = prof.ToList();
            lbIncrease.DataSource = prof.ToList();

        }

        /// <summary>
        /// Beräkna genomsnittslön för ett yrke
        /// </summary>
        /// <param name="profession">Yrke</param>
        /// <param name="average">Double att spara medellön i</param>
        /// <param name="median">Double att spara medianlön i</param>
        private static void Average(string profession, out double average, out double median)
        {
            var v = from p
                    in PersonList
                    orderby p.CurrentSalary
                    where p.Profession == profession
                    select p;

            average = 0;
            int number = v.Count();

            //average salary
            foreach (Person p in v)
            {
                average += p.CurrentSalary;
            }
            average /= number;
            
            //median
            int mid = number / 2;
            median = (number % 2 != 0) ? v.ElementAt(mid).CurrentSalary : (v.ElementAt(mid).CurrentSalary + v.ElementAt(mid - 1).CurrentSalary) / 2;
        }

        /// <summary>
        /// Genomsnittlig tillväxt i lön per år för ett yrke
        /// </summary>
        /// <param name="profession">Yrke</param>
        /// <returns>Ökning</returns>
        private int AverageGrowth(string profession)
        {
            var v = from p
                    in PersonList
                    where p.Profession == profession
                    select p;

            int growth = 0;
            
            foreach (Person p in v)
            {
                growth += p.Growth();
            }

            growth /= v.Count();

            return growth;
        }

        /// <summary>
        /// Beräknar vilka yrken som har störst skillnad i medel- och medianlön
        /// </summary>
        private void Difference()
        {
            string resultAvg;
            professions.OrderBy( (avg) => avg.Average);

            ProfessionCategory best, worst;
            best = professions[0];
            worst = professions[professions.Count - 1];
            resultAvg = "Största skillnaden i genomsnittslön är mellan yrkena " + best.Profession + " och " + worst.Profession + " och skillnaden är: " + (best.Average - worst.Average) + "kr.";

            string resultMed;
            professions.OrderBy((med) => med.Median);

            best = professions[0];
            worst = professions[professions.Count - 1];
            resultMed = "Största skillnaden i medianlön är mellan yrkena " + best.Profession + " och " + worst.Profession + " och skillnaden är: " + (best.Median - worst.Median) + "kr.";

            MessageBox.Show(resultAvg + "\n\n" + resultMed);
        }

        /// <summary>
        /// Beräknar hur stor löneökningen per år måste vara för ett företag för att komma upp i samma medellön som ett annat företag
        /// </summary>
        /// <param name="firstProfession">Första företaget</param>
        /// <param name="secondProfession">Andra företaget</param>
        private void CalculateGrowth(string firstProfession, string secondProfession)
        {
            double firstAverage, secondAverage, med, result;
            int growth;

            Average(firstProfession, out firstAverage, out med);
            Average(secondProfession, out secondAverage, out med);

            if (firstAverage > secondAverage)
            {
                //Ökningen som kommer att ske på 5 år.
                growth = AverageGrowth(firstProfession);
                firstAverage += growth * 5;

                result = (firstAverage - secondAverage) / 5;

                MessageBox.Show("Ökningen per år måste vara: " + result + " för " + secondProfession);
            }
            else
            {
                //Ökningen som kommer att ske på 5 år.
                growth = AverageGrowth(secondProfession);
                secondAverage += growth * 5;

                result = (secondAverage - firstAverage) / 5;

                MessageBox.Show("Ökningen per år måste vara: " + result + " för " + firstProfession);
            }
        }

        /// <summary>
        /// Spara till fil
        /// </summary>
        private void Export()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = ".txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        //Sortera efter lön
                        professions.OrderBy((avg) => (avg.Average));

                        sw.WriteLine("[H]" + professions[0].Profession + "|" + professions[0].Average);
                        sw.WriteLine("[L]" + professions[professions.Count - 1].Profession + "|" + professions[professions.Count - 1].Average);

                        //sortera efter utveckling
                        professions.OrderBy((prof) => (AverageGrowth(prof.Profession)));

                        sw.WriteLine("[BU]" + professions[0].Profession);
                        sw.WriteLine("[SU]" + professions[professions.Count - 1].Profession);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem med att spara fil \n" + ex.Message);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void bAvg_Click(object sender, EventArgs e)
        {
            //try catch sats på alla knappar utifall att bakgrundstråden laddar in en ny fil samtidigt som användaren trycker på knappen.
            try
            {
                string selected = lbAvg.SelectedItem.ToString();
                double avg, med;

                Average(selected, out avg, out med);
                MessageBox.Show("Genomsnitt: " + avg + "\n" + "Median: " + med);
            }
            catch (Exception)
            {
                MessageBox.Show("Något gick fel, försök igen");
            }
        }

        private void bGrowth_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = lbGrowth.SelectedItem.ToString();
                int growth = AverageGrowth(selected);

                MessageBox.Show("Genomsnittlig tillväxt per år: " + growth);
            }
            catch (Exception)
            {
                MessageBox.Show("Något gick fel, försök igen");
            }
        }

        private void bDifference_Click(object sender, EventArgs e)
        {
            try
            {
                Difference();
            }
            catch (Exception)
            {
                MessageBox.Show("Något gick fel, försök igen");
            }
        }

        private void bIncrease_Click(object sender, EventArgs e)
        {
            try
            {

                var obj = lbIncrease.SelectedItems;

                if (obj.Count != 2)
                {
                    MessageBox.Show("Välj två yrken");
                }
                else
                {
                    CalculateGrowth(obj[0].ToString(), obj[1].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Något gick fel, försök igen");
            }
        }

        



    }
}
