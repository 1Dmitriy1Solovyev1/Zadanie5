using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        double interestRate;

        if (depositAmount < 100)
        {
            interestRate = 0.07; // Если сумма вклада меньше 100, установить процентную ставку 7%.
        }
        else if (depositAmount >= 100 && depositAmount <= 200)
        {
            interestRate = 0.09; // Если сумма вклада от 100 до 200, установить процентную ставку 9%.
        }
        else
        {
            interestRate = 0.12; // Если сумма вклада больше 200, установить процентную ставку 12%.
        }

        double totalAmount = depositAmount + depositAmount * interestRate; // Вычислить сумму вклада с начисленными процентами.

        double bonus = 15; // Размер бонуса.
        totalAmount += bonus; // Добавить бонус к финальной сумме вклада.

        Console.WriteLine("Сумма вклада с начисленными процентами и бонусом: " + totalAmount);
    }
}
