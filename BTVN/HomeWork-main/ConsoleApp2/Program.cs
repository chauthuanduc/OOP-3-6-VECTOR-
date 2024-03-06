using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    1. Bổ sung phương thức tính module vào IVector (Interface) và triển khai phương thức này trong 2 lớp Vector2D và Vector3D
    2. Bổ sung toán tử ~ để chuyển đổi Vector2D thành Vector3D và ngược lại (Vector2D => 3D : z = 0; Vector3D => 2D: bỏ z)
    3. Triển khai hàm Main qua list IVector với các tọa độ sinh ngẫu nhiên, có thể là vector 2D hoặc 3D thông qua 1 phương thức gọi là CreateVector
    4.
    5.
 */
namespace ConsoleApp2
{
    internal class Program
    {
        static void CreateVector(List<IVector> VectorList)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r.Next(-10, 10);
                int y = r.Next(-10, 10);
                int z = r.Next(-10, 10);
                if (r.Next(0, 2) == 1)
                {
                    VectorList.Add(new Vector2D(x, y));
                }
                else
                {
                    VectorList.Add(new Vector3D(x, y, z));
                }
            }
        }
        static void PrintVector(List<IVector> VectorList)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VectorList[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Các vector ngẫu nhiên được tạo ở đây");
            List<IVector> ListVector = new List<IVector>();
            CreateVector(ListVector);
            PrintVector(ListVector);
            Console.WriteLine("==================================================================");

            // Bổ sung phương thức tính module
            Console.WriteLine("Module của các vector:");
            foreach (var vector in ListVector)
            {
                Console.WriteLine(Math.Round(vector.Module(), 2));
            }
            Console.WriteLine("==================================================================");

            // Bổ sung toán tử ~
            Console.WriteLine(">>>>>>>Chuyển đổi Vector2D thành Vector3D và ngược lại<<<<<<<");
            Console.WriteLine("                                                                   ");
            foreach (var vector in ListVector)
            {
                if (vector is Vector2D)
                {
                    Vector3D vector3D = ~((Vector2D)vector);
                    Console.WriteLine($"Vector2D: {vector} => Vector3D: {vector3D}");
                }
                else if (vector is Vector3D)
                {
                    Vector2D vector2D = ~((Vector3D)vector);
                    Console.WriteLine($"Vector3D: {vector} => Vector2D: {vector2D}");
                }
            }
        }
    }
}

