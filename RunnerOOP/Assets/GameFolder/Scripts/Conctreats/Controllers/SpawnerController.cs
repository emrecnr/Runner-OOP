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
        [SerializeField] GameObject _coinObjects;
        Coroutine spawnCoroutine;
        private void Start()
        {
            
            StartCoroutine(Spawn());
            
        }
        
        IEnumerator Spawn()
        {

            while (true)
            {
                if (!GameManager.Instance.IsGamePause && GameManager.Instance.ActiveScene != "MainMenu"&&!GameManager.Instance.IsGameOver)
                {
                    GameObject obj = PoolManager.Instance.GetPooledObject(GetRandomPoolIndex());
                    obj.transform.position = GetRandomSpawnPosition();
                    yield return new WaitForSeconds(.5f);
                    Instantiate(_coinObjects, GetRandomSpawnPosition(), _coinObjects.transform.rotation);
                    yield return new WaitForSeconds(1);
                    
                }
                else
                {
                    yield return null;
                }
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

