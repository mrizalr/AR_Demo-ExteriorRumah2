using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHandler : MonoBehaviour {

    float angle = 0.15f;
    float speed = 0.5f;
    float timeZoom = 0.0f;
    float maxZoom = 0.15f;
    float minZoom = 0.05f;

    bool zoomingStatus = false;
    bool isZooming = false;

    // Use this for initialization
    void Start () {
        zoomingStatus = false;
	}
	
	// Update is called once per frame
	void Update () {
        putarAnim();
        if (zoomingStatus && transform.localScale.x < maxZoom)
        {
            zoomIn();
        }
        else if (!zoomingStatus && transform.localScale.x > minZoom)
        {
            zoomOut();
        }

        if (!isZooming)
        {
            timeZoom = 0;
        }

        isZooming = false;
    }

    void putarAnim()
    {
        transform.Rotate(0, angle, 0);
    }   

    void zoomIn()
    {
        if (timeZoom < 2)
        {
            float focalLength = Mathf.Lerp(minZoom, maxZoom, timeZoom);
            transform.localScale = new Vector3(focalLength, focalLength, focalLength);
            timeZoom += 0.05f;
            isZooming = true;
        }
    }

    void zoomOut()
    {
        if (timeZoom < 2)
        {
            float focalLength = Mathf.Lerp(maxZoom, minZoom, timeZoom);
            transform.localScale = new Vector3(focalLength, focalLength, focalLength);
            timeZoom += 0.05f;
            isZooming = true;
        }
    }


    public void zoomClick()
    {
        if (zoomingStatus)
        {
            zoomingStatus = false;
        }
        else if (!zoomingStatus)
        {
            zoomingStatus = true;
        }
    }
}
