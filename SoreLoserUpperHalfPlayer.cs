using System;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
          public override int Roll()
        {
            return new Random().Next(3,7);
        }

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
