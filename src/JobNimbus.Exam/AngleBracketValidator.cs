namespace JobNimbus.Exam
{
    public class AngleBracketValidator
    {
        private const char openBracket = '<';
        private const char closeBracket = '>';
        private static readonly char[] brackets = { openBracket, closeBracket }; 

        public bool Validate(string input)
        {
            //simplify by filtering out open/close brackets prior the validation.
            var listOfBrackets = input.Where(x => brackets.Contains(x)).ToArray();
            string filteredInput = string.Join("", listOfBrackets);
         
            //validate the filtered input.
            var result = ValidateInput(filteredInput);
            return result;
        }

        private bool ValidateInput(string input)
        {
            bool DoesNotContainAngleBrackets = !input.Contains('<') && !input.Contains('>');
            if (DoesNotContainAngleBrackets)
            {
                return true;
            }

            var AngleBracketStore = new AngleBracketStore();

            //loop through the input which contains open/close brackets only.
            foreach (char character in input)
            {
                if (character == openBracket)
                {
                    //add new open bracket to the store.
                    AngleBracketStore.Add();
                }
                else if (character == closeBracket)
                {
                    if (AngleBracketStore.Items.Count == 0)
                    {
                        //exit loop by returning false when close bracket has no matching remaining bracket in the store.
                        return false; 
                    }
                    else
                    {
                        //remove the corresponding open bracket in the store.
                        AngleBracketStore.Remove();
                    }
                }
            }

            return AngleBracketStore.Items.Count == 0;
        }
    }
}
