/*
문제
다섯 개의 자연수가 있다.
이 수의 적어도 대부분의 배수는 위의 수 중 적어도 세 개로 나누어 지는 가장 작은 자연수이다.
서로 다른 다섯 개의 자연수가 주어질 때, 적어도 대부분의 배수를 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 다섯 개의 자연수가 주어진다.
100보다 작거나 같은 자연수이고, 서로 다른 수이다.

출력
첫째 줄에 적어도 대부분의 배수를 출력한다.
*/

string input;
string[] input_num= new string[5];
int[] num = new int[5];
int[] selected = new int[3];
int result = 1;
bool buffer = true;
int max1 = 1, max2 = 1;
int tmp1, tmp2;

input = Console.ReadLine();
input_num = input.Split(' ');

for(int i =  0; i < 5; i++)
{
    num[i] = Convert.ToInt32(input_num[i]);
}
Array.Sort(num);
Array.Reverse(num);
result = num[0] * num[1] * num[2];

for(int i = 0; i < 4 && buffer; i++)
{
    for(int j = i + 1; j < 5 && buffer; j++)
    {
        tmp1 = 0;
        for (int k = 0; k < 5; k++)
        {
            if(k != i && k != j)
            {
                selected[tmp1++] = num[k];
            }
        }
        tmp2 = Calc.lcm(selected[0], selected[1], selected[2]);
        if(result > tmp2)
        {
            result = tmp2;
        }
    }
}

Console.WriteLine(result);


class Calc
{
    public static int lcm(int a, int b, int c)
    {
        int result = 1;

        
        for(int i = a * b * c; i > 1; i--)
        {
            
            if(i % a == 0 && i % b == 0 && i % c == 0)
            {
                result = i;
               
            }
        }


        return result;
    }
}