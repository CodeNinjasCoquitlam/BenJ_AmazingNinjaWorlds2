using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void Level1()
    {
        PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene(4);
    }
    public void Level3()
    {
        PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene(6);
    }
}
