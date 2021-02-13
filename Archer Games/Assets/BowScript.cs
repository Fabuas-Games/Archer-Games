using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowScript : MonoBehaviour
{
    public Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 BowPos = transform.position;
        Direction = MousePos - BowPos;
        FaceMouse();
    }

    void FaceMouse()
    {
        transform.right = Direction;
    }
}
