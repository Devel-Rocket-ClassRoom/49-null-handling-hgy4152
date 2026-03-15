using System;

// README.md를 읽고 코드를 작성하세요.

int number = 0;
string text = "";
string nothing = null;

Console.WriteLine(number);
Console.WriteLine(text);
Console.WriteLine(nothing);


string name = null;
Console.WriteLine(name == null);

int? a = null;
double? b = null;
bool? c = null;

Nullable<int> aa  = null;
Nullable<double> bb = null;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(aa);
Console.WriteLine(bb);

int? score = null;

Console.WriteLine($"score.HasValue: {score.HasValue}");

score = 95;

Console.WriteLine($"score.HasValue: {score.HasValue}");
Console.WriteLine($"score.Value: {score.Value}");


int? empty = null;

if(empty.HasValue)
{
    Console.WriteLine(empty.Value);
}
else
{
    Console.WriteLine("값이 없습니다.");
}


int? level = null;

level = level.GetValueOrDefault();
Console.WriteLine($"기본값 사용: {level}");
level = level.GetValueOrDefault(1);
Console.WriteLine($"커스텀 기본값: {level}");

level = 50;
level = level.GetValueOrDefault();
Console.WriteLine($"값이 있을 때: {level}");

number = 42;

int? nullable = number;

int back = (int)nullable;

Console.WriteLine($"nullable: {nullable}");
Console.WriteLine($"back: {back}");


string message  = null;
string result = message ?? "기본 메시지";
message = "안녕하세요";


Console.WriteLine($"{result}");
Console.WriteLine($"{message}");


string input = null;
string output = null;

if(input == null)
{
    output = "기본값";
    Console.WriteLine($"if문 결과: {output}");
}

output = null ?? "기본값";

Console.WriteLine($"?? 연산자 결과: {output}");


int? score1 = null;

score1 ??= -1;

int? health  = null;
health ??= default(int);

Console.WriteLine($"점수: {score1}");
Console.WriteLine($"체력: {health}");


string first = null, second = null;
string third = "세 번째 값";

Console.WriteLine(first ?? second ?? third);