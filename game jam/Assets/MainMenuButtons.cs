using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public int levelChosen;
    // Start is called before the first frame update
    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
    }
    

    public void QuitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        
        chooseLevel();
    }
    private void chooseLevel()
    {
        SceneManager.LoadScene(levelChosen);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
