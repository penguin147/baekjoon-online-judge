/*
문제
주사위는 위와 같이 생겼다.
주사위의 여섯 면에는 수가 쓰여 있다.
위의 전개도를 수가 밖으로 나오게 접는다.
A, B, C, D, E, F에 쓰여 있는 수가 주어진다.
지민이는 현재 동일한 주사위를 N3개 가지고 있다.
이 주사위를 적절히 회전시키고 쌓아서, N×N×N크기의 정육면체를 만들려고 한다.
이 정육면체는 탁자위에 있으므로, 5개의 면만 보인다.
N과 주사위에 쓰여 있는 수가 주어질 때, 보이는 5개의 면에 쓰여 있는 수의 합의 최솟값을 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 N이 주어진다. 둘째 줄에 주사위에 쓰여 있는 수가 주어진다.
위의 그림에서 A, B, C, D, E, F에 쓰여 있는 수가 차례대로 주어진다.
N은 1,000,000보다 작거나 같은 자연수이고, 쓰여 있는 수는 50보다 작거나 같은 자연수이다.

출력
첫째 줄에 문제의 정답을 출력한다.
*/


string[] input_num = new string[6];
string input;
int[] num = new int[6];
System.Numerics.BigInteger N;

N = Convert.ToInt32(Console.ReadLine());

input = Console.ReadLine();
input_num = input.Split(' ');


for (int i = 0; i < 6; i++)
{
    num[i] = Convert.ToInt32(input_num[i]);
}


Console.WriteLine(Calc.dice(N, num));

class Calc
{
    
    public static System.Numerics.BigInteger dice(System.Numerics.BigInteger N, int[] num)
    {
        System.Numerics.BigInteger result = 0;

        if (N == 1)
        {
            Array.Sort(num);
            for (int i = 0; i < 5; i++)
            {
                result += num[i];
            }
        }
        else
        {
            System.Numerics.BigInteger first_min = 51, second_min = 101, third_min = 151;
            System.Numerics.BigInteger first_myun = 5 * N * N - 16 * N + 12;
            System.Numerics.BigInteger second_myun = 8 * N - 12;
            int third_myun = 4;

            for (int i = 0; i < 6; i++)
            {
                if (first_min > num[i])
                {
                    first_min = num[i];
                }
            }


            for (int i = 0; i < 6; i++)//두 면이 보이는 주사위
            {
                for (int j = 0; j < 6; j++)
                {
                    if (second_min > num[i] + num[j] && i + j != 5 && i != j)
                    {
                        second_min = num[i] + num[j];
                    }
                }
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (third_min > num[i] + num[j] && i + j != 5 && i != j)
                    {
                        third_min = num[i] + num[j];
                    }
                }
            }
            if (num[0] < num[5])
            {
                third_min += num[0];
            }
            else
            {
                third_min += num[5];
            }            
            result = first_min * first_myun + second_min * second_myun + third_min * third_myun;
        }
        return result;
    }
}