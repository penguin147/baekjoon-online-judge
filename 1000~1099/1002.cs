/*
문제
조규현과 백승환은 터렛에 근무하는 직원이다.
하지만 워낙 존재감이 없어서 인구수는 차지하지 않는다.
다음은 조규현과 백승환의 사진이다.
이석원은 조규현과 백승환에게 상대편 마린(류재명)의 위치를 계산하라는 명령을 내렸다.
조규현과 백승환은 각각 자신의 터렛 위치에서 현재 적까지의 거리를 계산했다.
조규현의 좌표 (x1, y1)와 백승환의 좌표 (x2, y2)가 주어지고, 조규현이 계산한 류재명과의 거리 r1과 백승환이 계산한 류재명과의 거리 r2가 주어졌을 때, 류재명이 있을 수 있는 좌표의 수를 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 테스트 케이스의 개수 T가 주어진다.
각 테스트 케이스는 다음과 같이 이루어져 있다.
한 줄에 x1, y1, r1, x2, y2, r2가 주어진다.
x1, y1, x2, y2는 -10,000보다 크거나 같고, 10,000보다 작거나 같은 정수이고, r1, r2는 10,000보다 작거나 같은 음이 아닌 정수이다.

출력
각 테스트 케이스마다 류재명이 있을 수 있는 위치의 수를 출력한다.
만약 류재명이 있을 수 있는 위치의 개수가 무한대일 경우에는 -1을 출력한다.
*/


string[] input = new string[6];
int T;
int d1, d2, d3;

T = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < T; i++)
{
    input = Console.ReadLine().Split(' ');
    d1 = Calc.Distance(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]),
        Convert.ToInt32(input[3]), Convert.ToInt32(input[4]));

    d2 = Convert.ToInt32(input[2]) + Convert.ToInt32(input[5]);
    d2 = d2 * d2;


    if(Convert.ToInt32(input[2]) > Convert.ToInt32(input[5]))
    {
        d3 = Convert.ToInt32(input[2]) - Convert.ToInt32(input[5]);
    }
    else
    {
        d3 = Convert.ToInt32(input[5]) - Convert.ToInt32(input[2]);
    }
    d3 = d3 * d3;

    if (d1 < d3 || d2 < d1 || (d1 == 0 && input[2] != input[5]))
    {
        Console.WriteLine("0");
    }
    else if (d3 < d1 && d1 < d2)
    {
        Console.WriteLine("2");
    }
    else if (d1 == 0 && d3 == 0)
    {
        Console.WriteLine("-1");
    }
    else if (d2 == d1 || d3 == d1)
    {
        Console.WriteLine("1");
    }

          
}


class Calc
{
    public static int Distance(int x1, int y1, int x2, int y2)
    {
        int x, y, result;
        x = x2 - x1;
        y = y2 - y1;

        x = x * x;
        y = y * y;

        result = x + y;
        return result;
    }
}
