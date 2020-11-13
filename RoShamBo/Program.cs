using System;
using System.Dynamic;
using System.Reflection.Emit;

namespace RoShamBo
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PlayerThree();

            Console.WriteLine((test.GetRoshamBo()));



                
            
        }
    }


    public abstract class Player
    {
        public string roshamboValue { get; set; }
        public string playerName { get; set; }


         public abstract RoShamBo GetRoshamBo();    
                
    }


    //player that always selects rock
    public class TheJets
    {
        public RoShamBo RoShamBoValue = RoShamBo.Rock;

        
       
    }


    public class TheSharks
    {

       

        //GetRoshamBo();

    }


    public class PlayerThree : Player
    {
        public override RoShamBo GetRoshamBo()
        {
            var rnd = new Random();
            int roShamBoNumberValue = rnd.Next(0, 3);

            Enum.TryParse<RoShamBo>(roShamBoNumberValue.ToString(), out RoShamBo RoShamBoSelection);

            return RoShamBoSelection;
        }
       
    }


    public enum RoShamBo
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
}
