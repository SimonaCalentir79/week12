using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public class Exercise01
    {
        public static SingleLinkedList<int> listOfIntegers()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.InsertFront(list, 11);
            list.InsertLast(list, 12);
            list.InsertLast(list, 13);
            list.InsertLast(list, 14);
            list.InsertLast(list, 15);

            return list;
        }

        public static SingleLinkedList<string> listOfStrings()
        {
            SingleLinkedList<string> list = new SingleLinkedList<string>();
            list.InsertFront(list, "unsprezece");
            list.InsertLast(list, "doisprezece");
            list.InsertLast(list, "treisprezece");
            list.InsertLast(list, "paisprezece");
            list.InsertLast(list, "cincisprezece");

            return list;
        }
    }



    
}
