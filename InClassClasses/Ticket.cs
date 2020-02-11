using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassClasses
{
    class Ticket
    {
        //properties
        public string Name { get; set; }

        //Methods
        public void ReadFile()
        {

        }
        public void WriteFile()
        {

        }
        public void CheckInput()
        {

        }
        public void DisplayMenu()
        {

        }
        public void GetFileIndex()
        {

        }
    }
    class Ticket2
    {
        public int Number { get; set; }

        public string Description { get; set; }

        public DateTime ExpirationDAte { get; set; }

        public Boolean IsValid()
        {
            return true;
        }

    }
    class TicketManager
    {
        Ticket ticket = new Ticket();
    }
}
