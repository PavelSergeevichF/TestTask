using System;

namespace GeometryMath
{
    public static class MathematicalGeometry
    {
        public static float CalculateAreaCircle( float radius)
        {
            return radius*radius*(float)Math.PI; 
        }
        public static float AreaTriangle(float a, float b, float c)
        {
            float halfPerimeter = (a+b+c) / 2;
            return (float)Math.Sqrt(halfPerimeter*(halfPerimeter-a) *(halfPerimeter-b) *(halfPerimeter-c));
        }
        public static bool CheckingForRightTriangle(float a, float b, float c)
        {
            bool answer = false;
            float halfPerimeter = (a + b + c) / 2;
            float Area = (float)(Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c))*100);
            float[] AreaVar =
            {
                100*a * b / 2,
                100*b * c / 2,
                100*c * a / 2
            };
            foreach(var answerArea in AreaVar)
            {
                int result1 = (int)Area;
                int result2 = (int)answerArea;
                if ((result1 - result2) > -2 && (result1 - result2) < 2)
                {
                    answer = true;
                }
            }
            return answer;
        }
    }
}
