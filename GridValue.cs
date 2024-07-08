namespace SnakeGame
{
    public enum GridValue
    {
        //Snake game is played in a 15x15 grid
        //Snake is represented by the letter '1'
        //Food is represented by the letter '2'
        //Empty space is represented by the letter '0'
        //The game is over when the snake runs into the wall or itself
        Empty,
        Snake,
        Food,
        Outside,
    }
}