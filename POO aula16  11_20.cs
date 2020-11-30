using  System;

//criando a classe "employee"
class Employee
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Employee()
        {
        }

        public Employee(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorPorHora;
        }
    }
    
//criando a classe "employer"
class Employee
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Employee()
        {
        }

        public Employee(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorPorHora;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            //quantidade de funcionarios
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
               
            //informaçoes sobre o funcionario
               
            Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por houra: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    //Adicional
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }




            Console.WriteLine();
            //Pagamentos
            Console.WriteLine("Payments:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

           Console.ReadKey();
        }
    }
}
