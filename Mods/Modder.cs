using easyInputs;
using Photon.Pun;
using Photon.VR;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


namespace Alien_Tag_Mod_Menu.Mods
{
    public class Modder : MonoBehaviour
    {

        public static void RigSpammer()
        {
            Transform transform = GameObject.Find("Gorilla Rig/GorillaPlayer/Main Camera").transform;
            PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("PhotonVR/Characters/PlayerAlien", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("PhotonVR/Characters/PlayerAlien", transform.position, Quaternion.identity, 0, null);
        }

        public static void ZomBearSpam()
        {
            Transform transform = GameObject.Find("Gorilla Rig/GorillaPlayer/Main Camera").transform;
            PhotonNetwork.Instantiate("ZomBear", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("ZomBear", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("ZomBear", transform.position, Quaternion.identity, 0, null);

            PhotonNetwork.Instantiate("Boy", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("Boy", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("Boy", transform.position, Quaternion.identity, 0, null);


            PhotonNetwork.Instantiate("My Robot Kyle -done-", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("My Robot Kyle -done-", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("My Robot Kyle -done-", transform.position, Quaternion.identity, 0, null);


            PhotonNetwork.Instantiate("Spaceship", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("Spaceship", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("Spaceship", transform.position, Quaternion.identity, 0, null);

            PhotonNetwork.Instantiate("ZomBunny", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("ZomBunny", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("ZomBunny", transform.position, Quaternion.identity, 0, null);

            PhotonNetwork.Instantiate("Hellephant", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("Hellephant", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("Hellephant", transform.position, Quaternion.identity, 0, null);

            PhotonNetwork.Instantiate("BigAsteroid", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("BigAsteroid", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("BigAsteroid", transform.position, Quaternion.identity, 0, null);

            PhotonNetwork.Instantiate("SmallAsteroid", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateSceneObject("SmallAsteroid", transform.position, Quaternion.identity, 0, null);
            PhotonNetwork.InstantiateRoomObject("SmallAsteroid", transform.position, Quaternion.identity, 0, null);

        }

        public static void SpoofName()
        {
            string[] names = new string[]
            {
           "<sprite name=\"wawa\"><color=#FF0000>J</color><color=#FF7F00>0</color><color=#FFFF00>K</color><color=#00FF00>E</color><color=#0000FF>R</color><color=#4B0082>M</color><color=#8B00FF>E</color><color=#FF0000>N</color><color=#FF7F00>U</color><color=#FFFF00>O</color><color=#00FF00>N</color><color=#0000FF>T</color><color=#4B0082>O</color><color=#8B00FF>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#FF7F00>J</color><color=#FFFF00>0</color><color=#00FF00>K</color><color=#0000FF>E</color><color=#4B0082>R</color><color=#8B00FF>M</color><color=#FF0000>E</color><color=#FF7F00>N</color><color=#FFFF00>U</color><color=#00FF00>O</color><color=#0000FF>N</color><color=#4B0082>T</color><color=#8B00FF>O</color><color=#FF0000>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#FFFF00>J</color><color=#00FF00>0</color><color=#0000FF>K</color><color=#4B0082>E</color><color=#8B00FF>R</color><color=#FF0000>M</color><color=#FF7F00>E</color><color=#FFFF00>N</color><color=#00FF00>U</color><color=#0000FF>O</color><color=#4B0082>N</color><color=#8B00FF>T</color><color=#FF0000>O</color><color=#FF7F00>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#00FF00>J</color><color=#0000FF>0</color><color=#4B0082>K</color><color=#8B00FF>E</color><color=#FF0000>R</color><color=#FF7F00>M</color><color=#FFFF00>E</color><color=#00FF00>N</color><color=#0000FF>U</color><color=#4B0082>O</color><color=#8B00FF>N</color><color=#FF0000>T</color><color=#FF7F00>O</color><color=#FFFF00>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#0000FF>J</color><color=#4B0082>0</color><color=#8B00FF>K</color><color=#FF0000>E</color><color=#FF7F00>R</color><color=#FFFF00>M</color><color=#00FF00>E</color><color=#0000FF>N</color><color=#4B0082>U</color><color=#8B00FF>O</color><color=#FF0000>N</color><color=#FF7F00>T</color><color=#FFFF00>O</color><color=#00FF00>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#4B0082>J</color><color=#8B00FF>0</color><color=#FF0000>K</color><color=#FF7F00>E</color><color=#FFFF00>R</color><color=#00FF00>M</color><color=#0000FF>E</color><color=#4B0082>N</color><color=#8B00FF>U</color><color=#FF0000>O</color><color=#FF7F00>N</color><color=#FFFF00>T</color><color=#00FF00>O</color><color=#0000FF>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#8B00FF>J</color><color=#FF0000>0</color><color=#FF7F00>K</color><color=#FFFF00>E</color><color=#00FF00>R</color><color=#FF7F00>M</color><color=#FFFF00>E</color><color=#00FF00>N</color><color=#0000FF>U</color><color=#4B0082>O</color><color=#8B00FF>N</color><color=#FF0000>T</color><color=#FF7F00>O</color><color=#FFFF00>P</color><sprite name=\"wawa\">",
           "<sprite name=\"wawa\"><color=#FF7F00>J</color><color=#FFFF00>0</color><color=#00FF00>K</color><color=#0000FF>E</color><color=#4B0082>R</color><color=#8B00FF>M</color><color=#FF0000>E</color><color=#FF7F00>N</color><color=#FFFF00>U</color><color=#00FF00>O</color><color=#0000FF>N</color><color=#4B0082>T</color><color=#8B00FF>O</color><color=#FF0000>P</color><sprite name=\"wawa\">"
            };

            PhotonVRManager.SetColour(Color.red);
            int num = new System.Random().Next(names.Length);
            PhotonNetwork.LocalPlayer.NickName = names[num];
            PlayerPrefs.SetString("Username", names[num]);
            if (PhotonNetwork.InRoom && PhotonVRManager.Manager.LocalPlayer != null)
            {
                PhotonVRManager.Manager.LocalPlayer.RefreshPlayerValues();
            }
        }

        public static void Fly()
        {
            if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
            {
                Player.Instance.bodyCollider.attachedRigidbody.velocity += Player.Instance.rightHandTransform.right / 2f;
            }
            if (EasyInputs.GetPrimaryButtonDown(EasyHand.LeftHand))
            {
                Player.Instance.bodyCollider.attachedRigidbody.velocity += -Player.Instance.leftHandTransform.right / 2f;
            }
        }

        public static void SM_RPC()
        {
            PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
            PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
            PhotonNetwork.SendAllOutgoingCommands();
        }

        public static void ClearPrefabsSS()
        {
            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f = GameObject.Find("ZomBear(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f2 = GameObject.Find("Boy(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f2);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f3 = GameObject.Find("My Robot Kyle -done-(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f3);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f4 = GameObject.Find("Spaceship(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f4);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f5 = GameObject.Find("ZomBunny(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f5);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f6 = GameObject.Find("Hellephant(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f6);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f7 = GameObject.Find("BigAsteroid(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f7);
            }

            foreach (Transform s in Object.FindAnyObjectByType<Transform>())
            {
                PhotonView f8 = GameObject.Find("SmallAsteroid(Clone)").GetComponent<PhotonView>();
                PhotonNetwork.DestroyAll(f8);
            }
        }

        public static void ClearPlayerObjs()
        {
            foreach (Photon.Realtime.Player s in PhotonNetwork.PlayerList)
            {
                PhotonNetwork.DestroyPlayerObjects(s);
            }
        }
    }
}

