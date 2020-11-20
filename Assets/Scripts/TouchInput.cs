using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Debug.Log("Se está tocando la pantalla del dispositivo");

            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Acaba de comenzar un toque en la pantalla");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Estoy moviendo el dedo por la pantalla");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Ya no estoy tocando la pantalla");
                    break;
            }
        }
    }
}
