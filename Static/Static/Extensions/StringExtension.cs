namespace Static.Extensions
{
    public static class StringExtension
    {
        public static string ToCapitalize(this string text)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
        public static string ToCapitalize(this string text, byte length)
        {
            return Char.ToUpper(text[0]) + text.Substring(1, length).ToLower();
        }
    }
}
