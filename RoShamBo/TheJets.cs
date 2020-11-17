namespace RoShamBo
{
    //player that always selects rock
    public class TheJets : Player
    {
        public  RoShamBo RoShamBoValue = RoShamBo.Rock;

        public override RoShamBo GetRoshamBo()
        {
            return RoShamBoValue;
        }
    }
}
