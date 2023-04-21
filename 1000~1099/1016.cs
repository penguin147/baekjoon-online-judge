/*
문제
어떤 정수 X가 1보다 큰 제곱수로 나누어 떨어지지 않을 때, 그 수를 제곱ㄴㄴ수라고 한다.
제곱수는 정수의 제곱이다.
min과 max가 주어지면, min보다 크거나 같고, max보다 작거나 같은 제곱ㄴㄴ수가 몇 개 있는지 출력한다.

입력
첫째 줄에 두 정수 min과 max가 주어진다.

출력
첫째 줄에 min보다 크거나 같고, max보다 작거나 같은 제곱ㄴㄴ수의 개수를 출력한다.
*/


string[] input;
long[] num;
long min, max, result, tmp = 0;

input = Console.ReadLine().Split(' ');
min = Convert.ToInt64(input[0]);
max = Convert.ToInt64(input[1]);

num = new long[max - min + 1];
result = max - min + 1;


for (long i = min; i <= max; i++)
{
    num[i - min] = i;
}

for(long i = 2; i <= (long)Math.Sqrt(max); i++)
{
    tmp = min / (i * i);
    if(tmp * (i * i) < min)
    {
        tmp++;
        
    }
    tmp = tmp * (i * i);
        
    for (long j = tmp - min; j < max - min + 1; j += i * i)
    {
        if (num[j] == 0)
        {
            continue;
        } 
        num[j] = 0;
        result--;           
    }
}



Console.WriteLine(result);