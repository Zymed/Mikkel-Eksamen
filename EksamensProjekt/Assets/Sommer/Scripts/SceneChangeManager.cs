using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneChangeManager 
{
    public static int currentScene = SceneManager.GetActiveScene().buildIndex;
    public static void LoadAddRoomScene()
    {
        SceneManager.LoadScene(1);
    }

    public static void LoadRoomScene()
    {
        SceneManager.LoadScene(0);
    }
}
