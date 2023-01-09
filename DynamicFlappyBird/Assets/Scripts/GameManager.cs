using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text score;
    public bool startGame;
    public bool endGame;
    public GameObject startScreen;
    public GameObject objectPool;
    public GameObject player;
    public GameObject gameOverScreen;
    public Player scriptablePlayer;
    public AudioSource audioSource;
    private void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        player.GetComponent<SpriteRenderer>().sprite = scriptablePlayer.artWork;
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
        startGame = false;
        StartCoroutine(GameOverScreenDisplay());
    }

    private IEnumerator GameOverScreenDisplay()
    {
        yield return new WaitForSeconds(0.6f);
        gameOverScreen.SetActive(true);
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.scriptablePlayer.clips[2]);
    }
    private void OnMouseDown()
    {
        startGame = true;
        startScreen.SetActive(false);
        GetComponent<BoxCollider>().enabled = false; //2D olmaz player bozulur
        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        objectPool.GetComponent<PipeSpawner>().StartGame();
    }
}
