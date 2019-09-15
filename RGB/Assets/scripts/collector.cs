using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        Debug.Log("hello world");
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
}
