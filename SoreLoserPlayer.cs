using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {

            public override void Play(Player other)
        {

            try{
                
            if(Roll() < other.Roll())
            {
                 throw new InvalidOperationException();
            }
            else
            {
                base.Play(other);
            }
            
                
            }

            catch(InvalidOperationException){
                Console.WriteLine($"{Name} rolls a {Roll()}");
                Console.WriteLine($"{other.Name} rolls a {other.Roll()}");    
                Console.WriteLine($"{Name} says: Sorry, I can't lose");               
        }

     


        
    }
}

}