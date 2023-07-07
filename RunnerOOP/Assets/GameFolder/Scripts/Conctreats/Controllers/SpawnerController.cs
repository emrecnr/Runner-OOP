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
        [SerializeField] GameObject[] _obstaclesPrefabs;
        [SerializeField] GameObject[] _coinPrefabs;


        private void Start()
        {
            StartCoroutine(Spawn());
            
        }
        IEnumerator Spawn()
        {
            
            while (!GameManager.Instance.IsGamePause)
            {
                SpawnCoins();
                
                yield return new WaitForSeconds(2);

                SpawnObstacles();

                yield return new WaitForSeconds(2);
            }
        }

        private void SpawnCoins()
        {
            Transform randomSpawnPos = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            GameObject randomCoin = _coinPrefabs[Random.Range(0, _coinPrefabs.Length)];
            Instantiate(randomCoin, randomSpawnPos.position, randomSpawnPos.rotation);
        } 
        private void SpawnObstacles()
        {
            Transform randomSpawnPos = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            GameObject randomObstacles = _obstaclesPrefabs[Random.Range(0, _spawnPoints.Length)];
            Instantiate(randomObstacles, randomSpawnPos.position, randomSpawnPos.rotation);
        }
        //IEnumerator SpawnCoins()
        //{
        //    while (!GameManager.Instance.IsGamePause)
        //    {
        //        Transform randomSpawnPos = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        //        GameObject randomCoin = _coinPrefabs[Random.Range(0, _coinPrefabs.Length)];
        //        Instantiate(randomCoin, randomSpawnPos.position, randomSpawnPos.rotation);
        //        yield return new WaitForSeconds(1.5f);

        //    }
                
        //}
        

        

    }

}

