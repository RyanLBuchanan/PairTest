namespace PairTest
{
    internal class PairTest
    {

        static void Main(string[] args)
        {
            var firstElement = new Pair<string>();
            firstElement.F = "string";
            Console.WriteLine(firstElement);

            var secondElement = new Pair<int>();
            secondElement.S = 1;
            Console.WriteLine(secondElement);

            //var ds3 = new Pair<bool>();
            //ds3.Data = false;
            //Console.WriteLine(ds3);





            //Pair<F, S> pair = new Pair<F, S>("string", 1);

        }

        public class Pair<T>
        {
            public string F { get; set; }
            public int S { get; set; }

            public override string ToString()
            {
                //return F.ToString();
                return S.ToString();
            }
        }




        //static void Main(string[] args)
        //{
        //    var firstElement = new Pair<string>();
        //    firstElement.F = "string";
        //    Console.WriteLine(firstElement);

        //    var secondElement = new Pair<int>();
        //    secondElement.S = 1;
        //    Console.WriteLine(secondElement);

        //    //var ds3 = new Pair<bool>();
        //    //ds3.Data = false;
        //    //Console.WriteLine(ds3);





        //    //Pair<F, S> pair = new Pair<F, S>("string", 1);

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