using UnityEngine;

namespace Alien_Tag_Mod_Menu.ModMenu
{
    public class UIInput : MonoBehaviour
    {
        private void Update()
        {
            // When User presses F1 Makes the Mouse cursor visable & unlocks
            if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            // When User presses F2 Makes the Mouse cursor invisable & locks
            if (UnityEngine.Input.GetKeyDown(KeyCode.F2))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

    }
}
