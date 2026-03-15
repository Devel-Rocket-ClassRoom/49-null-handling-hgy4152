using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

List<string> player1Items = null;
List<string> player2Items = new List<string>();
List<string> player3Items = new List<string>{"검", "방패", "포션"};

player2Items = null;

Console.WriteLine($"=== 플레이어 1 (인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player1Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {player1Items?[0] ?? "없음"}");
Console.WriteLine($"마지막 아이템: {player1Items?[^1] ?? "없음"}");

Console.WriteLine($"=== 플레이어 2 (인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player2Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {player2Items?[0] ?? "없음"}");
Console.WriteLine($"마지막 아이템: {player2Items?[^1] ?? "없음"}");

Console.WriteLine($"=== 플레이어 3 (인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player3Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {player3Items?[0] ?? "없음"}");
Console.WriteLine($"마지막 아이템: {player3Items?[^1] ?? "없음"}");
