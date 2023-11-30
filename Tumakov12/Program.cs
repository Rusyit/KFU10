using System;

namespace Tumakov12
{
    class Program
    {
        static void Main()
        {
            // УПРАЖНЕНИЕ 12.1.
            Console.WriteLine("УПРАЖНЕНИЕ 12.1.\n");

            BankAcc firstBankAccount = new BankAcc(100, AccType.Текущий_счет);
            BankAcc secondBankAccount = new BankAcc(1000, AccType.Текущий_счет);
            BankAcc thirdBankAccount = new BankAcc(1000000, AccType.Текущий_счет);

            Console.WriteLine("Проверка операции == :");
            if (firstBankAccount == secondBankAccount)
            {
                Console.WriteLine(firstBankAccount.ToString() + " равнен " + secondBankAccount.ToString());
            }
            else
            {
                Console.WriteLine(firstBankAccount.ToString() + " неравнен " + secondBankAccount.ToString());
            }

            Console.WriteLine("\nПроверка операции != :");
            if (firstBankAccount != thirdBankAccount)
            {
                Console.WriteLine(firstBankAccount.ToString() + " неравнен " + thirdBankAccount.ToString());
            }
            else
            {
                Console.WriteLine(firstBankAccount.ToString() + " равнен " + thirdBankAccount.ToString());
            }

            Console.WriteLine("\nПроверка метода Equals:");
            if (firstBankAccount.Equals(secondBankAccount))
            {
                Console.WriteLine(firstBankAccount.ToString() + " равнен " + secondBankAccount.ToString());
            }
            else
            {
                Console.WriteLine(firstBankAccount.ToString() + " неравнен " + secondBankAccount.ToString());
            }


            // УПРАЖНЕНИЕ 12.2.                      
            Console.WriteLine("УПРАЖНЕНИЕ 12.2.\n");
            RationalNum RationalNum1 = RationalNum.MakeRationalNum(1, 5);
            RationalNum RationalNum2 = RationalNum.MakeRationalNum(4, 5);

            Console.WriteLine("Сумма: " + RationalNum1.ToString() + " + " + RationalNum2.ToString() + $" = {RationalNum1 + RationalNum2}");
            Console.WriteLine("Разность: " + RationalNum1.ToString() + " - " + RationalNum2.ToString() + $" = {RationalNum1 - RationalNum2}");
            Console.WriteLine("Умножение: " + RationalNum1.ToString() + " * " + RationalNum2.ToString() + $" = {RationalNum1 * RationalNum2}");
            Console.WriteLine("Деление: " + RationalNum1.ToString() + " / " + RationalNum2.ToString() + $" = {RationalNum1 / RationalNum2}");
            Console.WriteLine("Деление с остатком: %" + RationalNum1.ToString() + " % " + RationalNum2.ToString() + $" = {RationalNum1 % RationalNum2}");
            Console.WriteLine("Инкремент: ++" + RationalNum1.ToString() + $" = {++RationalNum1}");
            Console.WriteLine("Декремент: --" + RationalNum2.ToString() + $" = {--RationalNum2}\n");
            Console.WriteLine("Равно: == " + RationalNum1.ToString() + " == " + RationalNum2.ToString() + $" => {RationalNum1 == RationalNum2}");
            Console.WriteLine("Неравно: !=" + RationalNum1.ToString() + " != " + RationalNum2.ToString() + $" => {RationalNum1 != RationalNum2}");
            Console.WriteLine("Больше: >" + RationalNum1.ToString() + " > " + RationalNum2.ToString() + $" => {RationalNum1 > RationalNum2}");
            Console.WriteLine("Меньше: <" + RationalNum1.ToString() + " < " + RationalNum2.ToString() + $" => {RationalNum1 < RationalNum2}");
            Console.WriteLine("Больше или равно: >=" + RationalNum1.ToString() + " >= " + RationalNum2.ToString() + $" => {RationalNum1 >= RationalNum2}");
            Console.WriteLine("Меньше или равно: <=" + RationalNum1.ToString() + " <= " + RationalNum2.ToString() + $" => {RationalNum1 <= RationalNum2}\n");
            Console.WriteLine("Приведение типов в float: (float)" + RationalNum2.ToString() + $" => {(float)RationalNum2}");
            Console.WriteLine("Приведение типов в int: (int)" + RationalNum1.ToString() + $" => {(int)RationalNum1}");


            // ДОМАШНЕЕ ЗАДАНИЕ 12.1.
            Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ 12.1.\n");
            ComplexNum ComplexNum1 = new ComplexNum(1, 5);
            ComplexNum ComplexNum2 = new ComplexNum(4, 5);
            Console.WriteLine("Сумма: " + ComplexNum1.ToString() + " + " + ComplexNum2.ToString() + $" = {ComplexNum1 + ComplexNum2}");
            Console.WriteLine("Разность: " + ComplexNum1.ToString() + " - " + ComplexNum2.ToString() + $" = {ComplexNum1 - ComplexNum2}");
            Console.WriteLine("Умножение: " + ComplexNum1.ToString() + " * " + ComplexNum2.ToString() + $" = {ComplexNum1 * ComplexNum2}\n");
            Console.WriteLine("Равно: " + ComplexNum1.ToString() + " == " + ComplexNum2.ToString() + $" => {ComplexNum1 == ComplexNum2}");
            Console.WriteLine("Неравно: " + ComplexNum1.ToString() + " != " + ComplexNum2.ToString() + $" => {ComplexNum1 != ComplexNum2}");


            // Домашнее задание 12.2. Созданы классы книги и контейнера книг. Осуществляется сортировка с помощью делегата.
            Console.WriteLine("ДОМАШЕЕ ЗАДАНИЕ 12.2.\n");

            SortDelegate sortByTitle = book => book.BookTitle;
            SortDelegate sortByAuthor = book => book.BookAuthor;
            SortDelegate sortByPublishingHouse = book => book.PublishingHouse;

            Book Book1 = new Book("Колобок", "Народ", "История");
            Book Book2 = new Book("Гарри Поттер", "Роулинг", "Зарубежом");
            Book Book3 = new Book("Доктор Живаго", "Пастернак", "Книги");
            Book Book4 = new Book("Сто лет олиночества", "Маркес", "Рубежом");
            Book Book5 = new Book("Отверженные", "Гюго", "Мск");

            BooksContainer.AddBookToList(Book1, Book2, Book3, Book4, Book5);

            Console.WriteLine("Сортировка по названию: \n");
            BooksContainer.SortingListOfBooks(sortByTitle);

            foreach (Book book in BooksContainer.BooksList)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nСортировка по автору: \n");
            BooksContainer.SortingListOfBooks(sortByAuthor);

            foreach (Book book in BooksContainer.BooksList)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("\nСортировка по издательству: \n");
            BooksContainer.SortingListOfBooks(sortByPublishingHouse);
            foreach (Book book in BooksContainer.BooksList)
            {
                Console.WriteLine(book.ToString());
            }
        }

    }
}