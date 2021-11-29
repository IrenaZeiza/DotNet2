
using System;
using System.Collections.Generic;

namespace CSharp.Activity.Datastore
{



    public class ArrayStore<T> : AbstractArrayStore<T>
    {
        public ArrayStore(int arraySize) : base(arraySize)
        {
        }


    public override int Add(T argToAdd) //public override int Add(T argToAdd) – Adds the object ‘argToAdd’ to the end of the structure on the condition that
                                        //the structure isn’t full.
                                        //It returns the index if the add is successful or NOT_IN_ STRUCTURE if the conditions for adding are not met.
                                        // If T is reference type, trying to add a null object to the structure should throw an ArgumentNullException.
    {


        //this[0] = argToAdd;
        //return 1;





        if (this.Count >= Capacity)
        {
            return NOT_IN_STRUCTURE;
        }

        else if (!typeof(T).IsValueType && argToAdd == null)
        {

            throw new ArgumentNullException("arg", "Input value cannot be null");
        }

        else

         this[Count++] = argToAdd;
        return Count;

    }


    //start solution
    //    public override void RemoveAt(int removeObjectIndex)






    // Removes the object at the specified index. Make sure to compress the array so that no holes remain in the structure.
    //  If the index is out of range [0..Count) the method should throw an ArgumentOutOfRangeException.


    public override int Insert(T argToInsert, int indexToInsert)
    {




        if (this.Count >= Capacity)

        {
            return NOT_IN_STRUCTURE;
        }



        else if (!typeof(T).IsValueType && argToInsert == null)
        {

            throw new ArgumentNullException("Input value cannot be null");
        }
        else if (indexToInsert < 0 || indexToInsert > Capacity)
        {

            throw new ArgumentOutOfRangeException("Argument is out of range ");

        }




        else return indexToInsert;


        throw new NotImplementedException();



        //This inserts the object argToInsert at the specified index. As with Add(T argToAdd) method, the structure must not be full.
        //Trying to add a null object should throw an ArgumentNullException, or if inserting with an invalid index (outside range [0..Count))
        //then should throw an ArgumentOutOfRangeException.
        //Return index if the insert is successful and NOT_IN_ STRUCTURE if the conditions for insertion are not met.
    }

    public override void Remove(T argToRemove) //not valid due to current state of the object
    {

        for (int i = 0; i < this.Count; i++)
        {
                //Check if the argument at the current index is equal to the input argument
                if (this[i].Equals(argToRemove))
                {
                    Count--;
                }
                else if (!typeof(T).IsValueType && argToRemove == null)
                {

                    throw new ArgumentNullException("Input value cannot be null");
                }
                else


                    for (int j = 0; j < this.Count - 1; j++)
                    this[j] = this[j + 1];

        }

        //
        //  Removes the object that is equal to argToRemove from the structure.
        //  Make sure to compress the data inside so that there are no holes in the array after a successful remove.
        //  (You can make use of the existing base class method IndexOf() and/or the overrided method RemoveAt()).
        //  Throw an InvalidOperationException if removal is not possible.
        //  Throw an ArgumentNullException if a null is passed and T is a reference type.


        throw new InvalidOperationException();
    }

    public override void RemoveAt(int removeObjectIndex)
    {
        int index = 0;

        if (this.IsEmpty())
        {
            throw new InvalidOperationException("Impossible to remove.");
        }

        if (index < 0 || index > Capacity)

        {
            throw new InvalidOperationException("index");
        }
        else


            for (int i = 0; i < this.Count - 1; i++)
                this[i] = this[i + 1];



        throw new ArgumentOutOfRangeException();
    }

}                                   //If T is reference type, trying to add a null object to the structure should throw an ArgumentNullException.




/// <summary>
/// Summary description for AbstractArrayStore.
/// </summary>
public abstract class AbstractArrayStore<T>
{
    string[] ArrayStore = new string[DEFAULT_SIZE];


    //This is a constant that represents the code value returned when an object cannot be found in the array
    public const int NOT_IN_STRUCTURE = -1;

    //This is a constant that represents the default size of the array
    public const int DEFAULT_SIZE = 5;

    //This is the actual structure that the class uses to store objects
    private T[] storeArray;



    /// <summary>
    /// Returns the maximum size of an array.
    /// </summary>
    public int Capacity
        => this.storeArray.Length;

    /// <summary>
    /// Counts the number of objects currently inside the array.
    /// </summary>
    public int Count { get; protected set; }

    #region Abstract Methods - To be implemented in derived class

    /// <summary>
    /// Adds an object to the the data structure.
    /// </summary>
    /// <param name="argToAdd">The object to be added.</param>
    /// <returns>Returns NOT_IN_STRUCTURE if array is full, or added element index if addition succeeded.</returns>
    public abstract int Add(T argToAdd);

    /// <summary>
    /// Removes an object from the specified location in the data structure.
    /// </summary>
    /// <param name="removeObjectIndex">The index from which the object has to be removed.</param>
    /// <returns>Throws InvalidOperationException if removal is not possible.</returns>
    public abstract void RemoveAt(int removeObjectIndex);

    /// <summary>
    /// Removes an object from the data structure.
    /// </summary>
    /// <param name="argToRemove">The object to be removed.</param>
    /// <returns>Throws InvalidOperationException if removal is not possible.</returns>
    public abstract void Remove(T argToRemove);

    /// <summary>
    /// Inserts an object at the specified location in the data structure.
    /// </summary>
    /// <param name="argToInsert">The object to be inserted.</param>
    /// <param name="indexToInsert">The index at which the object is to be inserted.</param>
    /// <returns>Returns NOT_IN_STRUCTURE if array is full, or added element index if addition succeeded.</returns>
    public abstract int Insert(T argToInsert, int indexToInsert);

    #endregion Abstract Methods - To be implemented in derived class

    /// <summary>
    /// Default constructor. Initializes the array to the default size.
    /// </summary>
    public AbstractArrayStore() : this(DEFAULT_SIZE)
    {
        //No logic
    }

    /// <summary>
    /// Constructor which takes an integer argument and initializes the array with the input argument.
    /// </summary>
    /// <param name="arraySize">Size for which the array has to be initialized.</param>
    public AbstractArrayStore(int arraySize)
    {
        //Initializes the array to the specified size if it is greater than zero.
        //Else initializes to the default size
        this.storeArray = new T[arraySize > 0 ? arraySize : DEFAULT_SIZE];
    }

    /// <summary>
    /// Checks if the array is empty or not.
    /// </summary>
    public bool IsEmpty()
        => (this.Count <= 0);

    /// <summary>
    /// Method to check if the array is completely filled or not.
    /// </summary>
    /// <returns>A boolean value
    ///            - True if the array is full
    ///            - False otherwise.
    /// </returns>
    public bool IsFull()
        => (this.Count == this.storeArray.Length);

    /// <summary>
    /// Method to check if an object is in the data structure.
    /// </summary>
    /// <param name="argToFind">The argument to be checked for existence in the array</param>
    /// <returns>
    ///      Returns the index at which the input argument if it is found in the array.
    ///      -1 otherwise.
    /// </returns>
    public int IndexOf(T argToFind)
    {
        //Loop through the array
        for (int i = 0; i < this.Count; i++)
        {
            //Check if the argument at the current index is equal to the input argument
            if (this.storeArray[i].Equals(argToFind))
            {
                return i;
            }
        }

        //Input argument is not found.
        return NOT_IN_STRUCTURE;
    }

    /// <summary>
    /// Method to check if the input argument can be found in the array.
    /// </summary>
    /// <param name="argToCheck">The object to be checked for existence in the array</param>
    /// <returns>A boolean value
    ///    - True if the input object is found in the array
    ///    - False otherwise.
    /// </returns>
    public bool Contains(T argToCheck)
       => (this.IndexOf(argToCheck) != NOT_IN_STRUCTURE);

    /// <summary>
    /// Indexer property to return/change the value at the specified index
    /// </summary>
    /// <param name="index">The index from which the value is required</param>
    /// <returns>The value at the specified index.</returns>
    public virtual T this[int index]
    {
        get
        {
            if ((index < 0) || (index >= this.Capacity))
                throw new IndexOutOfRangeException("Invalid Index");


            return this.storeArray[index];
        }
        protected set
        {
            this.storeArray[index] = value;
        }
    }
}
    }