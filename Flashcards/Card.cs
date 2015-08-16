using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program Name: Card.cs
/// Program Description: A class that 
/// acts as one flashcard. It stores 
/// strings for two sides of the card. 
/// Authors: Ryan Samarajeewa, Andy Yang
/// </summary>
namespace Flashcards
{
    class Card
    {
        public string id, side1, side2;
        public bool viewed = false;


        public Card(string id, string side1, string side2)
        {
            this.id = id;
            this.side1 = side1;
            this.side2 = side2;
            viewed = false;
        }
<<<<<<< HEAD
||||||| merged common ancestors
||||||| merged common ancestors
        string id = "";
        bool viewed = false;
=======
        string id = "";
        string sideOne = "";
        string sideTwo = "";
        bool viewed = false;

        //populates a side of a card with a string
        public void writeToSide(int side, string content)
        {
            if (side == 1)
            {
                this.sideOne = content;
            }
            else
            {
                this.sideTwo = content;
            }

        }

        //set the 'viewed' variable to true 
        //so that it cannot be read twice in the same
        //session.
        public void setToViewed()
        {
            this.viewed = true;
        }
        
>>>>>>> Temporary merge branch 2
=======

          
>>>>>>> 462371fbe29778aa02cff1fbb2abba9c97d9057c
    }

    
}
