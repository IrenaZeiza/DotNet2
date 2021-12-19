using System;
using static CSharp.Activity.Delegates.LoanSystem;

namespace CSharp.Activity.Delegates
{
    public class LoanApplicant
    {



        private string name;
     
        public string Applicant
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class LoanSystem
    {
            
        public static double ProcessLoanApplication(double CreditScore)
        {
            Console.WriteLine(CreditScore);
            return CreditScore;
        }


       public delegate void LoanApplicant();
       public void ProcessLoanApplication(LoanApplicant loanApplicant, showApplicant showApplicant)   //– the method that ar  //parameter takes delegate instance,
                                                                                //creates a LoanApplicant
        {
          
        }                                    //instance, assigns the credit score and then invokes the delegate
                                             //Note: For the scope of this activity, generate a random number 

        // parameter takes delegate instance, creates a LoanApplicant
        // instance, assigns the credit score and then invokes the delegate
        // showApplicant.
        public static System.Random DefaultRandom { get; set; } = new System.Random();

        //between 1 and 100 and use it as the credit score.


        public delegate void showApplicant(string value);
    }

    public class Program : LoanSystem
    {
        public delegate double GetCreditScore(double CreditScore);
        static void Main(string[] args)
        {



  
          

            var getCreditScore = new GetCreditScore(ProcessLoanApplication);
          Console.WriteLine("Your creditscore is:");
            getCreditScore(new Random().Next(1, 100));

         



        }
        public static void Show(LoanApplicant loanApplicant)    //to display the credit score of the applicant on the //console
                                                                //(Note: Its signature complies to the delegate Action
                                                                //<LoanApplicant>.). In method Main instantiate the class
                                                                //LoanSystem and demonstate loan application processing by calling
                                                                //the method ProcessLoanApplication() and providing the method
                                                                //Show as the ‘callback’ method
        {

          
         
        


        }

    }
}

















