using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaxiNode
    {
        public Taxi Taxi { get; set; }
        public TaxiNode Next { get; set; }

        public TaxiNode(Taxi taxi)
        {
            Taxi = taxi;
            Next = null;
        }

        private TaxiNode head;

        // Метод добавления нового такси в список
        public void AddTaxi(Taxi taxi)
        {
            TaxiNode newNode = new TaxiNode(taxi);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                TaxiNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Метод для поиска доступного такси
        public Taxi FindAvailableTaxi()
        {
            TaxiNode current = head;
            while (current != null)
            {
                if (current.Taxi.Available)
                {
                    return current.Taxi;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
