using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocateObjectAbovePlane : MonoBehaviour
{
    [SerializeField]
    private GameObject plane;
    [SerializeField]
    private GameObject prefabToInstantiate;

    private void Update() {
        //if(Input.GetMouseButtonDown(0))
        //if(Input.GetButtonDown("Space"))
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObjectToInstantiate = Instantiate(prefabToInstantiate, plane.transform.position, Quaternion.identity);
            
            BoxCollider boxCollider = gameObjectToInstantiate.GetComponent<BoxCollider>();
            Vector3 positionToInstantiate = Vector3.zero;
            if(boxCollider != null){
                //Debug.Log(boxCollider.bounds.size.y);
                positionToInstantiate = new Vector3(plane.transform.position.x, plane.transform.position.y + boxCollider.bounds.size.y/2, plane.transform.position.z);
            }

            gameObjectToInstantiate.transform.position = positionToInstantiate;
        }
    }
}
