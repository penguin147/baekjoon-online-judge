/*
음이 아닌 정수를 십진법으로 표기했을 때, 왼쪽에서부터 자리수가 감소할 때, 그 수를 줄어드는 수라고 한다.
예를 들어, 321와 950은 줄어드는 수이고, 322와 958은 아니다.
N번째로 작은 줄어드는 수를 출력하는 프로그램을 작성하시오.
만약 그러한 수가 없을 때는 -1을 출력한다.
가장 작은 줄어드는 수가 1번째 작은 줄어드는 수이다.

입력
N이 주어진다.
N은 1,000,000보다 작거나 같은 자연수이다.

출력
첫째 줄에 N번째 작은 줄어드는 수를 출력한다.
*/


int N, cnt, digit = 0;
int[] arr = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
int[] num_digit = new int[10];
long num;
long[] start_num = new long[10] { 0, 10, 210, 3210, 43210, 543210, 6543210, 76543210, 876543210, 9876543210};
bool buffer = true;
string str_num;

N = Convert.ToInt32(Console.ReadLine());
num_digit[0] = 10;

for(int i = 1; i < 10; i++)
{
    num_digit[i] = num_digit[i - 1] + Calc.Comb(10, i + 1);
}

if(N > 1023)
{
    Console.WriteLine("-1");
}
else
{
    for(int i = 0; i < 10; i++)
    {
        if (num_digit[i] - N >= 0)
        {
            for(int j = 0; j < i; j++)
            {
                digit++;
            }
            break;
        }
    }

    num = start_num[digit];
    if (digit == 0)
    {
        cnt = 0;
    }
    else
    {
        cnt = num_digit[digit - 1];
    }

    while (true)
    {
        str_num = num.ToString();
        buffer = true;
        for (int i = 0; i < str_num.Length - 1; i++)
        {
            if (str_num[i] <= str_num[i + 1])
            {
                buffer = false;
                break;
            }
        }
        if (buffer)
        {
            cnt++;
        }

        if (cnt == N)
        {
            Console.WriteLine(num);
            break;
        }
        num++;
    }
}


class Calc
{
    public static int Comb(int n, int r)
    {
        int result1 = 1, result2 = 1;
        int end = r;
        for(int i = 0; i < end; i++)
        {
            result1 *= n--;
            result2 *= r--;
        }
        
        return result1 / result2;   
    }
}