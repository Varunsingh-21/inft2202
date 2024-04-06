using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_Hearts_game
{
    internal class Card
    {
        private string Suit;
        private int Rank;
        private int cardPoints;
        private string imgUrl;
    public Card()
    {

    }
     public Card(string cSuit, int cRank, int cPoints, string cimgUrl)
        {
            // Assigning values.
            Suit = cSuit;
            Rank = cRank;
            cardPoints = cPoints;
            imgUrl=cimgUrl;
            ToString();
        }


    protected internal string suit
        {
            get { return Suit; }
            set { Suit = value; }
        }
    protected internal int rank
        {
            get { return Rank; }
            set { Rank = value; }
        }
    protected internal int CardPoints
        {
            get { return cardPoints; }
            set { cardPoints = value; }
        }
    public override string ToString()
        {
            string Rank_temp = "";
            if (Rank == 1)
            {
                Rank_temp = "Ace";
            }
            else
            {
                if(Rank == 11) {
                    Rank_temp = "Jack";
                }
                else
                {
                    if(rank == 12)
                    {
                        Rank_temp = "Queen";
                    }
                    else
                    {
                        if(rank == 13)
                        {
                            Rank_temp = "King";
                        }
                        else
                        {
                            Rank_temp = Rank.ToString();
                        }
                    }
                }
            }
            string cardString;
            cardString = "This Card is "+Rank_temp + " of " + Suit +"\n"+"URL= "+ imgUrl;
            return cardString;
        }

    }
}
