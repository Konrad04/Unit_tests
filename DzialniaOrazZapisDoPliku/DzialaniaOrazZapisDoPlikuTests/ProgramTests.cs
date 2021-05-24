using DzialniaOrazZapisDoPliku;
using NUnit.Framework;
using System.Collections.Generic;

namespace DzialaniaOrazZapisDoPlikuTests
{
    public class ProgramTests
    {
        private Program program;
        [SetUp]
        public void SetUp()
        {
            program = new Program();

        }

        [Test]
        [TestCase(11, 2, 1)]
        [TestCase(2, 4, 2)]
        [TestCase(28, 4, 4)]
        [TestCase(18, 6, 6)]
        public void NWD_ReturnTheBiggestDivider(int x, int y, int z)
        {
            var result = program.NWD(x, y);
            Assert.That(result, Is.EqualTo(z));

        }


        [Test]
        [TestCase(3, 1, 3)]
        [TestCase(4, 20, 20)]
        [TestCase(7, 11, 77)]
        [TestCase(3, 5, 15)]
        public void NWW_ReturnTheSmallestMultiple(int x, int y, int z)
        {
            var result = program.NWW(x, y);
            Assert.That(result, Is.EqualTo(z));

        }


        [Test]
        [TestCase(1221, true)]
        [TestCase(223, false)]
        [TestCase(288, false)]
        [TestCase(1881, true)]
        public void czyPalindrom_SingleWord_Tests(int x, bool y)
        {
            
            var result = program.czyPalindrom(x);
            Assert.That(result, Is.EqualTo(y));

        }

        [Test]
        [TestCase(652256)]
        [TestCase(1111)]

        public void Check_If_Add_PalindromWord(int liczba)
        {

            List<int> tablicaLiczb = new List<int>();

            Program.addToTable(tablicaLiczb, liczba);
            Assert.IsNotEmpty(tablicaLiczb);
        }

        [Test]
        [TestCase(789032)]
        [TestCase(1213)]
        public void Check_If_DontAdd_NotPalindromWord(int liczba)
        {

            List<int> tablicaLiczb = new List<int>();

            Program.addToTable(tablicaLiczb, liczba);
            Assert.IsEmpty(tablicaLiczb);
        }


        [Test]

        [TestCase("C:\\Users\\Konrad\\Desktop", "Plik01", "C:\\Users\\Konrad\\Desktop\\Plik01")]
        [TestCase("C:\\Users\\Konrad\\Desktop\\", "Plik01", "C:\\Users\\Konrad\\Desktop\\Plik01")]
        [TestCase("C:\\Users", "Plik02", "C:\\Users\\Plik02")]
        [TestCase("C:\\Users\\", "Plik02", "C:\\Users\\Plik02")]
        public void czyPalindrom_SingleWord_Tests(string sciezka, string plik, string calaSciezka)
        {
        
            var result = program.UtworzenieScie¿ki(sciezka, plik);
            Assert.AreEqual(calaSciezka, result);


        }
    }
}