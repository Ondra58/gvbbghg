namespace RetezUtil
{
    static public class Retezec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public string Smaz(string text)
        {
            foreach(char znak in text)
            {
                if(znak >= '0' && znak <= '9')
                {
                    text = text.Remove(znak);
                }
            }
            return text;
        }
    }
}