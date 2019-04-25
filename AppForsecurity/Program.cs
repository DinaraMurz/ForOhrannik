using AppForsecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForSecurityGuard
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext()) {
                bool isProgramOn = true;
                while (isProgramOn)
                {
                    Console.WriteLine("Введите полное имя человека");
                    var visitor = new Visitor();
                    visitor.FullName = Console.ReadLine().ToString();

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Введите номер удостоверения человека");
                            visitor.CertificateNumber = long.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception exception)
                        {
                            exception.Message.ToString();
                            Console.WriteLine("Вы ввели некоррекные данные, попробуйте снова\n\n");
                            continue;
                        }
                    }

                    Console.WriteLine("Введите цель его посещения");
                    visitor.VisitPurpose = Console.ReadLine();

                    Console.WriteLine("Время посищения человека");
                    visitor.InsretDateOnConsole(visitor.ComingTime);

                    Console.WriteLine("Введите время ухода человека");
                    visitor.InsretDateOnConsole(visitor.LeavingTime);


                    context.Visitors.Add(visitor);
                    Console.WriteLine("Человек успешно введён\n\n\n");
                }
            }
        }
    }
}
