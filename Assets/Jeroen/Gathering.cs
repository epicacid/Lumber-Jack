using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gathering : MonoBehaviour
{



    public float hout = 0f;
    public float steen = 0f;
    Camera camera;
    private Hout Wood;
    private Steen Stone;
    private float ClickedHout = 0f;
    private float ClickedStone = 0f;
    public GameObject Axe;
    public GameObject Pickaxe;



    // Use this for initialization
    void Start()
    {
        //camera = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //print("I'm looking at " + hit.transform.name);

            if (hit.transform.CompareTag("Stone"))
            {
                Pickaxe.SetActive(true);
                Axe.SetActive(false);
                if (hit.collider.CompareTag("Stone"))
                {
                    

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Stone = hit.transform.GetComponent<Steen>();

                        ClickedStone += 1f;
                        Debug.Log(ClickedStone);
                        if (ClickedStone == 5)
                        {
                            steen += 1f;
                            --Stone.Health;
                            ClickedStone = 0;
                            Debug.Log(ClickedStone);
                        }

                    }

                }
            }

            if (hit.transform.CompareTag("Wood"))
            {
                Pickaxe.SetActive(false);
                Axe.SetActive(true);
                if (hit.collider.CompareTag("Wood"))
                {
                   

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Wood = hit.transform.parent.GetComponent<Hout>();
                        ClickedHout += 1f;
                        Debug.Log(hit.collider.name +  "   time+: " + ClickedHout);
                        if (ClickedHout >= 5)
                        {
                            hout += 1f;
                            --Wood.Health;
                            ClickedHout = 0;
                            Debug.Log(ClickedHout);
                        }
                    }

                }
            }

        }
    }
}




