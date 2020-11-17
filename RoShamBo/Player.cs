namespace RoShamBo
{
    public abstract class Player
    {
        public RoShamBo roshamboValue { get; set; }
        public string playerName { get; set; }


         public abstract RoShamBo GetRoshamBo();    
                
    }
}
