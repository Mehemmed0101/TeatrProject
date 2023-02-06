
using TeatrProject.Enums;
using TeatrProject.Models;
using Core.Models;
using Core.Services.Contracts;


namespace TeatrProject.Services
{

    internal class TicketManager : IPrintService
    {
        public Ticket[] _ticket = new Ticket[10];
        private int _currentIndex = 0;

        public void CreateTicket(Seans seans, int row, int column)
        {
            _ticket[_currentIndex] = new Ticket
            {
                Seans = seans,
                Row = row,
                Column = column
            };

            _currentIndex++;
        }

        public void Print()
        {
            foreach (var item in _ticket)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }
    }
}

