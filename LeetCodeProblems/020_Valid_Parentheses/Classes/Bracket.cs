namespace LeetCodeProblems._020_Valid_Parentheses.Classes
{
    public class Bracket
    {
        public Bracket(BracketType type, BracketDirection direction)
        {
            Type = type;
            Direction = direction;
        }

        public BracketType Type { get; private set; }
        public BracketDirection Direction { get; private set; }
    }
}
