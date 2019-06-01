using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bollywood
{
    public class LinkedList :LinkedListADT
    {
        public object[] musteri;
        public LinkedList(int size)
        {
            musteri = new object[size];
            for (int i = 0; i < 60; i++)
            {
                Node oldLast = Head;
                Node newLast = new Node
                {
                    Data = i + 1
                };
                if (Head == null)
                    Head = newLast;
                else
                {
                    newLast.Data = i + 1;
                    while (oldLast != null)
                    {
                        if (oldLast.Next != null)
                            oldLast = oldLast.Next;
                        else
                            break;
                    }
                    oldLast.Next = newLast;
                }
            }
        }
        public override bool DeletePos(int position)
        {
            Node tmpHead = Head;
            for (int i = 0; i < position; i++)
            {
                tmpHead = tmpHead.Next;
            }
            if (tmpHead.kontrol == true)
            {
                tmpHead.kontrol = false;
                return true;
            }
            else
                return false;


        }

        public override Node GetElement(int position)
        {
            Node tempHead = Head;
            for (int i=0;i<position;i++)
            {
                tempHead = tempHead.Next;

            }
            return tempHead;

        }

        public override void InsertPos(int position, int value)
        {
            Node headtmp = Head;
            
            for(int i=0;i<position;i++)
            {
                headtmp = headtmp.Next;
            }
            headtmp.kontrol = true;




        }
    }
}

