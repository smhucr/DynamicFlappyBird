using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.score.text = (int.Parse(GameManager.instance.score.text) + 1).ToString();

            GameManager.instance.audioSource.PlayOneShot(GameManager.instance.scriptablePlayer.clips[3]);
        }
    }
}
