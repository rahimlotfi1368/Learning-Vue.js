using System.Linq;

namespace ViewModels
{
    public class PersonViewModel:object
    {
        public PersonViewModel():base()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}