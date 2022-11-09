using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jaime",3);
            Person person2 = new Person("Maite",5);
            Person person3 = new Person("Jorge",32);
            Person person4 = new Person("Matilde",31);
            Person person5 = new Person("Camila",19);
            Person person6 = new Person("Hebert",46);
            Person person7 = new Person("Marta",41);
            Person person8 = new Person("Hectorrrrrr",84);

            Node n1 = new Node(1,person1);
            Node n2 = new Node(2,person2);
            Node n3 = new Node(3,person3);
            Node n4 = new Node(4,person4);
            Node n5 = new Node(5,person5);
            Node n6 = new Node(6,person6);
            Node n7 = new Node(7,person7);
            Node n8 = new Node(8,person8);

            n8.AddChildren(n6);
            n8.AddChildren(n4);
            n7.AddChildren(n5);
            n6.AddChildren(n5);
            n4.AddChildren(n2);
            n4.AddChildren(n1);
            n3.AddChildren(n2);
            n3.AddChildren(n1);

            Visitor visitor = new Visitor();
            visitor.SumarEdad(n1.Person);
            visitor.SumarEdad(n2.Person);
            visitor.SumarEdad(n3.Person);
            visitor.SumarEdad(n4.Person);
            visitor.SumarEdad(n5.Person);
            visitor.SumarEdad(n6.Person);
            visitor.SumarEdad(n7.Person);
            visitor.SumarEdad(n8.Person);

            visitor.PersonaMasVieja(n1.Person);
            visitor.PersonaMasVieja(n2.Person);
            visitor.PersonaMasVieja(n3.Person);
            visitor.PersonaMasVieja(n4.Person);
            visitor.PersonaMasVieja(n5.Person);
            visitor.PersonaMasVieja(n6.Person);
            visitor.PersonaMasVieja(n7.Person);
            visitor.PersonaMasVieja(n8.Person);

            visitor.NombreMasLargo(n1.Person);
            visitor.NombreMasLargo(n2.Person);
            visitor.NombreMasLargo(n3.Person);
            visitor.NombreMasLargo(n4.Person);
            visitor.NombreMasLargo(n5.Person);
            visitor.NombreMasLargo(n6.Person);
            visitor.NombreMasLargo(n7.Person);
            visitor.NombreMasLargo(n8.Person);

            Console.WriteLine(visitor.suma);

            Console.WriteLine(visitor.mayor);

            Console.WriteLine(visitor.nombreLargo);

            // visitar el árbol aquí
        }
    }
}
