// Задача 3
// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'.
// Определите, является ли ваша строка допустимой.
// Исходная строка считается допустимой при условии:
// 1. Открытые скобки должны быть закрыты скобками того же типа.
// 2. Открытые скобки должны быть закрыты в правильном порядке.
// 4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

bool GetCorrectBracket (string s)
{
if (s.Length%2 == 0)
{
    bool resalt = true;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '(')
    {
        int temp = 0;
        for (int j = i+1; j < s.Length; j++)
        {
            if (s[j] == ')')
            {
                temp++;
            }
        }
        if (temp == 0) resalt = false;
    }
      if (s[i] == '{')
    {
        int temp = 0;
        for (int j = i+1; j < s.Length; j++)
        {
            if (s[j] == '}')
            {
                temp++;
            }
        }
        if (temp == 0) resalt = false;
    }
     if (s[i] == '[')
    {
        int temp = 0;
        for (int j = i+1; j < s.Length; j++)
        {
            if (s[j] == ']')
            {
                temp++;
            }
        }
        if (temp == 0) resalt = false;
    }
}
return resalt;
}
else return false;
}

//----------------------------------------------------
string s = "()[]()}";
Console.WriteLine(GetCorrectBracket(s));

