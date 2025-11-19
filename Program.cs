
using System;
using System.Numerics;
using GeoVector;

class Program
{
    static void Problem8()
    {
        // 실제 문제에는 방향 벡터로서 표기되어 있지 않으나, 문제 풀이를 위해
        // 문제 상황에 맞는 임시 값 부여
        geovector.Vector2 a = new geovector.Vector2(-1, -3);
        geovector.Vector2 b = new geovector.Vector2(1, -3);

        // a와 b를 2:1로 내분
        geovector.Vector2 ad = geovector.Vector2.InternalDivision(a, b, 2, 1);
        geovector.Vector2 ae = ad * 3/4;

        Console.WriteLine("8번 문제 답은 " + ae.ToString());
        Console.WriteLine("실제 답 : " + (a/4 + b/2).ToString());
    }
    static void Problem12()
    {
        geovector.Vector2 a = new geovector.Vector2(1, -2);
        geovector.Vector2 b = new geovector.Vector2(-2, 2);
        // *을 기준 좌변은 a 벡터, 그리고 우변은 3xa - 2xb를 계산한 벡터로,
        // *으로 벡터와 벡터를 계산 할경우 내적을 계산하게 됨.
        double result = a * (3 * a - 2 * b);
        Console.WriteLine("12번 문제 답은 " + result.ToString());
        Console.WriteLine("실제 답 : " + 27.ToString());
    }
    static void Main(string[] args)
    {
        Problem8();
        Problem12();
    }
}
