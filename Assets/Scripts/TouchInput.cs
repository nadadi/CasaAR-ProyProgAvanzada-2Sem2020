using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    #region CLASS_VARIABLES
    private Touch touch;    
    private bool touchingScreen;
    #endregion

    private void Start() {
        touchingScreen = false;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Debug.Log("Se está tocando la pantalla del dispositivo");

            touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Acaba de comenzar un toque en la pantalla");
                    touchingScreen = true;
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Estoy moviendo el dedo por la pantalla");
                    touchingScreen = true;
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("Estoy tocando la pantalla");
                    touchingScreen = true;
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Ya no estoy tocando la pantalla");
                    touchingScreen = false;
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Se canceló el toque en la pantalla");
                    touchingScreen = false;
                    break;
            }
        }
    }

    private void FixedUpdate() {
        //Vector3 inputPosition = touch.position;
        //if(Input.GetMouseButton(0))
        //{

        //if(touchingScreen)
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            float rayDistance = 100f;
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                //Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);
                if(hit.collider != null)
                {
                    GameObject gameObjectOfHit = hit.collider.gameObject;
                    gameObjectOfHit.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                    print("Hit something!");
                }
            }
        }else
        {
            print("Rayo nulo");
        }

        //}
    }
}
