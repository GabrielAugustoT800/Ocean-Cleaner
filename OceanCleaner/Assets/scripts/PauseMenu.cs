using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public Transform menuPause;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(menuPause.gameObject.activeSelf)
            {
                menuPause.gameObject.SetActive(false);
                Time.timeScale = 1.0f; 
            }
            else
            {
                menuPause.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Quit()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
