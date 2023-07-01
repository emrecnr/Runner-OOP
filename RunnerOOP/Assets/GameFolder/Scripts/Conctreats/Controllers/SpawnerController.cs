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
        [SerializeField]Transform _spawnPoint;
        [SerializeField] GameObject _objectPrefab;

        private void Start()
        {
            StartCoroutine(Spawn());
        }
        IEnumerator Spawn()
        {
            while (true)
            {
                Instantiate(_objectPrefab, _spawnPoint.position, _spawnPoint.transform.rotation);
                yield return new WaitForSeconds(3);
            }

            
        }



    }

}

