using CSharp.Activity.Collections;
using System;
using System.Collections.Generic;


namespace CSharp.Activity.Collections
{
    public class CustomerInfo
    {
       

        public int ID { get; set; } //Property to get or set the customer ID.
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public CustomerInfo(int id, string name, string address, string email) //– Constructor to 
                                                                               //initialize the member variables
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;

        }

   
       
        }
        
    }
      

       


    


public class CustomerInfoCollection 
{

   int []  collection = new int[10];
  

    public int Capacity
       => collection.Length;

  
    public int Add(string CustomerInfo, int Capacity, int index) //Method to add the 
                                                      //CustomerInfo object to the collection.This method should 
                                                      //throw an ArgumentNullException if the input argument is null.
                                                      //It should return the index at which the argument was added to
                                                      //the collection or -1 if the object already is in the collection.
    {

        for (int i = 0; i < this.Capacity; i++)
        {
            //Check if the argument at the current index is equal to the input argument
            if (this.Equals(CustomerInfo))
            {
                return -1;
            }
            else if (CustomerInfo == null)
            {

                throw new ArgumentNullException("Input value cannot be null");
            }



            else return i;
        }

        return index;

        
    }






        public void Insert(int index, string CustomerInfo)
        {


            if (CustomerInfo == null)
            {

                throw new ArgumentNullException("Input value cannot be null");

            }


            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("The CustomerInfo is out of range");
            }

            else if (this.Equals(CustomerInfo))


                return;
            // Method to insert the 
            //CustomerInfo object at the specified index in the collection.
            //This method should throw an ArgumentNullException if the
            //input CustomerInfo object is null and
            //ArgumentOutOfRangeException exception if the index at
            //which to insert the object is less than zero.If the object to be
            //inserted already is present in the collection, do nothing
        }




        public void Remove(string CustomerInfo)
        {
            //Method to remove the 
            //            CustomerInfo object from the collection. This method should
            //throw an ArgumentNullException if the input argument is null.



            if (CustomerInfo.Equals(null))
            {
                throw new ArgumentNullException("Input argument can' t be null");
            }


        }


        public bool Contains(string CustomerInfo)
        {
            /*Method to check if the 
        input CustomerInfo object exists in the collection. This method 
     should throw an ArgumentNullException if the input argument 
        is null. It should return true if the input object exists in the 
        collection and false otherwise.*/

            if (CustomerInfo == null)
            {

                throw new ArgumentNullException("Input value cannot be null");

            }
            if
              (this.Equals(CustomerInfo))


                return true;

            else

                return false;
        }

        public int IndexOf(string CustomerInfo, int index)
        // Method to find the index 
        //of the input CustomerInfo object in the collection.This method
        //should throw an ArgumentNullException if the input argument
        //is null. This should return the index at which the argument can
        //be found in the collection or -1 if the object can’t be found in the
        //collection.
        {
            for (int i = 0; i > this.Capacity; i++)
            {
                if (this.Equals(CustomerInfo))

                    return i;


                else if (CustomerInfo == null)
                {

                    throw new ArgumentNullException("Input value cannot be null");
                }
                else



                    return -1;
            }

        return index;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
    }

        //            indexer property. It
        //should get the CustomerInfo object from the collection at the
        //specified index or set the new CustomerInfo object at the
        //specified index(by making sure the index is within valid range,
        //the new object is not null and doesn’ t belong to the collection
        //already).

        public CustomerInfo this[int index]


    {

        get

        {
            if ((index < 0) || (index >= this.Capacity))

                throw new IndexOutOfRangeException("Invalid Index");


            return this[index];
        }


        protected set

        {
            this[index] = value;
        }
    }
}














