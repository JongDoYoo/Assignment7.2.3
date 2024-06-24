namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Anagram("tall", "tllaa"));

        }

        static bool Anagram(string input1, string input2)
        {
            Dictionary<char, int> firstDictionary = new();
            Dictionary<char, int> secondDictionary = new();

            if (input1.Length != input2.Length)
            {
                return false;
            }


            foreach (char c in input1)
            {   //intially dictionary is empty, foreach loop is either making [key, value=1] a letter at a time from our input1, or ++1 to the value of same key(letter)
                if (firstDictionary.ContainsKey(c))   //.Constainskey a search for a specific key (in this case, its looking to see if (the c key) is in the dictionary       
                {                                       
                    firstDictionary[c]++;                   //if it .ContainsKeys then ++1 to the value (use the key to manipulate the value) [c] is a key
                }
                else
                {
                    firstDictionary.Add(c, 1); // we are adding to the dictionary (the c is the key 1 is the value/count)
                }
            }
            foreach (char c in input2)
            {   //intially dictionary is empty, foreach loop is either making [key, value=1] a letter at a time from our input1, or ++1 to the value of same key(letter)
                if (secondDictionary.ContainsKey(c))
                {
                    secondDictionary[c]++;
                }
                else
                {
                    secondDictionary.Add(c, 1);
                }
            }
            //{[t,1],[a,1],[l,2]}
            foreach (var kvPair in firstDictionary)
            {
                if (!secondDictionary.ContainsKey(kvPair.Key) ||     //if is the same initial key in their at all
                    secondDictionary[kvPair.Key] != kvPair.Value)              //is it the same key AND same value?
                {
                    return false;
                }
                
            }
            return true;

        }

        

            
    }
}
