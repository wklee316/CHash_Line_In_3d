using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CHash_Line_In_3d
{

    public class Line_In_3D
    {


        public double distance;
        public double x, y, z;
        public double verDegree, horDegree;

        public void findPosition()
        {
            Console.Write("두 점 사이의 거리값을 입력하세요 : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("수평각을 입력하세요(도 단위로 입력) : ");
            horDegree = Convert.ToDouble(Console.ReadLine());
            Console.Write("수직각을 입력하세요(도 단위로 입력) : ");
            verDegree = Convert.ToDouble(Console.ReadLine());

            horDegree = horDegree * Math.PI / 180.0f;
            verDegree = verDegree * Math.PI / 180.0f;

            x = distance * Math.Sin(verDegree) * Math.Cos(horDegree);
            y = distance * Math.Sin(horDegree) * Math.Sin(verDegree);
            z = distance * Math.Cos(verDegree);

            Console.WriteLine($"나머지 점의 좌표는 ({x},{y},{z})입니다.");
        }

        public void RFindPosition()
        {
            Console.WriteLine("나머지 한점의 좌표를 입력하세요 : ");
            Console.Write("x : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z : ");
            z = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(x * x + y * y + z * z);

            horDegree = (y/z) *180.0f/Math.PI;
            verDegree = (y/x) * 180.0f / Math.PI;
            Console.WriteLine($"이 선분의 길이는 {distance}입니다.");
            Console.WriteLine($"수평각은  {horDegree}° 이고 수직각은 {verDegree}°입니다.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Line_In_3D line3D = new Line_In_3D();
            int choose = 1;
            while(choose != 0)
            {
                Console.Write("1. 나머지 점의 좌표 구하기    2. 수직, 수평각과 거리 구하기 (종료 : 0) : ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: line3D.findPosition(); break;
                    case 2: line3D.RFindPosition(); break;
                }
            }
        }
    }
}
