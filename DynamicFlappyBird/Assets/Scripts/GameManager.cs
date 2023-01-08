using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text score;
    private bool startGame;
    public bool endGame;
    private void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    private void Awake()
    {
        MakeInstance();
    }

    public void GameOver()
    {
        if (endGame)
        {
            return;
        }
        endGame = true;
        Debug.Log("Nabry");
    }
}
