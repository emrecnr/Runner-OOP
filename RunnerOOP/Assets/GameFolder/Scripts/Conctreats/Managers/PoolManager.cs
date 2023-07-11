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
            public Queue<GameObject> coinPool;
            public GameObject objectPrefabs;
            public GameObject coinPrefab;
            public int _poolSize;
            public Transform parentTransform;
        }
        [SerializeField] private Pool[] pools = null;
        public int PoolsLength => pools.Length;

        private void Awake()
        {
            CheckInstance(this);
            PoolState();

        }
        
        public GameObject GetPooledObject(int objectType)
        {

            GameObject obj = pools[objectType].pooledObject.Dequeue();
            
            obj.SetActive(true);
            

            pools[objectType].pooledObject.Enqueue(obj);

            return obj;
        }
        public GameObject GetCoinObject(int objectType)
        {
            GameObject coin = pools[objectType].coinPool.Dequeue();
            coin.SetActive(true);
            pools[objectType].coinPool.Enqueue(coin);
            return coin;
        }

        public void PoolState()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                pools[i].pooledObject = new Queue<GameObject>();
                for (int j = 0; j < pools[i]._poolSize; j++)
                {
                    GameObject obj = Instantiate(pools[i].objectPrefabs, pools[i].parentTransform);
                    obj.SetActive(false);
                    pools[i].pooledObject.Enqueue(obj);
                }
                pools[i].coinPool = new Queue<GameObject>();
                for (int j = 0; j < pools[i]._poolSize; j++)
                {
                    GameObject coin = Instantiate(pools[i].coinPrefab, pools[i].parentTransform);
                    coin.SetActive(false);
                    pools[i].coinPool.Enqueue(coin);
                }
            }
        }
       
        public void ResetObjects()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                foreach (GameObject obj in pools[i].pooledObject)
                {
                    obj.SetActive(false);
                    // Baslangýç pozisyonuna sifirla
                }
                foreach (GameObject coin in pools[i].coinPool)
                {
                    coin.SetActive(false);
                    // Baslangýç pozisyonuna sifirla
                }
            }

        }
    }


}




