using System;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // student sam = new student();
            // student john = new student();
            // sam.studentDetails(312, 012345,"Sam","Allardyce", "somewhere in Sambisa");
            // john.studentDetails(382, 678910, "John","Terry", "somewhere in another forest");

            // student sam = new student(312, 012345,"Sam","Allardyce", "somewhere in Sambisa");
            // student john = new student(382, 678910, "John","Terry", "somewhere in another forest");

            // ekene.addNumbers(10,30);

            // equilateralTriangle test = new equilateralTriangle(5,3);
            // test.Area();
            // test.Perimeter();

            Customer oniGbese = new Customer(500,1000);
        }
    }

    public class student
    {
        // public student(int rollNumber, int phoneNumber, string firstName, string lastName, string homeAddress)
        // {
        //     Console.WriteLine($"Student name : {firstName} {lastName} \nRoll number : {rollNumber}\n");
        // }
               
        // public void addNumbers(int firstNumber, int secondNumber)
        // {
        //     int result = firstNumber + secondNumber;
        //     Console.WriteLine(result);
        // }

        public void studentDetails(int rollNumber, int phoneNumber, string firstName, string lastName, string homeAddress)
        {
            Console.WriteLine($"Student name : {firstName} {lastName} \nRoll number : {rollNumber} \nPhone number : {phoneNumber} \nAddress : {homeAddress}\n");
        }
    }


    public class equilateralTriangle
    {
        double _baseLength;
        double _height;
 
        public equilateralTriangle(double baseLenght, double height)
        {
            _baseLength = baseLenght;
            _height = height;
            
        }

        public void Area()
        {
            double result = (0.5 * _baseLength) * _height;
            Console.WriteLine($"The area of the triangle is {result}");
        }

        public void Perimeter()
        {
            double result = 3*(_baseLength);
            Console.WriteLine($"The perimeter of the equilateral triangle is {result}");
        }
    }

    class Customer
    {
        int _userBalance;
        public Customer(int credit, int debit)
        {
            this._userBalance = 1000;
            Credit(credit);
            Debit(debit);
            Console.WriteLine($"Your balance is {this._userBalance}");
        }
        private void Credit(int addMoney)
        {
            this._userBalance += addMoney;
        }

        private void Debit(int removeMoney)
        {
            this._userBalance -= removeMoney;
        }
    }
}
