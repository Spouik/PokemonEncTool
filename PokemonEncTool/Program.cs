using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonEncTool
{
    public enum GameVer : byte
    {
        None = 0, // 
        Diamond,  // Pokémon Diamond
        Pearl,    // Pokémon Pearl
        Platinum, // Pokémon Platinum
        Gold2,    // Pokémon HeartGold
        Silver2   // Pokémon SoulSilver
    }
    public enum Language : byte
    {
        None = 0, //
        English,  // 
        French    //
    }
    public enum LeadAbility : byte
    {
        None = 0,     //
        Static,       // Static + Lightning Rod (GEN 8)
        MagnetPull,   //
        Pressure,     // Pressure + Vital Spirit + Hustle
        CuteCharm,    //
        Intimidate,   // Intimidate + Keen Eye
        FlashFire,    // GEN 8
        StormDrain,   // GEN 8
        Harvest       // GEN 8
    }

    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
