using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomoryGame
{
    [Serializable]
    internal class GameData
    {
        private int round;
        private int winns;
        private int fails;
        private string playerName;

        public GameData(int round, int winns, int fails, string playerNmame)
        {
            this.Round = round;
            this.Winns = winns;
            this.Fails = fails;
            this.PlayerNmame = playerNmame;
        }

        public GameData()
        {
            round = 1;
            winns = 0;
            fails = 0;
            playerName = "N/A";
        }

        public int Round { get => round; set => round = value; }
        public int Winns { get => winns; set => winns = value; }
        public int Fails { get => fails; set => fails = value; }
        public string PlayerNmame { get => playerName; set => playerName = value; }
    }
}
