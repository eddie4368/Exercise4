using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double balance = 1000; //Declares and initailizes a variable named "balance" with the value of 1000.
            while (true)// an infinite loop to continuoslymprompt the user for input until they choose to exit.
            {
                Console.WriteLine("ATM Menu ");// Console.Writeline statement used to display menu options.
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());// Console.Readline Prompts the user to enter a choice.  int choice = int.Parse convertsb user's input(a string) into integer.
                switch (choice)// used to execute different code blocks based on user's choice.
                {
                    case 1:
                        Console.WriteLine("Your balance is: " + balance);// Displays the current balance using Console.WriteLine("Your balance is: " + balance);.
                        break;// break; exits the switch statement. 
                    case 2:
                        Console.WriteLine("Enter Deposit Amount: ");// user to input for  the deposit amount.
                        double depositamount = double.Parse(Console.ReadLine());//reads the user's input as a string and converts it to a double-precision floating-point number.
                        balance += depositamount;// This adds the deposited amount to the current balance. 
                        Console.WriteLine("Deposit sucessful.");// informs the user that the deposit was sucessful.
                        break;// break; exits the switch statement 
                    case 3:
                        Console.WriteLine("Enter Withdrawal Amount: ");// asks the user to input the withdrawal amount .
                        double withdrawalAmount = double.Parse(Console.ReadLine());//reads the user's input as a string and converts it to a double-precision floating-point number
                        if (withdrawalAmount <= balance) //checks if the requested withdrawal amount is less than or equal to the current balance.
                        {
                            balance -= withdrawalAmount;// subtracts the withdrawal amount from the balance.
                            Console.WriteLine("Withdrawal succesful");  //informs  the user that the withdrawal was sucessful.
                        }
                        else//
                        {
                            Console.WriteLine("Insufficeint funds.");// prints a message to the console indicating that user has insufficient funds to perform the withdrawal
                        }
                        break;//exits the current loop or switch statement or switch statement preventing the code from executing any subsequent cases
                        case 4:// case within a switch statement pre to correspond to the exit option.
                        Console.WriteLine("Thank you using the ATM.");//prints a message thanking the user for using the ATM.
                        return;// this statement immmediately terminates the execution of the current method or function, effectively exiting the ATM program.
                        default://default case within the switch statement which excute if none of the previous cases match the value of the choice variable.
                        Console.WriteLine("Invalid choice. Please try again.");//This line prints a message indicating enter a invalid choice.
                        break ;//this statement exits the switch statement after the default case is excuted.
                }
            }
        }
    }
 }
