using CSharp.Activity.Profile;
using System;
using System.Collections.Generic;

namespace CSharp.Activity.CardGame
{


    /// <summary>
    /// Summary description for Card.
    /// </summary>
    public class CardPlayer : PlayerProfile // PlayerProfile 
    {

        ArrayStore<ICard> cardHand;

        public CardPlayer(int Player) : base(Player)
        {

        }

        public CardPlayer(string name, char gender, DateTime birthDate, int maxSize)
        {


            CardPlayerName = name;
            CardPlayerGender = gender;
            CardPlayerBirthDate = birthDate;
            MaxSize = maxSize;


        }
        public int CardAttribute { get; set; }
        public string CardPlayerName { get; private set; }

        public char CardPlayerGender { get; private set; }

        public DateTime CardPlayerBirthDate { get; set; }

        public int MaxSize { get; set; }
        public int CardCount { get; set; }

        public bool AddCard(ICard i)
        {

            try
            {
                List<int> Cards = new List<int>();

                for (int cardCount = 0; cardCount < MaxSize; cardCount++)
                {



                    Cards.Add(0);


                }

                return true;
            }
            catch (Exception)
            {
                return false;

            }

            if (CardCount == 0)
            {

                throw new ArgumentNullException("Input value cannot be null");
            }
               Card had 
        }


        //=> (this.CardAttribute == this.CardAttribute.Length);

        public bool IsEmpty()
        {
            //   => (this.Count <= 0);
        }


        //Adds the specified Card object 
        //into the player’s hand.Returns true if the add is successful, and
        //returns false otherwise.Throws a new
        //ArgumentNullException if the argument is null.
        public bool RemoveCard(ICard)
        {
            //    //public bool RemoveCard(ICard) – Removes the specified 
            //    Card object from the player’s hand that is Equal() to the Card
            //specified in the argument. Returns true if the remove is
            //successful and false otherwise.If the argument is null, throw an
            //ArgumentNullException.
            //}

            int cardCount = 0;

            //  for (int j = 0; j < cardCount - 1; j++)
            //  {

            //      //Check if the argument at the current index is equal to the input argument
            //      if (SimpleCard.Equals(j))
            //      {

            //          return true;
            //      }
            //      else if (j == 0)
            //      {

            //          throw new ArgumentNullException("Input value cannot be null");
            //      }

            //      else
            //          return false;

            //  }
            if (cardCount == 0)
            {
                throw new ArgumentNullException("Input value cannot be null");
            }
            bool isRemoved = false;


            for (int i = 0; i < cardCount; i++)
            {
                if (SimpleCard.Equals(i))
                {


                    for (int j = i; j < cardCount; j++)
                    {
                        i[j] = SimpleCard[j + 1];

                    }
                    cardCount--;
                    isRemoved = true;
                }

            }

            if (isRemoved == false)
            {
                throw new InvalidOperationException();
            }

        }
    }


    public bool IsFull()
    {

    }

    public ICard GetCard(int)
    {
        return 1;
    }


}

    public interface ICard
    {


        /// <summary>
        ///      Method to return the card for the given attribute.
        /// </summary>
        /// <param name="attribute">The index of the required card</param>
        /// <returns>An object</returns>
        string GetCardAttribute();


    }



    /// <summary>
    ///      Summary description for PlayerProfile.
    /// </summary>


    public class SimpleCard : ICard
    {

        //  string attribute = new ; // how to define





        public string GetCardAttribute()
        {
            return attribute;

            throw new NotImplementedException();
        }

        internal static bool Equals(object cardAttribute)
        {
            throw new NotImplementedException();
        }



        // Function to return the card 
        // attribute concatenated with a string. This would suffice for our activity 


        public int CardAttribute
        {
            get
            {
                return CardAttribute;
            }
            set
            {

                CardAttribute = value;
                // string cardCount = v;
            }

            //– Property to hold the 
            // attribute of the card.For testing we can assign numbers (like 1,
            // 2, etc.,) to differentiate the cards.
        }
    }




