using System;

namespace RoShamBo
{
    // Player that randomly generates R, P, or S
    public class TheSharks : Player
    {
        public override RoShamBo GetRoshamBo()
        {
            var rnd = new Random();
            int roShamBoNumberValue = rnd.Next(0, 2);

            Enum.TryParse<RoShamBo>(roShamBoNumberValue.ToString(), out RoShamBo RoShamBoSelection);

            return RoShamBoSelection;
        }
       
    }
}
