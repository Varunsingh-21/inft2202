using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_Hearts_game
{
    internal class Player
    {
        protected string name;
        protected List<Card> hand;
        protected IDictionary<string, string> Statisstics = new Dictionary<string, string>();
        protected bool isAiPlayer = false;

        public Player()
        {

        }

        public Player(string tname,List<Card> tHand,bool isAiPlayer)
        {

        }




        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsAiPlayer
        {
            get { return isAiPlayer; }
            set { isAiPlayer = value; }
        }

        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public Player(string name)
        {
            this.name = name;
            this.hand = new List<Card>();
        }






}
}
