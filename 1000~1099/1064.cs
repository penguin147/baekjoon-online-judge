/*
문제
평행사변형은 평행한 두 변을 가진 사각형이다.
세 개의 서로 다른 점이 주어진다. A(xA,yA), B(xB,yB), C(xC,yC)
이때, 적절히 점 D를 찾아서 네 점으로 평행사변형을 만들면 된다.
이때, D가 여러 개 나올 수도 있다.
만들어진 모든 사각형 중 가장 큰 둘레 길이와 가장 작은 둘레 길이의 차이를 출력하는 프로그램을 작성하시오.
만약 만들 수 있는 평행사변형이 없다면 -1을 출력한다.

입력
첫째 줄에 xA yA xB yB xC yC가 주어진다.
모두 절댓값이 5000보다 작거나 같은 정수이다.

출력
첫째 줄에 문제의 정답을 출력한다.
절대/상대 오차는 10-9까지 허용한다.
*/


string[] input = new string[6];
double[] length = new double[3];
double[] each_case = new double[3];
input = Console.ReadLine().Split(' ');
int x1, x2, x3, y1, y2, y3;

x1 = Convert.ToInt32(input[0]);
y1 = Convert.ToInt32(input[1]);
x2 = Convert.ToInt32(input[2]);
y2 = Convert.ToInt32(input[3]);
x3 = Convert.ToInt32(input[4]);
y3 = Convert.ToInt32(input[5]);

if(Math.Abs(y1 - y2) * Math.Abs(x1 - x3) == Math.Abs(x1 - x2) * Math.Abs(y1 - y3))
{
    Console.WriteLine("-1.0");
}
else
{
    length[0] = Calc.Distance(x1, y1, x2, y2);
    length[1] = Calc.Distance(x1, y1, x3, y3);
    length[2] = Calc.Distance(x2, y2, x3, y3);

    each_case[0] = 2 * length[0] + 2 * length[1];
    each_case[1] = 2 * length[0] + 2 * length[2];
    each_case[2] = 2 * length[1] + 2 * length[2];

    Console.WriteLine(Calc.Max_min(each_case));
}

class Calc
{
    public static double Distance(int x1, int y1, int x2, int y2)
    {
        int x, y;
        double result;
        
        x = x2 - x1;
        y = y2 - y1;

        x = x * x;
        y = y * y;

        result = Math.Sqrt(x + y);
        return result;
    }

    public static double Max_min(double[] each_case)
    {
        double max = each_case[0], min = each_case[0];
        
        for(int i = 1; i < 3; i++)
        {
            if(max < each_case[i])
            {
                max = each_case[i];
            }
            if(min > each_case[i])
            {
                min = each_case[i];
            }
        }
        return max - min;
    }
}
