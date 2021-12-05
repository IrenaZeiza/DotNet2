using System;

namespace CSharp.Activity.Collections
{
    public class CustomerInfo : CustomerInfoCollection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int ID { get; set; } //Property to get or set the customer ID.
        string Name { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        CustomerInfo(int id, string name, string address, string email) //– Constructor to 
                                                                        //initialize the member variables
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;



        }
    }


    public class CustomerInfoCollection
    {

           
        public Array [] collection;

        //  public int Capacity = collection.Size;
        public int Add(string CustomerInfo, int collection) //Method to add the 
                                                            //CustomerInfo object to the collection.This method should 
                                                            //throw an ArgumentNullException if the input argument is null.
                                                            //It should return the index at which the argument was added to
                                                            //the collection or -1 if the object already is in the collection.
        {

            for (int i = 0; i < collection; i++)
            {
                //Check if the argument at the current index is equal to the input argument
                if (this.Equals(CustomerInfo))
                {
                    return -1;
                }
                else if (CustomerInfo == null)
                {

                    throw new ArgumentNullException("Input value cannot be null");


                else



                        return i;



                }
            }
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

            public int IndexOf(string CustomerInfo, int index, int collection)
            // Method to find the index 
            //of the input CustomerInfo object in the collection.This method
            //should throw an ArgumentNullException if the input argument
            //is null. This should return the index at which the argument can
            //be found in the collection or -1 if the object can’t be found in the
            //collection.
            {
                for (int i = 0; i > collection; i++)
                {
                    if (argToFind.Equals(storeArray[i]))

                        return i;
                }



                return NOT_IN_STRUCTURE;

                if (this.Equals(CustomerInfo))
                {
                    return index;
                }
                else if (CustomerInfo == null)
                {

                    throw new ArgumentNullException("Input value cannot be null");
                }
                else



                    return -1; ;
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

        public CustomerInfo T this[int index, int collection]
    {
        //            indexer property. It
        //should get the CustomerInfo object from the collection at the
        //specified index or set the new CustomerInfo object at the
        //specified index(by making sure the index is within valid range,
        //the new object is not null and doesn’ t belong to the collection
        //already).

        get
        {
            if ((index< 0) || (index >= collection))
                throw new IndexOutOfRangeException("Invalid Index");


            return collection index;
    }
    protected set
        {
            this.storeArray[index] = value;
        }
}






