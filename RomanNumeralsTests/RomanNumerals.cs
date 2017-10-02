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
                        count = SubstractCount(count, 2, NeedToSubstract(count));
                        count += 5;
                        break;
                    case 'X':
                        count = SubstractCount(count, 2, NeedToSubstract(count));
                        count += 10;
                        break;
                    case 'L':
                        count = SubstractCount(count, 20, SubtractForLAndC(count));
                        count += 50;
                        break;
                    case 'C':
                        count = SubstractCount(count, 20, SubtractForLAndC(count));
                        count += 100;
                        break;
                }
            }
            return count;
        }

        private int SubstractCount(int count, int numberToSubtract, bool canSubtract)
        {
            if (canSubtract)
            {
                count -= numberToSubtract;
            }
            return count;
        }

        private bool NeedToSubstract(int count)
        {
            return count != 0 && ((count - 1) % 10 == 0 || (count - 1) % 5 == 0);
        }

        private bool SubtractForLAndC(int count)
        {
            return count != 0 && (count - 1) % 9 == 0;
        }
    }
}