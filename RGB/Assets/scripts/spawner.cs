using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]Rigidbody2D spRb;
    [SerializeField] float speed;
    [SerializeField] float timer;
    [SerializeField] GameObject[] tiles;
    // Start is called before the first frame update
    void Start()
    {
        spRb.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0f)
        {
            int ran = Random.Range(0,3);
            Instantiate(tiles[ran],transform.position,Quaternion.identity);
            
            timer = Random.value*2f+0.25f;
        }
        timer -= Time.deltaTime*0.5f;
    }
}
