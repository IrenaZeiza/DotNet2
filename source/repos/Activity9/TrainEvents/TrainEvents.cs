using System;

namespace TCSharp.Activity.Events
{
    public enum ArrivalStatus
    {
        Arrived,
        Delayed,
        Cancelled

    }

    public class ArrivalEventArgs
    {


        public ArrivalEventArgs(int num, ArrivalStatus status, DateTime time)
        {
            //– Constructor for the event data class. Use this 
            //constructor to initialize the member variables.
        }

        public int TrainNumber { get; private set; }
        //Public property to return the train 
        // number and private setter to change it
        public ArrivalStatus ArrivalStatus { get; private set; }
        //Public property to return 
        //the arrival status of the train and private setter to change it
        public DateTime ArrivalTime { get; private set; }   //Public property to return the 
                                                            //new arrival time and private setter to change it.
    }

    public class TrainStation


    {
        // public event ArrivalEventArgs Arrival;
        //  private event MyEventDel MyEvent;
    
        public delegate void ArrivalEventArgs (object source, EventArgs args);

        public event EventHandler<ArrivalEventArgs> Arrival; //– The 
                                                             //event field declaration.
       public void ArrivalHandler(object sender, ArrivalEventArgs args)
        {

        }

        protected void OnArrival(ArrivalEventArgs e)
        {

            this.Arrival = Arrival;

        }
        static void Main(string[] args)

        {

           int train;

           ArrivalStatus arrivalStatus; 
           DateTime arrivalTime;

            TrainStation obj = new TrainStation();


            obj.AnnounceArrival(int train, ArrivalStatus arrivalStatus, DateTime arrivalTime);
           
            //   Console.WriteLine(Arrival);

        }


        public static bool Equals(DateTime arrivalTime, DateTime scheleduedTime) 
        {
           if (scheleduedTime.Equals(arrivalTime))
           {

               return true;
            }
           else
            { 
                return false;
            }
        }
        public void AnnounceArrival(int train, ArrivalStatus arrivalStatus, DateTime arrivalTime)
        {

       

            if (this.Equals(arrivalTime))
            {
                arrivalStatus = ArrivalStatus.Arrived;

                Console.WriteLine("The train has arrived");

            }


            if (this == null)
            {

                arrivalStatus = ArrivalStatus.Cancelled;
                Console.WriteLine("Train is canceled");
            }
            if (!this.Equals(arrivalTime))
            {
                arrivalStatus = ArrivalStatus.Delayed;
                Console.WriteLine("Train is late");
            }


          


        }

   

    }

            //This method would be 
            //called by the clients.From this method invoke (izsaukt izmantot) the method
            //OnArrival() by passing a new instance (gadijums) of ArrivalEventArgs.
}
    



       
    

