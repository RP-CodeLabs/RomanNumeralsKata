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
                        count = SubstractCount(count);
                        count += 5;
                        break;
                    case 'X':
                        count = SubstractCount(count);
                        count += 10;
                        break;
                }
            }
            return count;
        }

        private int SubstractCount(int count)
        {
            if (NeedToSubstract(count))
            {
                count -= 2;
            }
            return count;
        }

        private bool NeedToSubstract(int count)
        {
            return count != 0 && ((count - 1) % 10 == 0 || (count - 1) % 5 == 0);
        }
    }
}