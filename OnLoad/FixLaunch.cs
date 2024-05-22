using Il2CppPhoton.Pun;
using UnityEngine;

namespace Alien_Tag_Mod_Menu.OnLoad
{
    public class FixLaunch : MonoBehaviour
    {
        public void Awake()
        {
            NoMusic();
        }

        // Remove the annoying music
        private void NoMusic()
        {
            GameObject.Find("AudioManager").SetActive(false);
        }
    }
}
