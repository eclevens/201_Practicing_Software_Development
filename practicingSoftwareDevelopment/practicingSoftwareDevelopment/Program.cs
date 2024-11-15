namespace practicingSoftwareDevelopment
//Dictionary - Phone Book

    /*
     * Goals:
     * Make a phone book
     * Add person with number
     * Delete person by name
     * Display entire phone book
     * Search phone book by name and return result
     */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare dictionary for phoneBook
            var phoneBook = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" }
        };

            Console.WriteLine(phoneBook["key1"]);
        }
    }
}
