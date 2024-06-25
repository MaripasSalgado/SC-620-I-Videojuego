using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void FirstLevel()
    {
        int levelNumber = 0;
        LoadLevel(levelNumber);
    }

    public void LastLevel()
    {
        int levelNumber = SceneManager.sceneCountInBuildSettings - 1;
        LoadLevel(levelNumber);
    }

    public void NextLevel()
    {
        int levelNumber = SceneManager.GetActiveScene().buildIndex + 1;
        if (levelNumber > SceneManager.sceneCountInBuildSettings - 1)
        {
            levelNumber = SceneManager.sceneCountInBuildSettings - 1;
        }
        LoadLevel(levelNumber);
    }

    public void PreviousLevel()
    {
        int levelNumber = SceneManager.GetActiveScene().buildIndex - 1;
        if (levelNumber < 0)
        {
            levelNumber = 0;
        }
        LoadLevel(levelNumber);
    }

    public void Quit() 
    
    { 
        Application.Quit();
    }
}