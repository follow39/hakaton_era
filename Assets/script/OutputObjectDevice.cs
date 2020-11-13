using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputObjectDevice : MonoBehaviour {

    public bool lineCreate = false;
    public GameObject line;
    public Camera cam;
    public GameObject _line;
    public int index_line = 0;
    public void OnMouseDown()
    {
        if (!lineCreate)
        {
            _line = Instantiate(line);
            _line.GetComponent<LineRenderer>().SetPosition(0, transform.position);
            _line.GetComponent<LineRenderer>().SetPosition(1, (Vector2)cam.ScreenToWorldPoint(Input.mousePosition));
        }

    }
    public void FixedUpdate()
    {
        if(_line==null)
        {
            lineCreate = false;
        }
    }
    public void OnMouseDrag()
    {
        if (!lineCreate)
        {
            _line.GetComponent<LineRenderer>().SetPosition(1, (Vector2)cam.ScreenToWorldPoint(Input.mousePosition));
        }
    }
    public void OnMouseUp()
    {
        if (!lineCreate)
        {


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform.gameObject.CompareTag("button_1"))
                {
                    if (!hit.transform.gameObject.GetComponent<OutputObjectDevice>().lineCreate && hit.transform.gameObject != gameObject)
                    {

                        _line.GetComponent<LineRenderer>().SetPosition(1, hit.transform.position);
                        lineCreate = true;
                        hit.transform.gameObject.GetComponent<OutputObjectDevice>().lineCreate = true;
                        hit.transform.gameObject.GetComponent<OutputObjectDevice>()._line = _line;
                        hit.transform.gameObject.GetComponent<OutputObjectDevice>().index_line = 1;
                    }
                    else
                    {
                        Destroy(_line);
                    }
                }
                else
                {
                    Destroy(_line);
                }
            }
            else
            {
                Destroy(_line);
            }
        }

    }
}
