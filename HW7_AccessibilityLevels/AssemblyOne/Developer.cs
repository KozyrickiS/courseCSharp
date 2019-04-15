using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Developer : Employee
    {
        private const string Position = "Developer";
        public override void GetInfoAboutEmployment()
        {
            if ((lastname != null) && (name != null))
            {
                AddDeveloper();
            }
            else
            {
                Console.WriteLine($"Developer {lastname} {name} in company {CompanyNamePublic} since {dateOfEmployment}");
            }
        }

        public override void AddEmployee()
        {
            Console.WriteLine("Enter the name of new developer: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the lastname of new developer: ");
            lastname = Console.ReadLine();
            dateOfEmployment = DateTime.Now;
            Console.WriteLine("Enter the birthdate of new developer like 'dd.mm.yyyy': ");
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
            Console.WriteLine($"Developer {lastname} {name} is registered in \"{CompanyNamePublic}\"");
        }
        public override void GetConst()
        {
            Console.WriteLine($"Public const CompanyNamePublic: {CompanyNamePublic} is available in inheritor class {Position}");
            Console.WriteLine($"protected const CompanyNameProtected: {CompanyNameProtected} is available in inheritor class {Position}");
            Console.WriteLine($"internal const CompanyNameInternal: {CompanyNameInternal} is available in inheritor class {Position}");
            Console.WriteLine($"protected internal const CompanyNameProtInternal: {CompanyNameProtInternal} is available in inheritor class {Position}");
            Console.WriteLine($"private const CompanyNamePrivate is not available in inheritor class {Position}");
            Console.WriteLine($"private protected const CompanyNamePrivProtected: {CompanyNamePrivProtected} is available in inheritor class {Position}");
        }
        private void AddDeveloper()   // used only in this class
        {
            Console.WriteLine($"Add developer. Try to use method .AddEmployee()");
        }
    }
}
