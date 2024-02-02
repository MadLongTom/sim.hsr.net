// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using sim.hsr.net;
using sim.hsr.net.Models;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> directory = [.. Directory.GetFiles(@"C:\Users\MadTom\source\repos\JWQK\StarRailData\Config\ConfigAbility\Avatar\")];
        List<string> eventtypes = [];
        foreach (string file in directory)
        {
            try
            {
                string myJsonResponse = File.ReadAllText(file);
                Console.WriteLine(file.Split('_')[1]);
                CharacterInfo.Root? myDeserializedClass = JsonConvert.DeserializeObject<CharacterInfo.Root>(myJsonResponse);
                //get all event registrations
                var q = myDeserializedClass!.AbilityList
                    .Where(x => x.Modifiers != null)
                    .SelectMany(e => e.Modifiers)
                    .Select(f => f.Value)
                    .Where(g => g._CallbackList != null)
                    .SelectMany(g => g._CallbackList!)
                    .Select(r => r.Event).ToList();
                eventtypes.AddRange(q);
                Console.WriteLine(string.Join(Environment.NewLine, q));
                myDeserializedClass = null;
            }
            catch (Exception ex)
            {
                //Welt and Sushang's config is unique
                Debug.Write(file +Environment.NewLine + ex.ToString());
            }
        }
        Console.WriteLine();
        eventtypes.Distinct().Order().ToList().ForEach(Console.WriteLine);
    }
}