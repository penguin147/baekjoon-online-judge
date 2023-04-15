/*
문제
해빈이는 패션에 매우 민감해서 한번 입었던 옷들의 조합을 절대 다시 입지 않는다.
예를 들어 오늘 해빈이가 안경, 코트, 상의, 신발을 입었다면, 다음날은 바지를 추가로 입거나 안경대신 렌즈를 착용하거나 해야한다.
해빈이가 가진 의상들이 주어졌을때 과연 해빈이는 알몸이 아닌 상태로 며칠동안 밖에 돌아다닐 수 있을까?

입력
첫째 줄에 테스트 케이스가 주어진다.
테스트 케이스는 최대 100이다.
각 테스트 케이스의 첫째 줄에는 해빈이가 가진 의상의 수 n(0 ≤ n ≤ 30)이 주어진다.
다음 n개에는 해빈이가 가진 의상의 이름과 의상의 종류가 공백으로 구분되어 주어진다.
같은 종류의 의상은 하나만 입을 수 있다.
모든 문자열은 1이상 20이하의 알파벳 소문자로 이루어져있으며 같은 이름을 가진 의상은 존재하지 않는다.

출력
각 테스트 케이스에 대해 해빈이가 알몸이 아닌 상태로 의상을 입을 수 있는 경우를 출력하시오.
*/


int cases, each_cases, cnt;
string[] input = new string[2];
int[] cloth_cnt;
cases = Convert.ToInt32(Console.ReadLine());
string[] names;

for(int i = 0; i < cases; i++)
{
    each_cases = Convert.ToInt32(Console.ReadLine());
    names = new string[each_cases];
    cloth_cnt = new int[each_cases];
    
    cnt = 0;
    for(int j = 0; j < each_cases; j++)
    {
        cloth_cnt[j] = 0;
        names[j] = "";
    }
    for(int j = 0; j < each_cases; j++)
    {
        input = Console.ReadLine().Split(' ');

        
        if (names.Contains(input[1]))
        {
            
            cloth_cnt[Array.IndexOf(names, input[1])]++;
            
        }
        else
        {

            names[cnt] = input[1];
            cloth_cnt[cnt++]++;
        }
    }

    
    Console.WriteLine(ClothChoose.Cloth_choose(cnt, cloth_cnt));
}


class ClothChoose
{
    public static int Cloth_choose(int cloth_type, int[] cloth_num)
    {
        int result = 1;
        for(int i = 0; i < cloth_type; i++)
        {
            result *= Comb(cloth_num[i] + 1, 1);
            
        }
        return result - 1;
    }

    public static int Comb(int n, int r)
    {
        int a, b;
        a = b = 1;

        for(int i = n; i > n - r; i--)
        {
            a *= i;
        }

        for(int i = 1; i <= r; i++)
        {
            b *= i;
        }

        return a / b;
    }

}






