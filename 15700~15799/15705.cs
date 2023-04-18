/*
문제
N×M 크기의 표의 각 칸에 알파벳 대문자가 하나씩 쓰여 있다.
단어 S가 주어졌을 때, 표에 단어 S가 있는지 없는지 구하는 프로그램을 작성하시오.
단어 S가 표에 존재하려면, 표의 한 칸에서 시작해, 연속해서 그 단어의 모든 알파벳이 순서대로 등장해야 한다.
이때, 연속하는 방향은 위, 아래, 오른쪽, 왼쪽, 대각선 방향 모두 가능하다.
대각선 방향은 왼쪽 위, 오른쪽 아래, 오른쪽 위, 왼쪽 아래 방향이 모두 가능하다.
연속하는 방향이 중간에 바뀌면 안 된다.

입력
첫째 줄에 길이가 100보다 작거나 같은 단어 S가 주어진다.
S는 알파벳 대문자로만 이루어져 있다.
둘째 줄에는 표의 행의 개수 N과 열의 개수 M이 주어진다.
N과 M은 100보다 작거나 같은 자연수이다.
셋째 줄부터 N개의 줄에는 표의 각 행에 들어있는 알파벳이 주어진다.

출력
입력으로 주어진 표에 단어 S가 존재하면 1을, 없으면 0을 출력한다.
*/


using System.Linq;

int N, M, result = 0;
string find_word, reversed_find_word;
string[] alps, rotate_alps, num, reversed_alps, rotated_reversed_alps;

find_word = Console.ReadLine();
reversed_find_word = new string(find_word.Reverse().ToArray());

num = Console.ReadLine().Split(' ');
N = Convert.ToInt32(num[0]);
M = Convert.ToInt32(num[1]);
alps = new string[N];
reversed_alps = new string[N];
for (int i = 0; i < N; i++)
{
    alps[i] = Console.ReadLine();
    reversed_alps[i] = new string(alps[i].Reverse().ToArray());
}

rotate_alps = Find.Make_cases1(alps, N, M);
rotated_reversed_alps = Find.Make_cases1(reversed_alps, N, M);

if (N > M)
{
    if (Find.Make_cases2(rotate_alps, M, N, find_word) || Find.Make_cases2(rotate_alps, M, N, reversed_find_word) || Find.Make_cases2(rotated_reversed_alps, M, N, find_word) || Find.Make_cases2(rotated_reversed_alps, M, N, reversed_find_word))
    {
        result = 1;
    }
}
else
{
    if (Find.Make_cases2(alps, N, M, find_word) || Find.Make_cases2(alps, N, M, reversed_find_word) || Find.Make_cases2(reversed_alps, N, M, find_word) || Find.Make_cases2(reversed_alps, N, M, reversed_find_word))
    {
        result = 1;
    }
}
for (int i = 0; i < N; i++)
{
    if (alps[i].Contains(find_word) || alps[i].Contains(reversed_find_word))
    {
        result = 1;
    }
}
for (int i = 0; i < M; i++)
{
    if (rotate_alps[i].Contains(find_word) || rotate_alps[i].Contains(reversed_find_word))
    {
        result = 1;
    }
}

Console.WriteLine(result);


class Find
{

    public static string[] Make_cases1(string[] alps, int N, int M)
    {
        string[] rotate = new string[M];
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                rotate[i] += alps[j][i];
            }
        }
        return rotate;
    }

    public static bool Make_cases2(string[] alps, int N, int M, string find_word)
    {
        string diagonal = "";
        int tmp = 0;

        for (int i = 0; i < M - N + 1; i++)
        {
            for (int j = 0; j < N; j++)
            {
                diagonal += alps[j][i + j];
            }
            if (diagonal.Contains(find_word))
            {
                return true;
            }
            
            diagonal = "";
        }
        for (int i = M - N + 1; i < M - 1; i++)
        {
            for (int j = 0; j < N - 1 - tmp; j++)
            {
                diagonal += alps[j][i + j];
            }
            if (diagonal.Contains(find_word))
            {
                return true;
            }
            
            diagonal = "";
            tmp++;
        }
        tmp = 0;
        for (int i = 1; i < N - 1; i++)
        {
            for (int j = 0; j < N - 1 - tmp; j++)
            {
                diagonal += alps[i + j][j];
            }
            if (diagonal.Contains(find_word))
            {
                return true;
            }
            
            diagonal = "";
            tmp++;
        }
        return false;
    }
}