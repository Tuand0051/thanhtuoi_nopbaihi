using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Entity
{
    class Contact
    { 
   public string firstName { get; set; }
    public string lastName { get; set; }
    public string avatar { get; set; }

    public Contact(string firstName, string lastName, string avatar)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.avatar = avatar;
    }

    public Contact()
    {
        this.avatar = "Assets/male-01.png";
    }
}
}