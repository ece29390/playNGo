using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Data
{
    internal static class SeederHelper
    {
        public static List<Person> CreateInitialListOfPerson()
        {
            var persons = new List<Person>
            {
                new Person{FirstName="Stephen",LastName="Curry",PhoneNumber="(508) 972-3449" }
                ,new Person{FirstName="Kevin", LastName="Durant",PhoneNumber="(348) 934-7082"}
                ,new Person{FirstName="Draymond", LastName="Green", PhoneNumber="(882) 616-2107" }
                ,new Person{FirstName="Andre", LastName="Iguodala", PhoneNumber="(256)450-2380" }
                ,new Person{FirstName="Klay", LastName="Thompson", PhoneNumber="(714)534-8549" }
                ,new Person{FirstName="Quinn", LastName="Cook", PhoneNumber="(254)791-1556" }
                ,new Person{FirstName="Nick", LastName="Young", PhoneNumber="(224)568-9616" }
                ,new Person{FirstName="Patrick", LastName="McCaw", PhoneNumber="(520)891-6860" }
                ,new Person{FirstName="Shaun", LastName="Livingston", PhoneNumber="(423)707-8538" }
                ,new Person{FirstName="Jordan", LastName="Bell", PhoneNumber="(317)498-2531" }
                ,new Person{FirstName="Zaza", LastName="Pachulia", PhoneNumber="(551)404-1626" }
                ,new Person{FirstName="Omri", LastName="Casspi", PhoneNumber="(209)571-7094" }
                ,new Person{FirstName="Kevin", LastName="Looney", PhoneNumber="(215)496-6113" }
                ,new Person{FirstName="David", LastName="West", PhoneNumber="(567)217-6959" }
                ,new Person{FirstName="JaVale", LastName="McGee", PhoneNumber="(574)263-8444" }
                ,new Person{FirstName="Damian", LastName="Jones", PhoneNumber="(401)451-2438" }
                ,new Person{FirstName="Chris", LastName="Boucher", PhoneNumber="(704)464-7904" }

                ,new Person{FirstName="Rodney", LastName="Hood", PhoneNumber="(479)717-7826" }
                ,new Person{FirstName="Larry Jr.", LastName="Nance", PhoneNumber="(563)222-7186" }
                ,new Person{FirstName="Kevin", LastName="Love", PhoneNumber="(409)838-1865" }
                ,new Person{FirstName="Tristan", LastName="Thompson", PhoneNumber="(703)589-4095" }
                ,new Person{FirstName="Jordan", LastName="Clarkson", PhoneNumber="(563)872-3865" }
                ,new Person{FirstName="LeBron", LastName="James", PhoneNumber="(202)801-1320" }
                ,new Person{FirstName="J.R.", LastName="Smith", PhoneNumber="(718)651-3536" }
                ,new Person{FirstName="Ante", LastName="Zizic", PhoneNumber="(304)662-5216" }
                ,new Person{FirstName="Jose", LastName="Calderon", PhoneNumber="(575)942-3850" }
                ,new Person{FirstName="George", LastName="Hill", PhoneNumber="(216)670-3624" }
                ,new Person{FirstName="Kyle", LastName="Korver", PhoneNumber="(347)605-4314" }
                ,new Person{FirstName="Cedi", LastName="Osman", PhoneNumber="(270)706-3336" }
                ,new Person{FirstName="London", LastName="Perantes", PhoneNumber="(620)246-5360" }
                ,new Person{FirstName="John", LastName="Holland", PhoneNumber="(302)448-1413" }
                ,new Person{FirstName="Okaro", LastName="White", PhoneNumber="(313)893-2332" }
                ,new Person{FirstName="Kendrick", LastName="Perkins", PhoneNumber="(479)717-8097" }
            };
            return persons;
        }
    }
}
