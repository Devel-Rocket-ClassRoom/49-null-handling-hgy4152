using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


string name = null;


name ??= "이름 없음";
Console.WriteLine(name);
name ??= "새 이름";
Console.WriteLine(name);


string playerName = null;

if(playerName == null)
{
    playerName = "플레이어";
}

Console.WriteLine(playerName);


List<string> _items = null; 
_items ??= new List<string>();

_items.Add("검");

_items ??= new List<string>();

_items.Add("방패");

Console.WriteLine($"아이템 수: {_items.Count}");

foreach(string item in _items)
{
    Console.WriteLine($" - {item}");
}


string message  = null;

int? len = message?.Length;

Console.WriteLine($"길이: {len}");

message = "안녕하세요";
len = message?.Length;
Console.WriteLine($"길이: {len}");


string text = null;

if(text?.Length == null)
{
    Console.WriteLine("텍스트가 없습니다.");
}


name = null;

Console.WriteLine("대문자: " + name?.ToUpper());

name = "hello";
Console.WriteLine("대문자: " + name?.ToUpper());


text = null;

text?.ToUpper()?.Trim();

Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");

text = " hello ";
Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");



List<string> items = null;

int? num = items?.Count;

Console.WriteLine($"아이템 수: {num}");

items.Add("사과");
items.Add("바나나");

Console.WriteLine($"아이템 수: {num}");



text = null;

char? c = text?[0];

Console.WriteLine($"첫 글자: {c}");


text = "Hello";

c = text?[0];

Console.WriteLine($"첫 글자: {c}");


message = null;

len = message?.Length ?? 0;

Console.WriteLine($"길이: {len}");

message = "Hello";

len = message?.Length ?? 0;

Console.WriteLine($"길이: {len}");


List<string> names = null;
len = names?.Count ?? 0;

Console.WriteLine($"이름 수: {len}");
names.Add("Kim");
names.Add("Lee");
names.Add("Park");
len = names?.Count ?? 0;

Console.WriteLine($"이름 수: {len}");


playerName = null;
int? playerLevel = null;
List<string> inventory = null;

string displayName = playerName ?? "Unknown";
int level = playerLevel ?? 1;
int itemCount = inventory?.Count ?? 0;



Console.WriteLine($"플레이어: {displayName}");
Console.WriteLine($"레벨: {level}");
Console.WriteLine($"인벤토리 아이템: {itemCount}개");