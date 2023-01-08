using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] public ObjectsPool objectsPool;
    [SerializeField] public Transform player;

    private void Start()
    {
        StartCoroutine(PipeSpawnStart(0));
    }
    public IEnumerator PipeSpawnStart(int objectType)
    {
        var pipe = objectsPool.GetPooledObject(objectType);
        pipe.transform.position = player.transform.position + new Vector3(4, Random.Range(-0.2f, 1.5f), 0);
        yield return new WaitForSeconds(3);
        if (!GameManager.instance.endGame)
            StartCoroutine(PipeSpawnStart(objectType));
    }

}
