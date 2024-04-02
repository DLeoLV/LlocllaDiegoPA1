using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPokeball : MonoBehaviour
{
    public GameObject cuadrado;

    public GameObject instantiatedObject;
    private Vector2 offset;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D collider = Physics2D.OverlapPoint(touchPosition);
                if (collider != null && collider.gameObject == instantiatedObject)
                {
                    //offset = (Vector2)instantiatedObject.transform.position - touchPosition;
                }
                else
                {
                    //instantiatedObject = Instantiate(cuadrado, touchPosition, Quaternion.identity);
                }
            }
            else if (touch.phase == TouchPhase.Moved && instantiatedObject != null)
            {
                instantiatedObject.transform.position = touchPosition + offset;
            }
        }
    }
}
