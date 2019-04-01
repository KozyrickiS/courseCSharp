using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class Manager : Employee
    {
        private const string position = "Manager";

        public override void GetInfoAboutEmployment()
        {
            if ((lastname != null) && (name != null))
            {
                Console.WriteLine($"Manager {lastname} {name} in company {CompanyNamePublic} since {dateOfEmployment}");
            }
            else
            {
                Console.WriteLine("We don't have manager");
            }            
        }
        public override void AddEmployee()
        {
            Console.WriteLine("Enter the name of new manager: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the lastname of new manager: ");
            lastname = Console.ReadLine();
            dateOfEmployment = DateTime.Now;
            Console.WriteLine("Enter the birthdate of new manager like 'dd.mm.yyyy': ");
            string birth = Console.ReadLine();
            if (DateTime.TryParse(birth, out BirthDate))
            {
                BirthDate = Convert.ToDateTime(birth);
            }
            else
            {
                Console.WriteLine($"Incorrent date. Please, change the birthdate later");
                BirthDate = Convert.ToDateTime("01.01.1900");
            }
            Console.WriteLine($"Manager {lastname} {name} is registered in \"{CompanyNamePublic}\"");
        }
        public override void GetConst()
        {
            Console.WriteLine($"Public const CompanyNamePublic: {CompanyNamePublic} is available in inheritor class {position}");
            Console.WriteLine($"protected const CompanyNameProtected: {CompanyNameProtected} is available in inheritor class {position}");
            Console.WriteLine($"internal const CompanyNameInternal is not available in inheritor class {position}");
            Console.WriteLine($"protected internal const CompanyNameProtInternal: {CompanyNameProtInternal} is available in inheritor class {position}");
            Console.WriteLine($"private const CompanyNamePrivate is not available in inheritor class {position}");
            Console.WriteLine($"private protected const CompanyNamePrivProtected is not available in inheritor class {position}");
        }
    }
}
