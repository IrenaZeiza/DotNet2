using System;
using System.Reflection;


namespace CSharp.Activity.Datastore
{
    public class ArrayStack<T> : ArrayBase<T>
    {
        // NOTE: You are not allowed to declare any additional member variables or methods.

        // HINTS: Use properties and methods that are available from the class BaseArray<T> and are accessible by this class via inheritance.
        // The indexer this[] is used to represent the stack items.
        // The property Count represents the number of items currently in the stack.
        // The methods IsFull() and Contains() from BaseArray can be used here directly.


        /// <summary>
        /// Constructor to initialize the data structure to the specified size.
        /// Calls the overloaded base class constructor passing the size of the array.
        /// </summary>
        /// <param name="size">The maximum length of the stack.</param>
        public ArrayStack(int size) : base(size)
        {
            //No logic
        }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public ArrayStack()
        {
            //No Logic
        }


        /// <summary>
        /// Pushes the 'arg' item on the top of the stack.
        /// </summary>
        /// <param name="arg">Object to push on the top of the stack.</param>
        /// <returns></returns>
        public virtual void Push(T arg)// last in firs out 
        {
            //TODO Activity 2.5
            //Implement this method so that it 'pushes' the item 'arg' onto the top of the stack assuming
            //that the stack is not full, and that a similar item is not already inside the stack.
            //Throw InvalidOperationException if the stack is full.


            if (!typeof(T).IsValueType && arg == null)
                throw new ArgumentNullException("arg", "Input value cannot be null");

            // if (Count < 5)// if count ==capacity 
            // {
            // test if it is not similar 
            //      Push(arg);
            // }
            if (Count == Capacity)
            {
                throw new InvalidOperationException("the stack is full");
            }
            else
            {
                this[Count++] = arg;



                //   else if (IndexOf(arg) != NOT_IN_STRUCTURE) ;

                //    if (typeof(T).Equals(arg))
                //    {
                //        throw new InvalidOperationException("Cannot be added, because it's already exist");
                //    }
                //}

            }
        }
        



        // while (storeArray.Count > 0)
        //   Console.Write(store.Pop() + ",");

        //HINT: Remember that the bottom of the stack has index 0

        // In .NET Core use: !typeof(T).GetTypeInfo().IsValueType && arg == null (also requires adding 'using System.Reflection;')


        //start solution



        /// <summary>
        /// Pops and returns the topmost item from the stack.
        /// </summary>
        /// <returns>current count of the data store</returns>
        public virtual T Pop(T arg)
        {
            //TODO Activity 2.6
            //Implement this method so that it 'pops' the topmost item from the stack.
            //This also removes the item from the stack and returns it.  
            //Throw InvalidOperationException if the pop fails for any reason (i.e., the stack is empty... ) 

            //HINT: Remember that the bottom of the stack has index 0

            //start solution
            //   Our solution:

            //if (!typeof(T).IsValueType && arg == null)
            //    throw new ArgumentNullException("arg", "Input value cannot be null");

            //if (Count < 0 && Count < 5)
            //{
            //    // test if it is not similar 
            //    Pop(arg);
            //}


            //else

            // throw new InvalidOperationException("Pop failed");

            if (Count == 0)
            {
                throw new InvalidOperationException("the stack is empty...");
            }


            Count--;
            return this[Count];

            //  < int> storeArray = new storeArray <string>(
            //    input.Split(new string[] { " " }, StringSplitOptions.None);

            //    // Remove the top element (will be d!)
            // storeArray.Pop();

            //    // Queue<string> myQueue = new Queue<string>(

            //    // Remove the first element (will be a!)


            //}


          //  return default(T); // in the final solution this statement should be deleted or modified
        }


        /// <summary>
        /// Returns the topmost item of the stack without removing it.
        /// </summary>
        /// <returns></returns>
        public virtual T Peek(T arg)
        {
            //TODO Activity 2.7
            //Implement this method so that it takes a look at the top most item of the stack.  It 
            //returns the item, but does not remove it from the stack.
            //Throw InvalidOperationException if the peek fails for any reason (i.e., the stack is empty, etc.) 

            //HINT: Remember that the bottom of the stack is at the index 0

            ////start solution
            //Our solution: 
            //if (Count < 0 && Count < 5)
            //{
            //    // test if it is not similar 
            //    Peek (arg);
            //}
            //else

            //    throw new InvalidOperationException("The Peek failed");

            //if (typeof(T).Equals(arg))
            //{
            //    throw new InvalidOperationException("Cannot be added, because it's already exist");
            //}
            //return arg;

            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return this[Count - 1];


            // return default(T); // in the final solution this statement should be deleted or modified
        }

    }
    
}