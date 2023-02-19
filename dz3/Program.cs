//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
	 
     int Prompt (string msg)
 {
    Console.Write(msg);
    string value = Console.Readline();
    int result = Convert.ToInt32 (value);
    return result;
 }
 bool IsWeekend (int weekDay)
 {
    if (weekDay > 5)
    {
        return true;
    } 
    return false;
 }
 bool ValidateWeekday (int number)
 {
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.Writeline("Это не день недеи");
}
Int weekDay = Prompt("Введите день недели");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
Console.Writeline ("ура выходной");
}
    else
    {
        Console.Writeline("Придется поработать");
    }

