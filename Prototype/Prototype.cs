using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypeDesignPattren
{
    // EXAMPLE NO.01 
    public class Student:IPrototype   // I have Created a ProtoType Interface and Inherit it.
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        Student()
        {

        }

        Student(string rn,string name,string sec)
        {
            RollNo = rn;
            Name = name;
            Section = sec;
        }

        public IPrototype Clone()  // Now impliments the prototype data member.
        {
            return new Student(RollNo, Name, Section);
        }
        // Driver Function
        public static void Main(string[] args)
        {
            Student st = new Student("BCSF20M006","ARSLAN","COMPUTER SCIENCE");
            // Original Student
            Console.WriteLine("******************** ORIGINAL STUDENT ********************\n");
            Console.WriteLine(st.RollNo +"\n"+ st.Name +"\n"+ st.Section +"\n");
            Student CloneStudent =(Student) st.Clone();
            //Clone Student
            Console.WriteLine("******************** CLONE STUDENT ********************\n");
            Console.WriteLine(CloneStudent.RollNo + "\n" + CloneStudent.Name + "\n" + CloneStudent.Section + "\n");

        }

    }

    // EXAMPLE NO.02
    public class Book:IPrototype
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        Book()
        {

        }
        Book(string iSBN, string bookName, string author)
        {
            ISBN = iSBN;
            BookName = bookName;
            Author = author;
        }

        public IPrototype Clone()
        {
            return new Book(ISBN, BookName, Author);
        }

        public static void main(string[] args)
        {
            Book book = new Book("ABS86614","C++","Dietal");
            Console.WriteLine("********************************** ORIGINAL BOOK **********************************\n");
            Console.WriteLine(book.ISBN +"\n"+ book.BookName +"\n"+ book.Author +"\n");
            Book CloneBook = (Book) book.Clone();
            Console.WriteLine("********************************** CLONE BOOK **********************************\n");
            CloneBook.ISBN = "CDN541207"; //CHANGING THE ISBN NUMBER IN CLONE BOOK
            Console.WriteLine(CloneBook.ISBN + "\n" + CloneBook.BookName + "\n" + CloneBook.Author + "\n");


        }

    }



}
