using System;

// README.md를 읽고 아래에 코드를 작성하세요.
string userSetting = null;
string profileSetting = "프로필유저";
string globalSetting = null;
string defaultValue = "Player";


string playerName = userSetting ?? profileSetting ?? globalSetting ?? defaultValue;


userSetting = null;
profileSetting = null;
globalSetting = null;
defaultValue = "localhost";

string adress = userSetting ?? profileSetting ?? globalSetting ?? defaultValue;

userSetting = "English";
profileSetting = "Korean";
globalSetting = "Japanese";
defaultValue = "Korean";

string language = userSetting ?? profileSetting ?? globalSetting ?? defaultValue;

userSetting = null;
profileSetting = null;
globalSetting = "70";
defaultValue = "50";

int? volume = int.Parse(userSetting ?? profileSetting ?? globalSetting ?? defaultValue);


Console.WriteLine("=== 설정 결정 ===");
Console.WriteLine($"플레이어 이름: {playerName} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {adress} (기본값에서 가져옴)");
Console.WriteLine($"언어: {language} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {volume} (전역 설정에서 가져옴)");

Console.WriteLine("=== 캐시 저장(??=) ===");
string cashName = null;
Console.WriteLine($"캐시 저장 전: {cashName}");

cashName ??= playerName;
cashName ??= "playerName";

Console.WriteLine($"첫 번째 ??= 적용 후: {cashName}");
Console.WriteLine($"두 번째 ??= 적용 후: {cashName}");

Console.WriteLine("=== 최종 설정 ===");
Console.WriteLine($"플레이어 이름: {cashName}");
Console.WriteLine($"서버 주소: {adress}");
Console.WriteLine($"언어: {language}");
Console.WriteLine($"볼륨: {volume}");