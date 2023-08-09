using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform[] waypoins;

    public GameObject[] currencyPrefabs;

    public List<GameObject> currency_number;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (currency_number.Count == 0)
        {
            foreach(Transform transform in waypoins)
            {
                GameObject gameObject = Instantiate(currencyPrefabs[Random.Range(0, currencyPrefabs.Length)], transform.position, Quaternion.identity);
                currency_number.Add(gameObject);
            }
        }
    }
}
