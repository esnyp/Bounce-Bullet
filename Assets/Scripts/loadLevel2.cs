using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel2 : MonoBehaviour
{
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
}
