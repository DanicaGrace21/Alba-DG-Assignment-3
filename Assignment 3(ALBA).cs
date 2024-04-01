namespace Assignment_3_ALBA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Seconds :  ");
            string a = Console.ReadLine();
            float X = (int)Int64.Parse(a);

            float SecTMin = X / 60;
            float MinHrs  = SecTMin / 60;
            float HrsDay  = MinHrs / 24;
            float DayMnth = HrsDay / 30;

            Console.WriteLine("Seconds to Minutes :" + SecTMin + " Minutes");
            Console.WriteLine("Minutes to Hours   :" + MinHrs + " Hours");
            Console.WriteLine("Hours   to Days    :" + HrsDay + " Days");
            Console.WriteLine("Days    to Months  :" + DayMnth + " Months");
        }
    }
}
