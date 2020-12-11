using System;
using PointLib;

namespace FormsApp
{
    [Serializable]
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D() : base()
        {
            Z = rnd.Next(10);
        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override double Metric()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()
        {
            return string.Format($"({X} , {Y}, {Z})");
        }
    }
}

