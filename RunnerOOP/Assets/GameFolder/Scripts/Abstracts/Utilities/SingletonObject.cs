using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Abstracts.Utilities
{
    public abstract class SingletonObject<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }

        protected void CheckInstance(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }


    }

    

}

