using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenResolutionScript : MonoBehaviour
{
    public int adaptPosition;
    public bool maintainWidth = true;
    float defaultWidth;
    float defaultHeight;

    Vector2 CameraPos;
    // Start is called before the first frame update
    void Start()
    {
        CameraPos = Camera.main.transform.position;
        defaultHeight = Camera.main.orthographicSize;
        defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (maintainWidth)
        {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
            Camera.main.transform.position = new Vector2(CameraPos.x,-1*(defaultHeight-Camera.main.orthographicSize));
        } else
        {

            Camera.main.transform.position = new Vector2(adaptPosition*(defaultWidth-Camera.main.orthographicSize),CameraPos.y);
        }
    }
}
