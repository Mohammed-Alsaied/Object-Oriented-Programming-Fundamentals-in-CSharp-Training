namespace ACME.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert Spacec before each capital letter in a string
        /// Extension Methode add this before data type in a parameter of
        /// Methode if Class And Methode is Static Member
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsrtSpaces(this string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Trim any spaces already there
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }

            }
            result = result.Trim();
            return result;
        }
    }
}
