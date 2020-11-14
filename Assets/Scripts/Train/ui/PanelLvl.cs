using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLvl : MonoBehaviour {

    public GameObject cirsle;
    public GameObject arrow;
    private float[] posX = new float[10];
    //private GameObject panelParent;
    // Use this for initialization
    void Start()
    {
        //float minX = cam.ScreenToWorldPoint(gameObject.GetComponent<RectTransform>().rect.min).x;
        //float weight = cam.ScreenToWorldPoint(gameObject.GetComponent<RectTransform>().rect.max).x- minX;
        //print(weight);
        float weight = gameObject.GetComponent<RectTransform>().rect.width;
        float deltaX = weight / 11f;
        for (int i = 1; i < 11; i++)
        {
            GameObject _cirscle = Instantiate(cirsle, gameObject.transform);
            _cirscle.GetComponent<RectTransform>().localPosition = new Vector3(deltaX * i - weight / 2, -15f, 0f);
            posX[i - 1] = deltaX * i - weight / 2;
        }
        for (int i = 0; i < 9; i++)
        {
            GameObject _arrow = Instantiate(arrow, transform);            
            _arrow.GetComponent<RectTransform>().localPosition = new Vector3(posX[i]+ (posX[i+1]- posX[i])/2, -15f, 0f); 
        }
    }
	
	public void VisuallyImpaired()
    {

    }
    public void VoiceAssistant()
    {

    }
    public void Ask()
    {

    }
}
