using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDevice : MonoBehaviour
{

    private bool downMouse = false;
    private Vector2 vector2 = new Vector2(0f, 0f);
    public Camera cam;
    
    public void OnMouseEnter()
    {
        downMouse = true;

    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (downMouse)
            {
                for (int i = 1; i < transform.childCount; i++)
                {
                    if (transform.GetChild(i).GetComponent<OutputObjectDevice>().lineCreate)
                    {
                        Destroy(transform.GetChild(i).GetComponent<OutputObjectDevice>()._line);
                    }

                }
                Destroy(gameObject);
            }
        }
    }
    public void OnMouseDrag()
    {

        gameObject.transform.position = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        for (int i = 1; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<OutputObjectDevice>().lineCreate)
            {

                transform.GetChild(i).GetComponent<OutputObjectDevice>()._line.GetComponent<LineRenderer>().SetPosition(transform.GetChild(i).GetComponent<OutputObjectDevice>().index_line, transform.GetChild(i).transform.position);
            }
        }

    }
    public void OnMouseExit()
    {
        downMouse = false;
    }
   
    
}
