using System;
using System.Collections.Generic;
using System.IO;

namespace DzialniaOrazZapisDoPliku
{
    public class Program
    {
        public int liczbaA, liczbaB;
        public int liczbaNWW;

        public int NWD(int liczbaA, int liczbaB)
        {
            while (liczbaA != liczbaB)
            {
                if (liczbaA > liczbaB)
                    liczbaA = liczbaA - liczbaB;
                else
                    liczbaB = liczbaB - liczbaA;

            }

            return liczbaA;

        }

        public int NWW(int liczbaA, int liczbaB)
        {
            liczbaNWW = liczbaA * liczbaB / NWD(liczbaA, liczbaB);
            return liczbaNWW;
        }


        public bool czyPalindrom(int liczbaNWW)
        {

            int dlugoscCiagu = liczbaNWW.ToString().Length;

            int liczbaIteracji = dlugoscCiagu / 2;

            for (int i = 0; i < liczbaIteracji; i++)
            {
                int indeksPorownywanejCyfry = dlugoscCiagu - 1 - i;

                if (liczbaNWW.ToString()[i] != liczbaNWW.ToString()[indeksPorownywanejCyfry])
                {
                    return false;
                }
            }
            return true;

        }


        public static void addToTable(List<int> tablicaLiczb, int liczbaNWW)
        {
            Program palindrom = new Program();
            if (palindrom.czyPalindrom(liczbaNWW))
            {
                tablicaLiczb.Add(liczbaNWW);

            }
        }

        public string UtworzenieScieżki(string sciezkaDoKatalogu, string nazwaPliku)
        {
            string calaSciezka;

            if (sciezkaDoKatalogu.EndsWith("\\"))
            {
                calaSciezka = sciezkaDoKatalogu + nazwaPliku;

            }
            else
            {
                calaSciezka = sciezkaDoKatalogu + '\\' + nazwaPliku;
            }
            return calaSciezka;
        }

        public void utworzenieKatalogu(string sciezkaDoKatalogu)
        {
            DirectoryInfo katalog = Directory.CreateDirectory(sciezkaDoKatalogu);
        }

        public void zapisDoKatalogu(List<string> tablicaLiczb, string sciezkaDoKatalogu, string nazwaPliku)
        {
            File.WriteAllLines(UtworzenieScieżki(sciezkaDoKatalogu, nazwaPliku), tablicaLiczb);
        }

        public void odczytZKatalogu(string tekstDoOdczytu, string sciezkaDoKatalogu, string nazwaPliku)
        {
            tekstDoOdczytu = File.ReadAllText(UtworzenieScieżki(sciezkaDoKatalogu, nazwaPliku));
        }

    }
}
