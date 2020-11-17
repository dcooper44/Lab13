namespace RoShamBo
{
    // Returns any value we choose
    public class PlayerThree : Player
    {
        public RoShamBo RoShamBoValue = RoShamBo.Scissors;

        public override RoShamBo GetRoshamBo()
        {
            return RoShamBoValue;
        }
    }
}
