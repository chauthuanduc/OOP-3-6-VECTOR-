using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vector3D : IVector
    {
        private int X, Y, Z;
        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            if (a is Vector3D a1 && b is Vector3D b1)
            {
                return new Vector3D(a1.X + b1.X, a1.Y + b1.Y, a1.Z + b1.Z);
            }
            throw new ArgumentException();
        }
        public static int operator *(Vector3D a, Vector3D b)
        {
            if (a is Vector3D a1 && b is Vector3D b1)
            {
                return a1.X * b1.X + a1.Y * b1.Y + a1.Z * b1.Z;
            }
            throw new ArgumentException();
        }
        public override string ToString()
        {
            string OutPut = $"(x = {X}, y = {Y}, z = {Z})";
            return OutPut;
        }

        public double Module()
        {
            return Math.Sqrt(X*X + Y*Y + Z*Z);
        }

        public static Vector2D operator ~(Vector3D vector)
        {
            return new Vector2D(vector.X, vector.Y);
        }
    }
}
