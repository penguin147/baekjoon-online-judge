﻿/*
문제
임한수와 임문빈은 서로 사랑하는 사이이다.
임한수는 세상에서 팰린드롬인 문자열을 너무 좋아하기 때문에, 둘의 백일을 기념해서 임문빈은 팰린드롬을 선물해주려고 한다.
임문빈은 임한수의 영어 이름으로 팰린드롬을 만들려고 하는데, 임한수의 영어 이름의 알파벳 순서를 적절히 바꿔서 팰린드롬을 만들려고 한다.
임문빈을 도와 임한수의 영어 이름을 팰린드롬으로 바꾸는 프로그램을 작성하시오.

입력
첫째 줄에 임한수의 영어 이름이 있다.
알파벳 대문자로만 된 최대 50글자이다.

출력
첫째 줄에 문제의 정답을 출력한다.
만약 불가능할 때는 "I'm Sorry Hansoo"를 출력한다.
정답이 여러 개일 경우에는 사전순으로 앞서는 것을 출력한다.
*/


int buffer = 0, index = 0;
int[] alps_num = new int[26];
char[] alps = new char[26];
string name_input;

name_input = Console.ReadLine();

for(int i = 65; i <= 90; i++)
{
    alps[i - 65] = (char)i;
}

for(int i = 0; i < name_input.Length; i++)
{
    alps_num[Array.IndexOf(alps, name_input[i])]++;
}

for(int i = 0; i < 26; i++)
{
    if (alps_num[i] % 2 == 1)
    {
        buffer++;
        index = i;
    }
}

Calc.Felindrom(alps, alps_num, name_input, buffer, index);


class Calc
{
    public static void Felindrom(char[] alps, int[] alps_num, string input_alps,int how_many_odd, int where_is_odd)
    {
        
        if (how_many_odd > 1)
        {
            Console.WriteLine("I'm Sorry Hansoo");
        }
        else if(input_alps.Length == 1)
        {
            Console.WriteLine(input_alps);
        }
        else
        {
            for (int i = 0; i < 26; i++)
            {
                if (alps_num[i] != 0)
                {

                    for (int j = 0; j < alps_num[i] / 2; j++)
                    {
                        Console.Write(alps[i]);
                    }
                    alps_num[i] /= 2;
                }
            }

            if (how_many_odd == 1)
            {
                Console.Write(alps[where_is_odd]);
            }

            for (int i = 25; i >= 0; i--)
            {
                if (alps_num[i] != 0)
                {
                    for (int j = 0; j < alps_num[i]; j++)
                    {
                        Console.Write(alps[i]);
                    }
                }
            }
        }
    }
        
}