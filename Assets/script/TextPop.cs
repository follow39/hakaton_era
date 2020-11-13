using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPop : MonoBehaviour {
    private bool down = false;
    public GameObject panel;
    private GameObject _panel;
    public void OnMouseEnter()
    {
        GetComponent<Outline>().enabled = true;
    }
    public void OnMouseExit()
    {
        GetComponent<Outline>().enabled = false;
    }
    public void OnMouseDown()
    {
        _panel = Instantiate(panel,gameObject.transform.parent.parent);
        _panel.GetComponent<RectTransform>().position = new Vector2(0f+Random.Range(-0.3f,0.3f),0f + Random.Range(-0.3f, 0.3f));
    }
    

}
