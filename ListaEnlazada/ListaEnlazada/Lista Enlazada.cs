using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ListaEnlazada
{
    internal class Lista_Enlazada
    {
        public node Head;

        public node lastnode(node cola) 
        {
            if (cola.next == null)
            {
                return cola;
            }
            else 
            {
                return lastnode(cola.next);
            }
        }

        public void addhead(node newhead)
        {

            if (Head == null)
            {
                Head = newhead;
            }
            else 
            {
                node change = Head; 
                Head = newhead;
                Head.next = change; 
            }
        }

        public void addcola(node newhead)
        {
            if (Head == null)
            {
                Head = newhead;
            }
            else 
            {
                node change = lastnode(Head);
                change.next = newhead;
            }
           
        }

        public void addInGivenPosition(int newn, int position)
        {
            node newNode = new node();
            newNode.data = newn;
            newNode.next = null;

            if (position < 1)
            {
                Console.Clear();
                Console.Write("La posicion debe ser mayor o igual a 1");
                Console.ReadLine();
            }
            else if (position == 1)
            {
                newNode.next = Head;
                Head = newNode;
            }
            else
            {

                node temp = new node();
                temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Clear();
                    Console.Write("El nodo previo al que fue señalado es null");
                    Console.ReadLine();
                }
            }
        }

        public void removeAll() 
        {
            
                node temp = new node();
                while (Head != null)
                {
                    temp = Head;
                    Head = Head.next;
                    temp = null; 
                }
           
        }

        public void removeOneNode(int pos)
        {
            if (pos < 1)
            {
                Console.Write("La posicion debe ser mayor o igual a 1");
                Console.ReadLine();
            }
            else if (pos == 1 && Head != null)
            {
                node nodeToDelete = Head;
                Head = Head.next;
                nodeToDelete = null;
  
            }
            else
            {
                node temp = new node();
                temp = Head;
                for (int i = 1; i < pos - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("El nodo no existe");
                   
                    Console.Read();
                }
            }
        }

        public void PrintList()
        {
            node temp = new node();
            temp = this.Head;
            int num = 1;
            if (temp != null)
            {
                Console.WriteLine("La lista contiene los siguientes datos: ");
                while (temp != null)
                {
                    Console.WriteLine(num +". " + temp.data);
                    temp = temp.next;
                    num++;
                }
               
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

    }
}
