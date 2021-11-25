using CSharp.Activity.Profile;
using System;



namespace CSharp.Activity.CardGame
{


    /// <summary>
    /// Summary description for Card.
    /// </summary>
    public class CardPlayer : PlayerProfile
    {
        private object cardCount;

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

        public bool AddCard( ICard i) 
        {
            try
            {

                new SimpleCard();

                return true;
            }
            catch (Exception)

            {
                return false;
            }
            //for (int cardCount = 0; cardCount < 5; cardCount++)
            //{
            //    return true;
            //}

                  if (cardCount == null)
                {

                    throw new ArgumentNullException("Input value cannot be null");
                }
            }
          
                //if (int cardCount = 0 && cardCount < 5 )
                //        {
                //return true;

                //else

                //    return false
        }


            //if (this.AddCard())
            //{
            //    base.AddCard(ICard);

            //    return true;
            //}

            return false;
        }
    

    //=> (this.CardAttribute == this.CardAttribute.Length);

    public bool IsEmpty()
              => (this.Count <= 0);

}





//Adds the specified Card object 
//into the player’s hand.Returns true if the add is successful, and
//returns false otherwise.Throws a new
//ArgumentNullException if the argument is null.
public bool RemoveCard(ICard)
{

}

public bool IsFull()
{

}

public ICard GetCard(int)
{

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

    string attribute = new ; // how to define


    public string GetCardAttribute()
    {
        return attribute;

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


