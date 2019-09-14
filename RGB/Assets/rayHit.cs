using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class rayHit : MonoBehaviour
{
    public float rayLength;
    public LayerMask layerMask;
    public static bool gameOver = false;
    [SerializeField] GameObject pausePannel;
    [SerializeField] GameObject redParticles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && !gameOver)
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
            if (hit)
            {
                // Debug.Log("");
                if (hit.collider.gameObject.tag == "redTile")
                {
                    Vector2 pos = hit.collider.transform.position;
                    Destroy(hit.collider.gameObject);
                    Instantiate(redParticles, pos, Quaternion.identity);

                }
                else if (hit.collider.gameObject.tag == "greenTile" || hit.collider.gameObject.tag == "blueTile")
                {
                    gameOver = true;
                }
            }


           /* if (Input.touchCount == 1&&!gameOver)
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {
                    if (gameObject.tag == "redTile")
                    {
                        Vector2 pos = gameObject.transform.position;
                        Destroy(gameObject);
                        Instantiate(redParticles, pos, Quaternion.identity);

                    }
                    else if (gameObject.tag == "greenTile" || gameObject.tag == "blueTile")
                    {
                        gameOver = true;
                    }
                }
    */        
    }







            if (gameOver)
            {
                Time.timeScale = 0f;
                pausePannel.SetActive(true);
                pausePannel.SetActive(true);
            }
        }
    }

