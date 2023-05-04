﻿/*
문제
도주는 동물을 좋아한다.
그중에서도 여우를 정말 좋아한다!
어느 날, 힐링을 위해 여우 사진을 검색하던 도주는 “여우 사인”이라는 손 모양을 발견했다.
여우 사인은 엄지손가락, 중지, 약지 세 손가락을 서로 끝이 맞닿도록 모으고, 검지와 새끼손가락은 다른 손가락과 닿지 않도록 곧게 펴서 여우의 얼굴과 두 귀를 표현한 손 모양이다.
도주는 자신의 여우 사랑을 널리 알리기 위해 때때로 이 손 모양을 하고 귀여운 척을 하기로 했다.
도주의 손 모양이 주어질 때, 그것을 여우 사인이라고 할 수 있는지 판별해 보자. 편의상 손 모양은 서로 닿아 있는 손가락 쌍의 나열으로 표현하며, 손가락들이 서로 닿아 있는 관계가 올바른 여우 사인의 그것과 같다면 여우 사인으로 인정한다.

입력
첫 번째 줄에 서로 닿아 있는 손가락 쌍의 개수 N(1 ≤ N ≤ 10)이 주어진다.
두 번째 줄부터 N개의 줄에 걸쳐 서로 닿아 있는 두 손가락을 의미하는 1 이상 5 이하의 숫자 두 개가 공백으로 구분되어 주어진다.
1은 엄지손가락, 2는 검지, 3은 중지, 4는 약지, 5는 새끼손가락을 의미한다.
입력 순서가 다른 것을 포함하여 같은 쌍이 여러 번 주어지거나 한 손가락만으로 이루어진 쌍이 주어지는 경우는 없다.

출력
첫 번째 줄에 도주의 손 모양을 여우 사인이라고 할 수 있으면 Wa-pa-pa-pa-pa-pa-pow!를, 그렇지 않으면 Woof-meow-tweet-squeek을 출력한다.
*/


int N, el_cnt = 0;
string input;
N = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < N; i++)
{
    input = Console.ReadLine();
    
    if (!(input == "1 3" || input == "3 1" || input == "1 4" || input == "4 1" || input == "4 3" || input == "3 4"))
    {
        el_cnt++;
    }
}

if(el_cnt == 0 && N == 3)
{
    Console.WriteLine("Wa-pa-pa-pa-pa-pa-pow!");
}
else
{
    Console.WriteLine("Woof-meow-tweet-squeek");
}