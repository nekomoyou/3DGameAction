using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject obj;
    public Transform objpos;
    float time;
    public GameObject Bill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 5)
        {
            Debug.Log("ê∂ê¨");
            Instantiate(obj, objpos.position, Quaternion.identity);
            time = 0;
        }
    }
}
