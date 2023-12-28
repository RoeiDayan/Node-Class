using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace Node_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(node(5));


        }
        public static Node<int> NodesListUp(int n)
        {
            Node<int> LastNode = null;
            for (int i = n; i >= 1; i--)
            {
                Node<int> newNode = new Node<int>(i, LastNode);
                LastNode = newNode;
            }
            return LastNode;
        }

        public static Node<int> NodesListDown(int n)
        {
            Node<int> LastNode = null;
            for (int i = 1; i <= n; i++)
            {
                Node<int> newNode = new Node<int>(i, LastNode);
                LastNode = newNode;
            }
            return LastNode;
        }

        public static Node<int> node(int n)
        {
            return node(n, null);
        }
        public static Node<int> node(int n, Node<int> last)
        {
            if (n == 0)
            {
                return last;
            }
            Node<int> newNode = new Node<int>(n, last);
            return node(n-1, newNode);
        }


        
    }
}
