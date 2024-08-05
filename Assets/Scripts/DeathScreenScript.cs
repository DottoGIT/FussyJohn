using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreenScript : MonoBehaviour
{
    private int best;
    public AudioClip playAgain;
    private AudioSource audioSrc;
    [SerializeField] private Text stage;
    [SerializeField] private Text bugs;
    [SerializeField] private Text highscore;
    private bool canLeave = false;

    void Start()
    {

        best = PlayerPrefs.GetInt("highScore", 0);



        audioSrc = FindObjectOfType<GameManager>().gameObject.GetComponent<AudioSource>();
        AnimationCommands.canTapBugsStatic = false;
        AnimationCommands.isSpeedButtonActiveStatic = false;

        Invoke("CanExitNow", 1f);

        FindObjectOfType<Camera>().gameObject.GetComponent<AudioSource>().pitch = 1f;

        if (StagesScript.currentStage + 1 < 10)
            stage.text = "0" + (StagesScript.currentStage + 1).ToString();
        else stage.text = (StagesScript.currentStage + 1).ToString();


        if (GameManager.bugsEaten < 10)
            bugs.text = "00" + GameManager.bugsEaten.ToString();
        else if (GameManager.bugsEaten > 10 && GameManager.bugsEaten < 100)
            bugs.text = "0" + GameManager.bugsEaten.ToString();
        else if (GameManager.bugsEaten < 999)
            bugs.text = GameManager.bugsEaten.ToString();
        else
        {
            bugs.text = "999";
            Debug.Log(GameManager.bugsEaten);
        }


        if (GameManager.bugsEaten > best)
        {
            PlayerPrefs.SetInt("highScore", GameManager.bugsEaten);
            best = PlayerPrefs.GetInt("highScore");
        }

        if (best < 10)
            highscore.text = "00" + best.ToString();
        else if (best > 10 && best < 100)
            highscore.text = "0" + best.ToString();
        else if (best < 999)
            highscore.text = best.ToString();
        else
        {
            highscore.text = "999";
            Debug.Log(best);
        }





        StopGame();

    }

    private void StopGame()
    {
        GameManager.isGameOver = true;
    }

    private void ResumeGame()
    {
        GameManager.isGameOver = false;
        GameManager.Score = 0;
        GameManager.bugsEaten = 0;
        GameManager.hpLeft = 3;
        GameManager.startNow = true;
        GameManager.failed = false;
        RememberBadOnes.EraseBadOnes();
        AnimationCommands.canTapBugsStatic = true;
        AnimationCommands.isSpeedButtonActiveStatic = true;
        audioSrc.PlayOneShot(playAgain, 3f);

        Destroy(gameObject);
    }

    void Update()
    {

        if(Input.touchCount>0 && canLeave)
        {
            ResumeGame();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ResumeGame();
        }
    }

    void CanExitNow()
    {
        canLeave = true;
    }
}
