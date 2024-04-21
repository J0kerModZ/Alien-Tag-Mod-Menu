using Photon.Pun;
using PlayFab.ClientModels;
using PlayFab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Alien_Tag_Mod_Menu
{
    public class PlayfabSpoof : MonoBehaviour
    {

        private WaitForSeconds changeInterval = new WaitForSeconds(2f);

        private void Start()
        {
            StartCoroutine(ChangeIDCoroutine());
        }

        private IEnumerator ChangeIDCoroutine()
        {
            while (true)
            {
                string newPlayFabID = GenerateRandomPlayFabID();
                UpdatePlayerData(newPlayFabID);
                Debug.Log("Changed PlayFab ID to: " + newPlayFabID);

                // Wait for 20 seconds before changing ID again
                yield return changeInterval;
            }
        }

        private string GenerateRandomPlayFabID()
        {
            // Generate a random ID here, adhering to PlayFab's requirements
            return "J0kerModZAuth_" + UnityEngine.Random.Range(1000, 9999);
        }

        private void UpdatePlayerData(string newPlayFabID)
        {
            // Call PlayFab API to update player data with the new ID
            var request = new UpdateUserDataRequest
            {
                Data = new System.Collections.Generic.Dictionary<string, string>
            {
                { "PlayFabID", newPlayFabID }
            }
            };

            PlayFabClientAPI.UpdateUserData(request, OnUpdateUserDataSuccess, OnUpdateUserDataFailure);
        }

        private void OnUpdateUserDataSuccess(UpdateUserDataResult result)
        {
            Debug.Log("Player data updated successfully");
        }

        private void OnUpdateUserDataFailure(PlayFabError error)
        {
            Debug.LogError("Failed to update player data: " + error.ErrorMessage);
        }
    }
}