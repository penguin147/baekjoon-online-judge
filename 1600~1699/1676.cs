/*
문제
N!에서 뒤에서부터 처음 0이 아닌 숫자가 나올 때까지 0의 개수를 구하는 프로그램을 작성하시오.

입력
첫째 줄에 N이 주어진다. (0 ≤ N ≤ 500)

출력
첫째 줄에 구한 0의 개수를 출력한다.
*/


int N;

N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Calc.Count_zeros(N));


class Calc
{
    public static int Count_zeros(int N)
    {
        int result = 0;
        int tmp = 1;
        for(int i = 5; i <= N; i += 5)
        {
            tmp = i;
            while(tmp % 5 == 0)
            {
                tmp /= 5;
                result++;
            }
        }
        return result;
    }
}