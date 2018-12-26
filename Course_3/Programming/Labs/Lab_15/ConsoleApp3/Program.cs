﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Account
    {
        // Объявляем делегат
        public delegate void AccountStateHandler(object sender, AccountEventArgs e);
        // Событие, возникающее при выводе денег
        public event AccountStateHandler Withdrawn;
        // Событие, возникающее при добавлении на счет
        public event AccountStateHandler Added;

        int _sum; // Переменная для хранения суммы

        public Account(int sum)
        {
            _sum = sum;
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
            if (Added != null)
                Added(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                    Withdrawn(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                if (Withdrawn != null)
                    Withdrawn(this, new AccountEventArgs("Недостаточно денег на счете", sum));
            }
        }
    }
    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабараторная работа №15 Адещенко Кирилл ";
            Account account = new Account(6033);
            account.Added += Show_Message;
            account.Withdrawn += Show_Message;
            account.Withdraw(1300);
            account.Withdrawn -= Show_Message;
            account.Withdraw(60);
            account.Put(150);
            Console.ReadLine();
        }
        private static void Show_Message(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
    }
}
