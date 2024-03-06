using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vector2D : IVector
    {
        private int x, y;
        public Vector2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2D operator + (Vector2D a, Vector2D b)
        {
            if(a is Vector2D a1 && b is Vector2D b1)
            {
                return new Vector2D(a1.x + b1.x, a1.y + b1.y);
            }
            throw new ArgumentException();
        }
        public static int operator * (Vector2D a, Vector2D b)
        {
            if (a is Vector2D a1 && b is Vector2D b1)
            {
                return a1.x * b1.x + a1.y * b1.y;
            }
            throw new ArgumentException();
        }
        public override string ToString()
        {
            string OutPut = $"(x = {x}, y = {y})";
            return OutPut;
        }

        public double Module()
        {
            return Math.Sqrt(x*x + y * y);
        }

        public static Vector3D operator ~(Vector2D vector)
        {
            return new Vector3D(vector.x, vector.y, 0);
        }
    }
}
