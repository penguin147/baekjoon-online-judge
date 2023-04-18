﻿/*
문제
세준이는 양수와 +, -, 그리고 괄호를 가지고 식을 만들었다.
그리고 나서 세준이는 괄호를 모두 지웠다.
그리고 나서 세준이는 괄호를 적절히 쳐서 이 식의 값을 최소로 만들려고 한다.
괄호를 적절히 쳐서 이 식의 값을 최소로 만드는 프로그램을 작성하시오.

입력
첫째 줄에 식이 주어진다.
식은 ‘0’~‘9’, ‘+’, 그리고 ‘-’만으로 이루어져 있고, 가장 처음과 마지막 문자는 숫자이다.
그리고 연속해서 두 개 이상의 연산자가 나타나지 않고, 5자리보다 많이 연속되는 숫자는 없다.
수는 0으로 시작할 수 있다.
입력으로 주어지는 식의 길이는 50보다 작거나 같다.

출력
첫째 줄에 정답을 출력한다.
*/

//1+2-4+5+4-2
string input;
string[] num = new string[50];
int[] info = new int[2];
int plus = 0, minus = 0, tmp = 1, token = -1;


input = Console.ReadLine();
num = input.Split(new char[] {'+', '-'});

plus += Convert.ToInt32(num[0]);

for(int i = 0; i < input.Length; i++)
{
    if (input[i] == '+')
    {
        if(token == 1)
        {
            minus += Convert.ToInt32(num[tmp++]);
        }
        else if(token == -1)
        {
            plus += Convert.ToInt32(num[tmp++]);
        }
    }
    else if (input[i] == '-')
    {
        if(token == -1)
            token *= -1;
        minus += Convert.ToInt32(num[tmp++]);
    }
}

Console.WriteLine(plus - minus);
