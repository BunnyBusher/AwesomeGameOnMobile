using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _mousePositionOnClick;
    


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _mousePositionOnClick = Input.mousePosition;

            if (_mousePositionOnClick.x < 0)
            {
                _mousePositionOnClick.x = 0;
            }
            else if (_mousePositionOnClick.x > Screen.width)
            {
                _mousePositionOnClick.x = Screen.width; 
            }
            Vector3 newpos = Camera.main.ScreenToWorldPoint(_mousePositionOnClick);

            transform.position = new Vector3(newpos.x,transform.position.y,0);
        }

    }
}
