// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

try  
{ 
    void HWTask15 ()
    { 
        Console.WriteLine("Введите целое число ");
        int num=Convert.ToInt32 (Console.ReadLine());

        if (num > 0 & num < 6)  Console.WriteLine("Этот день не является выходным");
        else if (num >=  6 & num <= 7)  Console.WriteLine("Этот день является выходным");
        else Console.WriteLine("Такой цифры дня в неделе нет");
        
    }
    HWTask15();
}
catch
{
    Console.WriteLine("Неверно введено число, необходимо было ввести целое число цифрой ");
}