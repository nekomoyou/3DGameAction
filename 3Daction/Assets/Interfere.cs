using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interfere : MonoBehaviour
{
    public GameObject EnemyCar;
    public Transform EnemyCarpos;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log("Timer:" + timer);
        if (timer >= 5)
        {
            Debug.Log("ê∂ê¨");
            Instantiate(EnemyCar, EnemyCarpos.position, Quaternion.identity);
            timer = 0;
        }
    }
}
