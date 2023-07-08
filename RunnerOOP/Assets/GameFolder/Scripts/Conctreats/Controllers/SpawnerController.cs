using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace RunnerOOP.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField]Transform[] _spawnPoints;
        

        


        private void Start()
        {
            StartCoroutine(Spawn());
            
        }
        IEnumerator Spawn()
        {
            
            while (!GameManager.Instance.IsGamePause)
            {
                Debug.Log(GetRandomPoolIndex());
                GameObject obj = PoolManager.Instance.GetPooledObject(GetRandomPoolIndex());//PoolManager'dan gelen Method'a rastgele havuz sayýsýný gonder

                obj.transform.position = GetRandomSpawnPosition();
                yield return new WaitForSeconds(2);
            }
        }
                
                

                
        private Vector3 GetRandomSpawnPosition()
        {
            Vector3 randomSpawnPosition = _spawnPoints[Random.Range(0,_spawnPoints.Length)].position;

            return randomSpawnPosition;
        }
        private int GetRandomPoolIndex()
        {
            int randomPoolIndex = Random.Range(0, PoolManager.Instance.PoolsLength);

            return randomPoolIndex;
        }

       
        


        

    }

}

