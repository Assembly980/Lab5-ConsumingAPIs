using System.Text.Json;

namespace API_Lab
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string response = " ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING! \nTHE FOLLOWING API CAN BE ADDED TO BY ANYONE \nTHIS MEANS THAT SOME OF THE FACTS WILL BE INCOHERRENT" +
                "\nBUT THIS SHOULD NOT DISSUADE YOU \nIF YOU RUN INTO AN INCOHERRENT FACT, PLEASE JUST HIT ENTER.");
            Console.ResetColor();
            do
            {
                await CatFactCall();
                Console.WriteLine("Do you want another fact? (N to quit. Press any other key to continue)");
                response = Console.ReadLine() + " ";
            } while (response.ToUpper()[0] != 'N');
        }

        public static async Task CatFactCall()
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://cat-fact.herokuapp.com/facts/random");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            
            CatResult c = JsonSerializer.Deserialize<CatResult>(json, options);
            Console.WriteLine(c + "\n");
        }
    }
}