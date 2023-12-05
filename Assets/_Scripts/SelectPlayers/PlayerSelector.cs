using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelector : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    
    public void GirlSelected()
    {
        PlayerStorage.playerPrefab = playerPrefabs[0];
        SceneManager.LoadScene("Lobby");
    }

    public void BoySelected()
    {
        PlayerStorage.playerPrefab = playerPrefabs[1];
        SceneManager.LoadScene("Lobby");
    }
}
