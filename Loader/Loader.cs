using Alien_Tag_Mod_Menu.ModMenu;
using Alien_Tag_Mod_Menu.Mods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Alien_Tag_Mod_Menu.Loader
{
    public class Loader
    {
        public static void Load()
        {
            Loader.gameObject = new GameObject();
            Loader.gameObject.AddComponent<Menu>();
            Loader.gameObject.AddComponent<MenuInput>();
            Loader.gameObject.AddComponent<PlayfabSpoof>();
            Loader.gameObject.AddComponent<Modder>();

            UnityEngine.Object.DontDestroyOnLoad(Loader.gameObject);
        }

        private static GameObject gameObject;
    }
}