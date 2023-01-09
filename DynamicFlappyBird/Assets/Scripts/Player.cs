using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Players")]
public class Player : ScriptableObject
{
    public Sprite artWork;
    public AudioClip[] clips;

}
