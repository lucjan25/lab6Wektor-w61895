using System;
using System.Collections.Generic;

namespace WektorBiblioteka
{
    public struct Wektor : IComparable<Wektor>
    {
        public Wektor(double wx = 0, double wy = 0, double wz = 0) : this()
        {
            this.WX = wx;
            this.WY = wy;
            this.WZ = wz;
        }

        #region Wlasciwosc
        public double WX { get; set; }
        public double WY { get; set; }
        public double WZ { get; set; }
        public double Dlugosc
        {
            get 
            { 
                return Math.Sqrt(Math.Pow(WX, 2) + Math.Pow(WY, 2) + Math.Pow(WZ, 2)); 
            }
        }
        #endregion;

        #region Operatory arytmetyczne
        public static Wektor operator -(Wektor w)
        {
            return new Wektor(-w.WX, -w.WY, -w.WZ);
        }
        public static Wektor operator +(Wektor w)
        {
            return w;
        }
        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.WX + w2.WX, w1.WY + w2.WY, w1.WZ + w2.WZ);
        }
        public static Wektor operator -(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.WX - w2.WX, w1.WY - w2.WY, w1.WZ - w2.WZ);
        }
        public static double Dot(Wektor w1, Wektor w2)
        {
            return w1.WX * w2.WX + w1.WY * w2.WY + w1.WZ * w2.WZ;
        }
        public static Wektor Cross(Wektor w1, Wektor w2)
        {
            return new Wektor((w1.WY * w2.WZ - w1.WZ * w2.WY), (w1.WZ * w2.WX - w1.WX * w2.WZ), (w1.WX * w2.WY - w1.WY * w2.WX));
        }
        public static Wektor operator ^(Wektor w1, Wektor w2)
        {
            return Cross(w1, w2);
        }
        public static Wektor operator *(double d, Wektor w)
        {
            return new Wektor(w.WX * d, w.WY * d, w.WZ * d);
        }
        public static Wektor operator *(Wektor w, double d)
        {
            return d * w;
        }
        public static Wektor operator /(Wektor w, double d)
        {
            return new Wektor(w.WX / d, w.WY / d, w.WZ / d);
        }
        public static Wektor Srodek(List<(double,Wektor)> LW)
        {
           double swX = 0, swY = 0, swZ = 0, swW = 0;
            
            foreach ((double,Wektor) krotka in LW)
            {
                swW += krotka.Item1;
                swX += krotka.Item2.WX;
                swY += krotka.Item2.WY;
                swZ += krotka.Item2.WZ;
            }
            return new Wektor(swX / swW, swY / swW, swZ / swW);
            
        }
        #endregion

        #region Operatory porownania
        public static bool operator ==(Wektor w1, Wektor w2)
        {
            return (w1.WX == w2.WX) && (w1.WY == w2.WY) && (w1.WZ == w2.WZ);
        }
        public static bool operator !=(Wektor w1, Wektor w2)
        {
            return !(w1 == w2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Wektor)) return false;
            Wektor w = (Wektor)obj;
            return (this == w);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
               
                hash = hash * 23 + WX.GetHashCode();
                hash = hash * 23 + WY.GetHashCode();
                hash = hash * 23 + WZ.GetHashCode();
                return hash;
            }
        }
        public static bool Prostopadle(Wektor w1, Wektor w2)
        {
            return (Dot(w1, w2) == 0);
        }

        public int CompareTo(Wektor other)
        {
            double roznica = this.Dlugosc - other.Dlugosc;
            if (roznica != 0) roznica /= Math.Abs(roznica);
            return (int)roznica;
        }
        #endregion
    }
}
