/*
문제
양의 정수 n이 주어졌을 때 n의 팩토리얼인 n!을 구하는 것은 쉽다.
이번에는 n!이 주어졌을 때 n을 구해 보자.

입력
어떤 자연수 n에 대해 n!이 입력으로 주어진다. n!의 자리수는 106 이하이다.

출력
n을 출력한다.
*/


string input;
int index;
double sum = 0;
int[] exep = new int[7] { 0, 1, 2, 6, 24, 120 ,720};

input = Console.ReadLine();
index = input.Length - 1;

if (index < 3)
{
    for(int i = 0; i < 7; i++)
    {
        if(Convert.ToInt32(input) == exep[i])
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    for (int i = 1; i < 1000000; i++)
    {
        sum += Math.Log10(i);

        if (Convert.ToInt32(Math.Truncate(sum)) == index)
        {
            Console.WriteLine(i);
            break;
        }
    }
}