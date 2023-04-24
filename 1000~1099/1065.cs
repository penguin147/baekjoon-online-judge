/*
문제
어떤 양의 정수 X의 각 자리가 등차수열을 이룬다면, 그 수를 한수라고 한다.
등차수열은 연속된 두 개의 수의 차이가 일정한 수열을 말한다.
N이 주어졌을 때, 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력하는 프로그램을 작성하시오. 

입력
첫째 줄에 두 정수 A와 B가 주어진다.
(1 <= A,B <= 1,000,000)첫째 줄에 1,000보다 작거나 같은 자연수 N이 주어진다.

출력
첫째 줄에 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력한다.
*/


int N, result = 0;
string num;

N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    num = i.ToString();
    if (Calc.Han_num(num))
    {
        result++;
    }
}

Console.WriteLine(result);

class Calc
{
    public static bool Han_num(string num)
    {
        if (num.Length < 3)
        {
            return true;
        }
        else
        {
            int diff = Convert.ToInt32(num[1]) - Convert.ToInt32(num[0]);
            for (int i = 2; i < num.Length; i++)
            {
                if(Convert.ToInt32(num[i]) - Convert.ToInt32(num[i - 1]) != diff)
                {
                    return false;
                }
            }
            return true;
        }
    }
}