using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForsecurity
{
    public class Visitor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public long CertificateNumber { get; set; }
        public DateTime ComingTime { get; set; }
        public DateTime LeavingTime { get; set; }
        public string VisitPurpose { get; set; }


        public DateTime InsretDateOnConsole(DateTime date) {
            int year, mounth, day, hours, minutes, seconds;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите год");
                    year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите месяц");
                    mounth = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите день");
                    day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите час");
                    hours = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите минуты");
                    minutes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите секунды");
                    seconds = int.Parse(Console.ReadLine());

                    date = new DateTime(year, mounth, day, hours, minutes, seconds);

                    break;
                }
                catch (Exception exception)
                {
                    exception.Message.ToString();
                    Console.WriteLine("Вы ввели некоррекные данные, попробуйте снова\n\n");
                    continue;
                }
            }

            return date;
        }
    }
}
   