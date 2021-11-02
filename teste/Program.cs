using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime(2021, 11, 01, 18, 30, 32);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
            Console.WriteLine(data.TimeOfDay);
            Console.WriteLine(data.AddDays(1));
            Console.WriteLine(data);
            Console.ReadKey();

            //formatando data
            //ano y
            //mes M
            //dia d
            //hora h
            //minuto m
            //segundo s
            Console.Clear();
            data = DateTime.Now;
            Console.WriteLine(data);

            var formatada = String.Format("{0:f}", data);
            Console.WriteLine(formatada);


            formatada = String.Format("{0:r}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:s}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);

            //ou


            Console.WriteLine(DateTime.Now.ToString("u"));




            Console.ReadKey();


            // adicionando ou removendo dias ou hora
            // usar data = data.day + 1, pois não controlamos o as mudanças de meses. 

            Console.Clear();
            data = DateTime.Now;
            Console.WriteLine("Data Atual");
            Console.WriteLine(data);
            Console.WriteLine("Add Dias");
            Console.WriteLine(data.AddDays(1));
            Console.WriteLine(data.AddDays(-1));
            Console.WriteLine("Add Meses");
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddMonths(-1));
            Console.WriteLine("Add Anos");
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine(data.AddYears(-1));

            Console.WriteLine("Add Hora");
            Console.WriteLine(data.AddHours(1));
            Console.WriteLine(data.AddHours(-1));
            Console.WriteLine("Add Minutos");
            Console.WriteLine(data.AddMinutes(1));
            Console.WriteLine(data.AddMinutes(-1));
            Console.WriteLine("Add Segundos");
            Console.WriteLine(data.AddSeconds(1));
            Console.WriteLine(data.AddSeconds(-1));
            Console.WriteLine("Add Mili");
            Console.WriteLine(data.AddMilliseconds(1));
            Console.WriteLine(data.AddMilliseconds(-1));

            Console.ReadKey();

            //Comparando datas
            Console.Clear();

            data = DateTime.Now;


            // essa comparação compara a estrutura inteira, até os milisegundos.
            if (data == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }
            else
            {
                Console.WriteLine("Não é igual");
            }


            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }
            else
            {
                Console.WriteLine("Não é igual");
            }

            Console.WriteLine(data);


            //Culture info
            //exibir ou capturar data hora por cultura
            Console.Clear();
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var us = new CultureInfo("en-Us");
            var uk = new CultureInfo("en-UK");
            var de = new CultureInfo("de-DE");
            Console.WriteLine("Culture Info");
            Console.WriteLine(DateTime.Now.ToString(de));
            Console.WriteLine(DateTime.Now.ToString(us));
            Console.WriteLine(DateTime.Now.ToString("f", de));

            //mostrando cultura do sistema
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(atual);

            Console.ReadLine();

            //Timezone
            Console.Clear();

            //hora global
            var dateTime = DateTime.UtcNow;

            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);

            //tranformando hora global, em hora local
            Console.WriteLine(dateTime.ToLocalTime());

            //Escolhendo o formato onde está o usuário:
            //outro região
            /*
                        var timeZoneNepal =
                        TimeZoneInfo.FindSystemTimeZoneById("Nepal/Standard");
                        Console.WriteLine(timeZoneNepal);*/

            Console.ReadKey();
            Console.Clear();
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var zone in timezones)
            {
                Console.WriteLine(zone.Id);
                Console.WriteLine(zone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, zone));
                Console.WriteLine("---------------");
            }


            ///Time Span é um formato de horá mais precisa, usada para realizar calculos com horas.
            //muito usado com entrada e saida de funcionario
            Console.ReadKey();
            Console.Clear();






        }
    }
}
