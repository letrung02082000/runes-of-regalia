using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    private Vector2 firstTouchPosition;
    private Vector2 finalTouchPosition;
    public float swipeAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onMouseDown()
    {
        firstTouchPosition = Input.mousePosition;
        Debug.Log(firstTouchPosition);
    }
}
