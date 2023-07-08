using RunnerOOP.Abstracts.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Managers
{

    public class PoolManager : SingletonObject<PoolManager>
    {
        [Serializable]
        public struct Pool
        {
            public Queue<GameObject> pooledObject;
            public GameObject objectPrefabs;
            public  int _poolSize;
        }
        [SerializeField] private Pool[] pools = null;
        public int PoolsLength => pools.Length;
        private void Awake()
        {
            CheckInstance(this);

            for (int i = 0; i < pools.Length; i++)
            {
               pools[i].pooledObject = new Queue<GameObject>();
                for (int j = 0; j < pools[i]._poolSize; j++)
                {
                    GameObject obj = Instantiate(pools[i].objectPrefabs);
                    obj.SetActive(false);
                    pools[i].pooledObject.Enqueue(obj);
                }
            }
        }
        public GameObject GetPooledObject(int objectType)
        {
            GameObject obj = pools[objectType].pooledObject.Dequeue();
            obj.SetActive(true);
            pools[objectType].pooledObject.Enqueue(obj);
            return obj;
        }
    }


}




