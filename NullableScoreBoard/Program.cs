using System;

// README.md를 읽고 아래에 코드를 작성하세요.

int?[] scores = { 3, null, 7, null, 5 };


Console.WriteLine("=== 경기 상태 ===");
int count = 1;
foreach  (var score in scores)
{
    if(score.HasValue)
        Console.WriteLine($"경기 {count++}: {score}점(진행 완료)");

    else
    {
        Console.WriteLine($"경기 {count++}: 미진행");

    }
}


Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");

count = 1;
foreach  (var score in scores)
{
    if(score.HasValue)
        Console.WriteLine($"경기 {count++}: {score}점(진행 완료)");

    else
    {
        Console.WriteLine($"경기 {count++}: {score.GetValueOrDefault(-1)}");

    }
}
Console.WriteLine("=== 통계 ===");

count = 0;
int sum = 0;
foreach  (var score in scores)
{
    if(score.HasValue)
    {
        count++;
        sum += score.Value;
    }

}

Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {sum}");
Console.WriteLine($"평균: {sum/count:n1}");