using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject defaultPlayerPrefab; // Asigna el prefab desde el Inspector si es null en PlayerStorage

    void Start()
    {
        if (PlayerStorage.playerPrefab == null)
        {
            if (defaultPlayerPrefab == null)
            {
                Debug.LogError("Player prefab not found in PlayerStorage, and defaultPlayerPrefab is not set in the Inspector");
                return;
            }

            PlayerStorage.playerPrefab = defaultPlayerPrefab;
        }

        Instantiate(PlayerStorage.playerPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }    
}
