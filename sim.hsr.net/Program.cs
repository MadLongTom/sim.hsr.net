// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using sim.hsr.net;
using sim.hsr.net.Models;

string myJsonResponse = File.ReadAllText(@"C:\Users\MadTom\source\repos\JWQK\StarRailData\Config\ConfigAbility\Avatar\Avatar_Bailu_00_Ability.json");

CharacterInfo.Root? myDeserializedClass = JsonConvert.DeserializeObject<CharacterInfo.Root>(myJsonResponse);
File.WriteAllText(@"D:\SIM.HSR.NET\" + DateTime.Now.ToFileTime() + ".txt", myDeserializedClass!.ToString());

//get all event registrations
var q = myDeserializedClass.AbilityList.Where(x => x.Modifiers != null).SelectMany(e => e.Modifiers).Select(f => f.Value).Where(g => g._CallbackList != null).SelectMany(g => g._CallbackList!).Select(r => r.Event).ToList();

Console.WriteLine(string.Join(Environment.NewLine,q));
