using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public Player player;

    public GameObject artWork;
    private void Start()
    {
        artWork.GetComponent<SpriteRenderer>().sprite = player.artWork;
    }
}
