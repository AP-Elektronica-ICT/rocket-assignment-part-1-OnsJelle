using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;    

    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
            Player = GameObject.FindWithTag("Player");

        healthPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        // State machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    GameScore.ScoreValue = 0;
                    gameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
            case GameStates.GameOver:                
                //if (healthPlayer.isAlive)
                //{
                //    gameState = GameStates.Playing;
                //    MainCanvas.SetActive(true);
                //    GameOverCanvas.SetActive(false);
                //}
                break;
            default:
                break;
        }
    }
}
