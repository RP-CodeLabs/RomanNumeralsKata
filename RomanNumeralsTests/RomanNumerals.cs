namespace RomanNumeralsTests
{
    public class RomanNumerals
    {
        public int ConvertToNumber(string input)
        {
            return CountOfCharacters(input);
        }

        private int CountOfCharacters(string input)
        {
            var count = 0;
            foreach (var ch in input)
            {
                switch (ch)
                {
                    case 'I':
                        count++;
                        break;
                    case 'V':
                        if (NeedToSubstract(count))
                        {
                            count -= 2;
                        }
                        count += 5;
                        break;
                    case 'X':
                        if (NeedToSubstract(count))
                        {
                            count -= 2;
                        }
                        count += 10;
                        break;
                }
            }
            return count;
        }

        private bool NeedToSubstract(int count)
        {
            return count != 0 && ((count - 1) % 10 == 0 || (count - 1) % 5 == 0);
        }
    }
}