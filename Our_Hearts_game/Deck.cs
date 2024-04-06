using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Our_Hearts_game
{
    internal class Deck
    {

        public List<Card> DeckofCards = new List<Card>();


        public Deck() 
        {
            //Default Constructor
            InitializeDeck();
        }


        public void InitializeDeck()
        {
            string[] Suits = { "Hearts","Spades","Clubs", "Diamonds" };
            int[] Values = {1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            string[] url_nums = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };
            string[] url_decks = { "H", "S", "C", "D" };
            int cardpoints=0;


            for(int i=0;i<Suits.Length;i++)
            {
                for (int j=0;j<Values.Length;j++)
                {
                    string ImgUrl = Program.theme_info;
                    ImgUrl = ImgUrl + url_nums[j] + url_decks[i]+".png";
                    if (Values[j] ==12 && Suits[i] =="Spades")
                    {
                        cardpoints = 13;
                    }
                    else
                    {
                        if (Suits[i] == "Hearts")
                        {
                            cardpoints = 1;
                        }
                    }
                    
                    DeckofCards.Add(new Card(Suits[i], Values[j] ,cardpoints,ImgUrl));
                }
            }
            show();
            //shuffle the card  deck 
        }

        public void show()
        {
            foreach(Card card in DeckofCards)
            {
                Console.WriteLine(card.ToString());
            }
        }


    }
}
