/*
문제
문빙이는 새해를 좋아한다.
하지만, 이제 새해는 너무 많이 남았다.
그래도 문빙이는 새해를 기다릴 것이다.
어느 날 문빙이는 잠에서 깨면서 스스로에게 물었다.
“잠깐, 새해가 얼마나 남은거지?”
이 문제에 답하기 위해서 문빙이는 간단한 어플리케이션을 만들기로 했다.
연도 진행바라는 것인데, 이번 해가 얼마나 지났는지를 보여주는 것이다.
오늘 날짜가 주어진다.
이번 해가 몇%지났는지 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 Month DD, YYYY HH:MM과 같이 주어진다.
Month는 현재 월이고, YYYY는 현재 연도이다. 숫자 네자리이다.
DD, HH, MM은 모두 2자리 숫자이고, 현재 일, 시, 분이다.

Month는 January, February, March, April, May, June, July, August, September, October, November, December 중의 하나이고,연도는 1800보다 크거나 같고, 2600보다 작거나 같다.
항상 올바른 날짜와 시간만 입력으로 주어진다.

출력
첫째 줄에 문제의 정답을 출력한다.
절대/상대 오차는 10-9까지 허용한다.
*/


string[] input = new string[4];
string[] month_name = new string[] {"January", "February", "March", "April", "May", "June", "July",
    "August", "September", "October", "November", "December", };
string[] time = new string[2];
bool yoon = false;
decimal month = 0, day, hour, min, year, total_time, current_time = 0, ratio;

input = Console.ReadLine().Split(' ');
input[1] = input[1].Replace(",", "");
time = input[3].Split(":");

for(int i = 0; i < 12; i++)//달
{
    if (input[0] == month_name[i])
    {
        month = i + 1;
        break;
    }
}

day = Convert.ToInt32(input[1]);//일
year = Convert.ToInt32(input[2]);//연
hour = Convert.ToInt32(time[0]);//시
min = Convert.ToInt32(time[1]);//분

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    yoon = true;
}

if(yoon)
{
    total_time = 366 * 24 * 60;
}
else
{
    total_time = 365 * 24 * 60;
}

for(int i = 1; i < month; i++)
{
    if(i == 2)//2월만 28일
    {
        if(yoon)// 윤년엔 29일
        {
            current_time += 29 * 24 * 60;
        }
        else//평년
        {
            current_time += 28 * 24 * 60;//40320
        }
    }
    else if(i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)//홀수달
    {
        current_time += 31 * 24 * 60; //44640
    }
    else
    {
        current_time += 30 * 24 * 60; //43200
    }
}

current_time += (day-1) * 24 * 60 + hour * 60 + min;
ratio = current_time / total_time * 100;
Console.WriteLine(ratio);