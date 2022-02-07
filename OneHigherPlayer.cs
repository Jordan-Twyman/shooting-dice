namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {

         override public void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = this.Roll();
            int otherRoll = other.Roll() -1;
            base.Roll();

    }
}
}