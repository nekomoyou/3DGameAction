using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float Speed = 0.1f;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("スタート");
        //Instantiate(Player,Playerpos.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        var playerpos = Vector3.zero;
        //transform.position += transform.forward * Speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerpos.x = Speed;
            Debug.Log("右");
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            playerpos.x = -Speed;
            Debug.Log("左");
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            playerpos.z = Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerpos.z = -Speed;
        }
        this.transform.Translate(playerpos);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain" || collision.gameObject.tag == "Road Concrete Tile")
        {
            Debug.Log("床に当たった");
        }
        else
        {
            //Debug.Log("当たった");
        }
    }
}
