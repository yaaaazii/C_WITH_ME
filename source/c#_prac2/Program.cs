Console.WriteLine("변수 만들기");
int age = 26;
string name = "예지";
Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine("");

Console.WriteLine("숫자 데이터 형식");
// int 정수, long 큰 실수
// float, double 실수 / decimal(돈 계산에 추천)
int a = 10;
double b = 3.14;
decimal money = 12345.67m;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(money);
Console.WriteLine("");

Console.WriteLine("숫자 이외의 데이터 형식");
//char 한 글자 / string 문자열 / bool 참 vs 거짓
char grade = 'A';
string msg = "Hello";
bool isOk = true;
Console.WriteLine($"{grade}, {msg}, {isOk}");
Console.WriteLine("");

Console.WriteLine("사용자 입력(콘솔) 받아 변수에 저장");
Console.Write("이름을 입력하세요: ");
string name8 = Console.ReadLine() ?? "";
Console.Write("나이를 입력하세요: ");
string ageText = Console.ReadLine() ?? "0";
int age8 = int.Parse(ageText);
Console.WriteLine($"안녕하세요, {name8}님. 나이는 {age8}세입니다.");
Console.WriteLine("");

Console.WriteLine("단항-산술");
int x = 7;
Console.WriteLine(x+3);
Console.WriteLine(x/3); // 정수 나눗셈 주의
Console.WriteLine(x%3); // 나머지
Console.WriteLine("");

Console.WriteLine("할당/증감");
int n = 10;
n += 5;
n -= 3;
n++;
--n;
Console.WriteLine(n);
Console.WriteLine("");

Console.WriteLine("관계/논리");
int score = 85;
bool pass = score >= 60 && score <= 100;
Console.WriteLine(pass);
Console.WriteLine("");

Console.WriteLine("비트/시프트");
int a12 = 5;
int b12 = 3;
Console.WriteLine(a12 & b12); // and
Console.WriteLine(a12 | b12); // or
Console.WriteLine(a12 ^ b12); // xor
Console.WriteLine(a12 << 1); // shift left
Console.WriteLine("");

Console.WriteLine("if/else");
int temp = 28;
if (temp >= 30)
    Console.WriteLine("더워요");
else if(temp >=20)
    Console.WriteLine("적당해요");
else
    Console.WriteLine("추워요");
Console.WriteLine("");

Console.WriteLine("switch");
Console.Write("등급(A/B/C): ");
string grade14 = Console.ReadLine() ?? "";
switch (grade14)
{
    case "A":
        Console.WriteLine("최우수");
        break;
    case "B":
        Console.WriteLine("우수");
        break;
    case "C":
        Console.WriteLine("보통");
        break;
    default:
        Console.WriteLine("잘못 입력");
        break;

}
Console.WriteLine("");

Console.WriteLine("반복문 + 제어(break/continue)");
Console.WriteLine("for");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("while/do-while");
int i16 = 1;
while (i16 <= 3)
{
    Console.WriteLine($"while:{i16}");
    i16++;
}
int j16 = 1;
do
{
    Console.WriteLine($"do: {j16}");
    j16++;
}
while (j16<=3);
Console.WriteLine("foreach");
int[] nums = { 1, 2, 3 };
foreach (var v in nums)
{
    Console.WriteLine(v);
}
Console.WriteLine("break/continue");
for (int k = 1; k < 10; k++)
{
    if (k == 5) continue; // 5는 건너뜀
    if (k == 8) break;    // 8에서 종료
    Console.WriteLine(k);
}

Console.WriteLine("");
Console.WriteLine("배열");
int[] arr = new int[3];
arr[0] = 10;
arr[1] = 20;
arr[2] = 30;
Console.WriteLine(arr[1]); // 20
Console.WriteLine("");

Console.WriteLine("함수(메서드) 사용하기");
int Add(int a, int b)
{
    return a + b;
}
Console.WriteLine(Add(3,4));
Console.WriteLine("");

Console.WriteLine("마무리 미션 : 숫자 맞추기 게임");
Random rnd = new Random();
int answer = rnd.Next(1, 101);
while (true)
{
    Console.WriteLine("1~100 숫자 입력: ");
    string input = Console.ReadLine() ?? "";

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("숫자를 입력하세요.");
        continue;
    }

    if (guess < answer)
    {
        Console.WriteLine("up");
    }
    else if (guess > answer)
    {
        Console.WriteLine("down");
    }
    else
    {
        Console.WriteLine("정답!");
        break;
    }
}