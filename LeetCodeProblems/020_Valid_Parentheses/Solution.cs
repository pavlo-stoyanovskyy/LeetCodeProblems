using System.Collections.Generic;
using LeetCodeProblems._020_Valid_Parentheses.Classes;

namespace LeetCodeProblems._020_Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var openingBracketsStack = new Stack<Bracket>();
            foreach (var c in s.ToCharArray())
            {
                Bracket bracket = null;
                if (TryParse(c, out bracket))
                {
                    if (bracket.Direction == BracketDirection.Opening)
                    {
                        openingBracketsStack.Push(bracket);
                    }
                    else
                    {
                        if (openingBracketsStack.Count == 0)
                        {
                            return false;
                        }
                        var lastOpeningBracket = openingBracketsStack.Pop();
                        if (lastOpeningBracket.Type != bracket.Type)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            if (openingBracketsStack.Count != 0)
            {
                return false;
            }
            return true;
        }

        private bool TryParse(char c, out Bracket bracket)
        {
            bracket = null;
            switch (c)
            {
                case '{':
                    bracket = new Bracket(BracketType.Brace, BracketDirection.Opening);
                    break;
                case '(':
                    bracket = new Bracket(BracketType.Parenthesis, BracketDirection.Opening);
                    break;
                case '[':
                    bracket = new Bracket(BracketType.SquareBracket, BracketDirection.Opening);
                    break;
                case '}':
                    bracket = new Bracket(BracketType.Brace, BracketDirection.Closing);
                    break;
                case ')':
                    bracket = new Bracket(BracketType.Parenthesis, BracketDirection.Closing);
                    break;
                case ']':
                    bracket = new Bracket(BracketType.SquareBracket, BracketDirection.Closing);
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
