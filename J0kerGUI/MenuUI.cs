using Alien_Tag_Mod_Menu.Mods;
using Il2CppPhoton.Pun;
using Il2CppPhoton.VR;
using UnityEngine;
using MelonLoader;
using Il2Cpp;
using Il2CppInterop.Runtime.Injection;
using UnityEngine.SceneManagement;
using static UnityEngine.GUI;
using Il2CppPlayFab;
using System.IO;

namespace Alien_Tag_Mod_Menu
{
    public class MenuUI : MelonMod
    {
        // Variables for the IF statements
        public bool AntiBan;
        private bool Crash;
        private bool MatALLL;
        private bool ZB;
        private bool Poop;
        private bool TagAlll;
        private bool UnTagAlll;
        private bool Sound;
        private bool NameChange;

        // GUI Rects
        private Rect controlPanelRect;
        private Rect guiBoxRect;
        private Rect guiBoxRect3;
        private Rect guiBoxRect4;
        private Rect guiBoxRect5;
        private Rect guiBoxRect6;

        // Show Windows and the names
        private bool[] windowVisible = new bool[6];
        private string[] windowNames = { "Spam Mods", "Room Mods", "Cosmetic Mods", "Server Mods", "Kick Mods" };
        private bool NoticeChange;
        private bool rja;

        [System.Obsolete]
        public override void OnApplicationStart()
        {
            // Initialize window visibility to false
            for (int i = 0; i < windowVisible.Length; i++)
            {
                windowVisible[i] = false;
            }

            // Set window positions
            controlPanelRect = new Rect(20, 35, 200, 200);
            guiBoxRect = new Rect(240, 35, 200, 200);
            guiBoxRect3 = new Rect(680, 35, 200, 100);
            guiBoxRect4 = new Rect(20, 250, 200, 200);
            guiBoxRect5 = new Rect(240, 250, 200, 200);
            guiBoxRect6 = new Rect(460, 35, 200, 450);
        }

        public override void OnUpdate()
        {
            GameObject.Find("AudioManager").SetActive(false);
        }

        public override void OnGUI()
        {
            // Colors And The Top Labels
            #region Label
            GUI.Label(new Rect(0f, 0f, 160f, 20f), "F1 - <color=red>Hide Mouse</color>");
            GUI.Label(new Rect(0f, 15f, 160f, 20f), "F2 - <color=red>Show Mouse</color>");
            GUI.Label(new Rect(125f, 15f, 160f, 20f), "Ping: " + PhotonNetwork.GetPing().ToString());
            GUI.Label(new Rect(125f, 0f, 160f, 20f), "FPS: " + ((int)(1f / Time.smoothDeltaTime)).ToString());
            #endregion

            GUI.backgroundColor = Color.black;
            GUI.color = Color.red;

            // Draw control panel
            controlPanelRect = GUI.Window(0, controlPanelRect, (GUI.WindowFunction)ControlPanelFunction, "J0ker Alien Menu");

            // Draw windows based on their visibility
            if (windowVisible[0]) // Crash Mods
                guiBoxRect = GUI.Window(1, guiBoxRect, (GUI.WindowFunction)CrashModsWindowFunction, "Spam Mods");

            if (windowVisible[1]) // Room Mods
                guiBoxRect3 = GUI.Window(3, guiBoxRect3, (GUI.WindowFunction)RoomModsWindowFunction, "Room Mods");

            if (windowVisible[2]) // Cosmetic Mods
                guiBoxRect4 = GUI.Window(4, guiBoxRect4, (GUI.WindowFunction)CosmeticModsWindowFunction, "Cosmetic Mods");

            if (windowVisible[3]) // Server Mods
                guiBoxRect5 = GUI.Window(5, guiBoxRect5, (GUI.WindowFunction)ServerModsWindowFunction, "Server Mods");

            if (windowVisible[4]) // Player Mods
                guiBoxRect6 = GUI.Window(6, guiBoxRect6, (GUI.WindowFunction)PlayerModsWindowFunction, "Room Kicker");
        }

        // The Mod Enable Window
        public void ControlPanelFunction(int id)
        {
            for (int i = 0; i < windowVisible.Length; i++)
            {
                windowVisible[i] = GUI.Toggle(new Rect(20, 25 * (i + 1), 160, 25), windowVisible[i], windowNames[i]);
            }

            GUI.DragWindow();
        }

        // Window Function with the int ID
        public void CrashModsWindowFunction(int id)
        {
            // Draw specific buttons for Mods
            if (GUI.Button(new Rect(20, 45, guiBoxRect.width - 40, 25), "Rig Spam"))
            {
                this.Crash = !this.Crash;
            }
            if (this.Crash)
            {
                Mod.RigSpammer();
            }

            if (GUI.Button(new Rect(20, 85, guiBoxRect.width - 40, 25), "Others Spammer"))
            {
                this.ZB = !this.ZB;
            }
            if (this.ZB)
            {
                Mod.ZomBearSpam();
            }

            if (GUI.Button(new Rect(20, 125, guiBoxRect.width - 40, 25), "Rejoin All"))
            {
                this.rja = !this.rja;
            }
            if (this.rja)
            {
                Mod.RejoinName();
            }
            // Make the window draggable
            GUI.DragWindow();
        }

        public void RoomModsWindowFunction(int id)
        {
            if (GUI.Button(new Rect(20, 45, guiBoxRect3.width - 40, 25), "Disconnect"))
            {
                PhotonNetwork.Disconnect();
            }
            GUI.DragWindow();
        }

        public void CosmeticModsWindowFunction(int id)
        {
            if (GUI.Button(new Rect(20, 45, guiBoxRect4.width - 40, 25), "Name Changer"))
            {
                this.NameChange = !this.NameChange;
            }
            if (this.NameChange)
            {
                Mod.SpoofName();
            }

            if (GUI.Button(new Rect(20, 85, guiBoxRect4.width - 40, 25), "Long Top Hat"))
            {
                Mod.LongTopHat();
            }

            if (GUI.Button(new Rect(20, 125, guiBoxRect4.width - 40, 25), "Chain"))
            {
                Mod.Chain();
            }

            if (GUI.Button(new Rect(20, 165, guiBoxRect4.width - 40, 25), "T-Shirt"))
            {
                Mod.Shirt();
            }

            GUI.DragWindow();
        }

        public void ServerModsWindowFunction(int id)
        {
            if (GUI.Button(new Rect(20, 45, guiBoxRect5.width - 40, 25), "Set Master"))
            {
                Mod.SetMaster();
            }

            if (GUI.Button(new Rect(20, 85, guiBoxRect5.width - 40, 25), "Clear RPCS"))
            {
                Mod.ClearRPC();
            }

            if (GUI.Button(new Rect(20, 125, guiBoxRect5.width - 40, 25), "Notice Text [SS]"))
            {
                this.NoticeChange = !this.NoticeChange;
            }
            if (this.NoticeChange)
            {
                Mod.SSUpdateNoticeText();
            }

            if (GUI.Button(new Rect(20, 165, guiBoxRect5.width - 40, 25), "Grab All IDS"))
            {
                Mod.GrabIDsAll();
            }
            GUI.DragWindow();
        }

        public void PlayerModsWindowFunction(int id)
        {
            GUILayout.BeginVertical();

            for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("Player " + i + ": " + PhotonNetwork.PlayerList[i].NickName);
                Il2CppPhoton.Realtime.Player player = PhotonNetwork.PlayerList[i];
                if (GUILayout.Button("KickPlayer"))
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                    PhotonNetwork.DestroyPlayerObjects(player);
                }
                GUILayout.EndHorizontal();
            }

            GUILayout.EndVertical();

            GUI.DragWindow();
        }
    }
}
