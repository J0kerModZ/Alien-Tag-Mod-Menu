using UnityEngine;
using Photon.Pun;
using Photon.VR;

namespace Alien_Tag_Mod_Menu.ModMenu
{
    public class MenuInput : MonoBehaviour
    {
        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.F3))
            {
                PhotonNetwork.Disconnect();
                PhotonVRManager.Connect();
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.F2))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
