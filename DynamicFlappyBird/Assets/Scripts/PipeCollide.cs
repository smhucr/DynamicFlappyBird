using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCollide : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.GameOver();

            GameManager.instance.soundController.audioSource.PlayOneShot(GameManager.instance.soundController.clips[1]);
        }
    }

}
