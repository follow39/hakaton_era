using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelDevice : MonoBehaviour {

    public GameObject panelPop;
    private GameObject _panelPop = null;
    public Text text;
    private bool mousenter = false;
    //public  button;
    void Start () {
		
	}

    private void LateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(_panelPop);
        }
    }

    public void CreateDevicePop(Transform tr)
    {
        if (_panelPop==null)
        {
            _panelPop = Instantiate(panelPop,tr.parent);
           
        }
        if(_panelPop.transform.childCount>0)
        {
            for(int i =0;i< _panelPop.transform.childCount;i++)
            {
                if(i==0)
                {
                    _panelPop.transform.GetChild(i).GetComponent<Text>().text = gameObject.transform.GetChild(0).GetComponent<Text>().text;
                    continue;
                }
                var _child = _panelPop.transform.GetChild(i);
                Destroy(_child.gameObject);
            }
        }
        int index = 5;
        _panelPop.transform.position = tr.position + new Vector3(1f, -0.5f,0f);
        
        for(int i=0; i<index;i++)
        {
            Text _text = Instantiate(text, _panelPop.transform);
            
            _text.transform.position = _panelPop.transform.position +  new Vector3(0.1f, 0.4f-i * 0.2f, 0f);
            _text.text = "* " + gameObject.transform.GetChild(0).GetComponent<Text>().text +"."+ i.ToString()+"!!!!!!!";
        }
        //_panelPop.SetActive(true);
    }
    public void OnMouseEnter()
    {
        mousenter = true;
    }
    public void OnMouseExit()
    {
        mousenter = false;
    }
}
