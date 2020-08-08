using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public void LevelLoad(string name)
    {
        Bricks.breakableCount = 0;
        Debug.Log("level load requested..." + name);
        Application.LoadLevel(name);
    }
    public void QuitLevel()
    {
        Debug.Log("Quit requested...");
        Application.Quit();
    }
    public void ReturnButton(string name)
    {
        Bricks.breakableCount = 0;
        Application.LoadLevel(name);
    }

    public void LoadNextLevel()
    {
        Bricks.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void brickDistroyed()
    {
        if (Bricks.breakableCount<=0)
        {
            LoadNextLevel();
        }
    }
}
