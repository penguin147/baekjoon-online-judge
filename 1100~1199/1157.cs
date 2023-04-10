/*
문제
알파벳 대소문자로 된 단어가 주어지면, 이 단어에서 가장 많이 사용된 알파벳이 무엇인지 알아내는 프로그램을 작성하시오.
단, 대문자와 소문자를 구분하지 않는다.

입력
첫째 줄에 알파벳 대소문자로 이루어진 단어가 주어진다.
주어지는 단어의 길이는 1,000,000을 넘지 않는다.

출력
첫째 줄에 이 단어에서 가장 많이 사용된 알파벳을 대문자로 출력한다.
단, 가장 많이 사용된 알파벳이 여러 개 존재하는 경우에는 ?를 출력한다.
*/

string input;
char[] input_alp;
char[] alp;
int[] freq;
int cnt = 0, max = 0, max_index = 0;
bool buffer = false;

input = Console.ReadLine();

input_alp = input.ToUpper().ToCharArray();
Array.Sort(input_alp);

alp = new char[input_alp.Length];
freq = new int[input_alp.Length];

alp[0] = input_alp[0];
for (int i = 0; i < input_alp.Length; i++)
{
    if (alp[cnt] != input_alp[i])
    {
        cnt++;
        alp[cnt] = input_alp[i];
    }

    if (alp[cnt] == input_alp[i])
    {
        freq[cnt]++;
    }

}

max = freq[0];
for (int i = 1; i < input_alp.Length; i++)
{
    if (max < freq[i])
    {
        max = freq[i];
        max_index = i;
    }
}

for(int i = 0; i < input_alp.Length; i++)
{
    if (freq[i] == max && i != max_index)
    {
        buffer = true;
    }
    
}

if (buffer)
{
    Console.WriteLine("?");
}
else
{
    Console.WriteLine(alp[max_index]);
}