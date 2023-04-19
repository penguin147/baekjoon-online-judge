﻿/*
문제
서로 다른 N개의 자연수의 합이 S라고 한다.
S를 알 때, 자연수 N의 최댓값은 얼마일까?

입력
첫째 줄에 자연수 S(1 ≤ S ≤ 4,294,967,295)가 주어진다.

출력
첫째 줄에 자연수 N의 최댓값을 출력한다.
*/


long S, sum = 0, cnt = 0;

S = Convert.ToInt64(Console.ReadLine());

for(long i = 1; sum < S; i++)
{
    sum += i;
    cnt = i;
}

for (long i = cnt; i > 0; i--)
{
    sum -= i;
    if(S - sum > i - 1)
    {
        cnt = i;
        break;
    }
}

Console.WriteLine(cnt);