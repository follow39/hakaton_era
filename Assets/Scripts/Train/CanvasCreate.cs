using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasCreate : MonoBehaviour {

    public GameObject panelDevice;
    public GameObject panelDevicePop;
    //public GameObject button;
    public Button button;
	// Use this for initialization
	void Start ()
    {
        PanelDeviceCreate(7);
        

	}
	public void PanelDeviceCreate(int count)
    {
        ScrollRect _scrollView = panelDevice.GetComponent<ScrollRect>();
        float _deltaheight = button.transform.position.y;
        for(int i =0;i<count;i++)
        {
            Button _Button = Instantiate(button, panelDevice.transform);
            _Button.transform.position = new Vector3(_Button.transform.position.x, _Button.transform.position.y - 1f*i);
            _Button.name = i.ToString();
            _Button.GetComponentInChildren<Text>().text = i.ToString();
            _Button.gameObject.SetActive(true);

        }
        panelDevice.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
