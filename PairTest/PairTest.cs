namespace PairTest
{
    internal class PairTest
    {

        static void Main(string[] args)
        {
            var pair = new Pair<string, int>();
            pair.firstElement = "string";
            pair.secondElement = 42;
            Console.WriteLine($"The first element is: {pair.firstElement}\nThe second element is: {pair.secondElement}");
        }

        // From hint in book and assignment [Hint: The class header should be public class Pair<F, S>]
        public class Pair<F, S>
        {
            // 
            public F firstElement { get; set; }
            public S secondElement { get; set; }
        }



        /***** WORKING CODE FROM https://zetcode.com/csharp/generics/ *****/
        //static void Main(string[] args)
        //{
        //    var firstElement = new Pair<string>();
        //    firstElement.F = "string";
        //    Console.WriteLine(firstElement);

        //    var secondElement = new Pair<int>();
        //    secondElement.S = 1;
        //    Console.WriteLine(secondElement);

        //}

        //public class Pair<T>
        //{
        //    public string F { get; set; }
        //    public int S { get; set; }

        //    public override string ToString()
        //    {
        //        //return F.ToString();
        //        return S.ToString();
        //    }
        //}




        //public class Pair<F, S>(string _string, int _int)
        //{

        //    //public string F { get; set; }
        //    //public int S { get; set; }

        //    //public override string ToString()
        //    //{
        //    //    return dataF.ToString();
        //    //}
        //}
    }
}