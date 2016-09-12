namespace _03_Simon_Says
{
    public class Simon
    {

        public string Echo(string hello)
        {
            return hello.ToLower();
        }

        public string Shout(string ciao)
        {
            return ciao.ToUpper();
        }
        public string Repeat(string hello)
        {
            return hello + " " + hello;
        }
        public string Repeat(string hello, int numberoftimes)
        {
            string result = hello;
            for (int i = 1; i < numberoftimes; i++)
            {  result += " ";
            result += hello;
        }
            return result;

        }
    }
}
        
    

