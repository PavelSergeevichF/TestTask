using System;
using GeometryMath;

namespace TestWorkTask
{
    class Program
    {
        public float Radius = 10;
        public Triangle Long= new Triangle();
        public float a = 8f;
        public float b = 4f;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SetLongTriangle(program.a, program.b);
            float AreaСircle = MathematicalGeometry.CalculateAreaCircle(program.Radius);

            Console.WriteLine($"Проверка работы расчета площади круга {program.CeckAriaCircle(program.Radius, AreaСircle)}");
            Console.WriteLine($"Проверка работы расчета площади треугольника {program.CeckAriaTriangle(program.Long)}");
            float a, b, c;
            program.Long.GetTriangle(out a, out b, out c);
            Console.WriteLine($"Проверка работы метода является ли треугольник прямоугольным {MathematicalGeometry.CheckingForRightTriangle(a, b, c)}");
        }
        private void SetLongTriangle( float a, float b)
        {
            Long.SetTriangle(a,b, (float)Math.Sqrt(a*a+b*b));
        }
        private bool CeckAriaCircle(float R, float Aria)
        {
            int answer1 = (int)(R * R * Math.PI * 100);
            int answer2 = (int)(Aria * 100);
            return answer1 == answer2 ? true : false;
        }
        private bool CeckAriaTriangle(Triangle triangle)
        {
            float a, b, c;
            triangle.GetTriangle(out a,out b,out c);
            int answer1 = (int)(a*b/2*100);
            int answer2 = (int)(MathematicalGeometry.AreaTriangle(a, b, c)*100);
            return ((answer1 - answer2) > -2 && (answer1 - answer2) < 2) ? true : false;
        }

    }
    struct Triangle
    {
        private float _a;
        private float _b;
        private float _c;
        public void SetTriangle(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public void GetTriangle(out float a, out float b, out float c)
        {
            a = _a;
            b = _b;
            c = _c;
        }
    }
}
