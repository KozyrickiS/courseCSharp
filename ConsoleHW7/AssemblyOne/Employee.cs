using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        public string name;
        public string lastname;
        public DateTime BirthDate;
        public DateTime dateOfEmployment;
        private const string position = "Employee";

        public const string CompanyNamePublic = "ООО Печенька";
        protected const string CompanyNameProtected = "ООО Протектед Печенька";
        internal const string CompanyNameInternal = "ООО Интернал Печенька";
        protected internal const string CompanyNameProtInternal = "ООО Протектед Интернал Печенька";
        private const string CompanyNamePrivate = "ООО Приват Печенька";
        private protected const string CompanyNamePrivProtected = "ООО Приват Протектед Печенька";

        void GetInfo()   // used only in AssemblyOne project
        {
            if ((lastname != null) && (name != null))
            {
                Console.WriteLine($"Name: {name}, Lastname: {lastname}, age {Age()}");
            }
            else
            {
                Console.WriteLine("We don't have employee");
            }
        }
        public virtual void GetInfoAboutEmployment()    // used in all projects
        {
            if ((lastname != null) && (name != null))
            {
                Console.WriteLine($"Employee {lastname} {name} in company {CompanyNamePublic} since {dateOfEmployment}");
            }
            else
            {
                Console.WriteLine("We don't have employee");
            }
        }
        public virtual void AddEmployee()    // used in all projects
        {
            Console.WriteLine("Enter the name of new employee: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the lastname of new employee: ");
            lastname = Console.ReadLine();
            dateOfEmployment = DateTime.Now;
            Console.WriteLine("Enter the birthdate of new employee like 'dd.mm.yyyy': ");
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
            Console.WriteLine($"Employee {lastname} {name} is registered in \"{CompanyNamePublic}\"");
        }
        public virtual void GetConst()    // used in all projects
        {
            Console.WriteLine($"Public const CompanyNamePublic: {CompanyNamePublic} is available in class {position}");
            Console.WriteLine($"protected const CompanyNameProtected: {CompanyNameProtected} is available in class {position}");
            Console.WriteLine($"internal const CompanyNameInternal: {CompanyNameInternal} is available in class {position}");
            Console.WriteLine($"protected internal const CompanyNameProtInternal: {CompanyNameProtInternal} is available in class {position}");
            Console.WriteLine($"private const CompanyNamePrivate {CompanyNamePrivate} is available in class {position}");
            Console.WriteLine($"private protected const CompanyNamePrivProtected: {CompanyNamePrivProtected} is available in class {position}");
        }
        public int Age()    // used in all projects
        {
            int age = Convert.ToInt32(DateTime.Now.Year - BirthDate.Year); ;
            if ((BirthDate.Month > DateTime.Now.Month) || (BirthDate.Month == DateTime.Now.Month && BirthDate.Day >= DateTime.Now.Day))
            {
                age -= 1;
            }            
            return age;
        }
    }
}
