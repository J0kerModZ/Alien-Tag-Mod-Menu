using Alien_Tag_Mod_Menu.Mods;
using Photon.Pun;
using Photon.VR;
using PlayFab;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Alien_Tag_Mod_Menu
{
    public class Menu : MonoBehaviour
    {

        public void Awake()
        {
            GameObject.Find("AudioManager").SetActive(false);
        }

        private Rect guiBoxRect = new Rect(0, 35, 245, 325);
        public bool AntiBan;
        private bool Crash;
        private bool CrazyP;
        private bool Fly;
        private bool ZB;
        private bool NL;
        private bool jl;
        private bool NLd;
        private bool ts;
        private string roomName = "";

        void OnGUI()
        {
            GUI.Label(new Rect(0f, 0f, 160f, 20f), "F1 - <color=red>Hide Mouse</color>");
            GUI.Label(new Rect(0f, 15f, 160f, 20f), "F2 - <color=red>Show Mouse</color>");
            GUI.Label(new Rect(125f, 0f, 160f, 20f), "F3 - <color=red>Rejoin Lobby</color>");
            GUI.Label(new Rect(125f, 15f, 160f, 20f), "Ping: " + PhotonNetwork.GetPing().ToString());
            GUI.Label(new Rect(275f, 0f, 160f, 20f), "FPS: " + ((int)(1f / Time.smoothDeltaTime)).ToString());
            GUI.backgroundColor = Color.black;
            GUI.color = Color.red;
            guiBoxRect = GUI.Window(0, guiBoxRect, DragWindow, "J0ker Alien UI");
        }

        void DragWindow(int windowID)
        {
            GUI.color = Color.red;
            GUI.backgroundColor = Color.black;

            if (GUI.Button(new Rect(0f, 45f, 245f, 25f), "Quit Game"))
            {
                Application.Quit();
            }

            if (GUI.Button(new Rect(0f, 85f, 120f, 25f), "Rig Spam"))
            {
                this.Crash = !this.Crash;
            }
            if (this.Crash)
            {
                Modder.RigSpammer();
            }

            if (GUI.Button(new Rect(125f, 85f, 120f, 25f), "Object Spammer"))
            {
                this.ZB = !this.ZB;
            }
            if (this.ZB)
            {
                Modder.ZomBearSpam();
            }

            if (GUI.Button(new Rect(0f, 125f, 245f, 25f), "Fly"))
            {
                this.Fly = !this.Fly;
            }
            if (this.Fly)
            {
                Modder.Fly();
            }

            if (GUI.Button(new Rect(0f, 155f, 120f, 25f), "Add Cosmetics"))
            {
                PhotonVRManager.SetCosmetic(Photon.VR.Cosmetics.CosmeticType.Head, "paper-hat1");
                PhotonVRManager.SetCosmetic(Photon.VR.Cosmetics.CosmeticType.Face, "anarchy-chain");
            }

            if (GUI.Button(new Rect(125f, 155f, 120f, 25f), "Spoof Player"))
            {
                this.CrazyP = !this.CrazyP;
            }
            if (this.CrazyP)
            {
                Modder.SpoofName();
            }

            if (GUI.Button(new Rect(0f, 185f, 245f, 25f), "No Prefabs [SS]"))
            {
                this.NL = !this.NL;
            }
            if (this.NL)
            {
                Modder.ClearPrefabsSS();
            }

            if (GUI.Button(new Rect(0f, 225f, 120f, 25f), "No Rigs [SS]"))
            {
                this.NLd = !this.NLd;
            }
            if (this.NLd)
            {
                Modder.ClearPlayerObjs();
            }

            if (GUI.Button(new Rect(125f, 225f, 120f, 25f), "No RPCS"))
            {
                this.jl = !this.jl;
            }
            if (this.jl)
            {
                Modder.SM_RPC();
            }
            GUI.DragWindow();
        } 
    }
}