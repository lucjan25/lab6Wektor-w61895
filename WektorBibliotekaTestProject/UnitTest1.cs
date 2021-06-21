using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WektorBiblioteka;

namespace WektorBibliotekaTestProject
{
    [TestClass]
    public class WektorUnitTest1
    {
        [TestMethod]
        public void TestKonstruktoraWlasnosci()
        {
            double x = 1;
            double y = 2;
            double z = 3;

            Wektor w = new Wektor(x, y, z);

            double u_x = w.WX;
            double u_y = w.WY;
            double u_z = w.WZ;

            Assert.AreEqual(x, u_x, "Niezgodnosc w X");
            Assert.AreEqual(y, u_y, "Niezgodnosc w Y");
            Assert.AreEqual(z, u_z, "Niezgodnosc w Z");
        }
        [TestMethod]
        public void TestDlugosc()
        {
            Wektor w = new Wektor(3, 4, 12);

            Assert.AreEqual(13, w.Dlugosc);
        }
        [TestMethod]
        public void TestOperatorow()
        {
            Wektor w1 = new Wektor(1, 2, 3);
            Wektor w2 = new Wektor(1, 5, 7);
            double d = 15.5;

            Assert.AreEqual(new Wektor(2, 7, 10), w1 + w2, "Niepowodzenie przy sumie");
            Assert.AreEqual(new Wektor(0, -3, -4), w1 - w2, "Niepowodzenie przy roznicy");
            Assert.AreEqual(new Wektor(-1, -5, -7), -w2, "Niepowodzenie przy odwrotnosci");
            Assert.AreEqual(new Wektor(1 / 15.5, 2 / 15.5, 3 / 15.5), w1 / d, "Niepowodzenie przy ilorazie");
            Assert.AreEqual(32, Wektor.Dot(w1, w2), "Niepowodzenie przy iloczynie skalarnym");
            Assert.AreEqual(new Wektor(-1, -4, 3), Wektor.Cross(w1, w2), "Niepowodzenie przy iloczynie wektorowym");
            Assert.AreEqual(new Wektor(15.5, 31, 46.5), w1 * d, "Niepowodzenie przy mnozeniu przez skalar");
        }
        [TestMethod]
        public void TestPorownania()
        {
            Wektor w1 = new Wektor(1, 2, 3);
            Wektor w2 = new Wektor(1, 5, 7);
            Wektor w3 = new Wektor(1, 2, 3);

            Assert.AreEqual(1, w2.CompareTo(w1), "Niepowodzenie przy CompareTo");
            Assert.AreEqual(true, w1 == w3, "Niepowodzenie przy sprawdzaniu rownosci");
        }
        [TestMethod]
        public void TestProstopadlosc()
        {
            Wektor w1 = new Wektor(1, -1, 3);
            Wektor w2 = new Wektor(3, 3, 0);

            Assert.AreEqual(true, Wektor.Prostopadle(w1, w2), "Niepowodzenie przy sprawdzaniu prostopadlosci");
        }
    }
}
