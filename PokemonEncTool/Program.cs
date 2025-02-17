﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonEncTool
{
    public enum GameVer : byte
    {
        None = 0,      // 
        /*RedJP,       // Pocket Monsters Aka
        GreenJP,       // Pocket Monsters Midori
        BlueJP,        // Pocket Monsters Ao
        Red,           // Pokémon Red
        Blue,          // Pokémon Blue
        Yellow,        // Pokémon Yellow
        Gold,          // Pokémon Gold
        Silver,        // Pokémon Silver
        Crystal,       // Pokémon Crystal
        Ruby,          // Pokémon Ruby
        Sapphire,      // Pokémon Sapphire
        Red2,          // Pokémon FireRed
        Green2,        // Pokémon LeafGreen
        Emerald,       // Pokémon Emerald
        ColoGC,        // Pokémon Colosseum
        XDGC,          // Pokémon XD : Gale of Darkness*/
        Diamond = 17,  // Pokémon Diamond
        Pearl,         // Pokémon Pearl
        Platinum,      // Pokémon Platinum
        Gold2,         // Pokémon HeartGold
        Silver2        // Pokémon SoulSilver
        /*Black,       // Pokémon Black
        White,         // Pokémon White
        Black2,        // Pokémon Black 2
        White2,        // Pokémon White 2
        X,             // Pokémon X
        Y,             // Pokémon Y
        Ruby2,         // Pokémon Omega Ruby
        Sapphire2,     // Pokémon Alpha Sapphire
        Sun,           // Pokémon Sun
        Moon,          // Pokémon Moon
        Sun2,          // Pokémon Ultra Sun
        Moon2,         // Pokémon Ultra Moon
        LGPikachu,     // Pokémon Let's Go Pikachu
        LGEevee,       // Pokémon Let's Go Eevee
        Sword,         // Pokémon Sword
        Shield,        // Pokémon Shield
        Diamond2,      // Pokémon Brilliant Diamond
        Pearl2,        // Pokémon Shining Pearl
        PLArceus,      // Pokémon Legends : Arceus
        Scarlet,       // Pokémon Scarlet
        Violet,        // Pokémon Violet
        LPZA           // Pokémon Legends : Z-A*/
    }
    public enum Language : byte
    {
        None = 0, //
        English,  // 
        French    //
    }
    public enum Ability : byte
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
            Application.Run(new MainPage());
        }
    }
}
