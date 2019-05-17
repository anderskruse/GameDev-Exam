using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler: MonoBehaviour
{
    public Button play;
    public Button info;
    public Button exit;
    public Button back;
    public GameObject menuPage;
    public GameObject howToPage;


    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(PlayGame);
        exit.onClick.AddListener(ExitGame);
        back.onClick.AddListener(Back);
        info.onClick.AddListener(HowToPlay);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Infinite Runner");
    }

    public void HowToPlay()
    {
        menuPage.SetActive(false);
        howToPage.SetActive(true);
    }

    void Back()
    {
        howToPage.SetActive(false);
        menuPage.SetActive(true);
    }

    void ExitGame()
    {
        Application.Quit();
    }

}
