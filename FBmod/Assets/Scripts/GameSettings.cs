using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public static int score = 0;
    public Text myText;
    public Button myBtn;
    public PlayerController pc;

    private void Start()
    {
        myBtn.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        pc.enabled = false;
        myText.text = $"Number of Schoolwork evaded: {score.ToString()}";
        myBtn.gameObject.SetActive(true);
        Time.timeScale = 0;
        //Invoke("PlayAgain", 3f);
    }

    // Update is called once per frame
    public void PlayAgain()
    { 
        SceneManager.LoadScene(0);
        score = 0;
        Time.timeScale = 1;
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), $"Score: {score.ToString()}");
    }

    public void Increment()
    {
        score++;
    }
}
