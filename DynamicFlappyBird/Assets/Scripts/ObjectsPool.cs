using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool : MonoBehaviour
{
    // Object Pool
    [Serializable]
    public struct Pool
    {
        [SerializeField] public Queue<GameObject> pooledObjects;
        [SerializeField] public GameObject objectPrefab;
        [SerializeField] public int poolSize;
    }

    [SerializeField] public Pool[] pools = null;
    [SerializeField] public GameObject goldPipe;

    private void Awake()

    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new Queue<GameObject>();
            // Object Pooling
            for (int i = 0; i < pools[j].poolSize - 1; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                obj.SetActive(false);

                pools[j].pooledObjects.Enqueue(obj);
            }
            GameObject gold = Instantiate(goldPipe);
            gold.SetActive(false);
            pools[j].pooledObjects.Enqueue(gold);
        }
    }

    // Object call
    public GameObject GetPooledObject(int objectType)
    {

        GameObject obj = pools[objectType].pooledObjects.Dequeue();
        obj.SetActive(true);
        pools[objectType].pooledObjects.Enqueue(obj);
        return obj;
    }
}

