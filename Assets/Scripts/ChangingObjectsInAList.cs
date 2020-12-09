using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ChangingObjectsInAList : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> references;
    [SerializeField]
    private GameObject cubePrefab;
    [SerializeField]
    private GameObject spherePrefab;

    private void Awake() {
        references = new List<GameObject>();
        GameObject[] arrayOfGameObjects = GameObject.FindGameObjectsWithTag("Reference");
        references = arrayOfGameObjects.ToList();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.C))
        {
            /*for(int index = 0; index < references.Count; index++)
            {
                references[index] = X;
            }*/

            foreach (GameObject item in references)
            {
                if(item.transform.childCount > 0)
                {
                    foreach (Transform child in item.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                GameObject go = Instantiate(cubePrefab, item.transform.position, Quaternion.identity);
                go.transform.parent = item.transform;
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            foreach (GameObject item in references)
            {
                if(item.transform.childCount > 0)
                {
                    foreach (Transform child in item.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                GameObject go = Instantiate(spherePrefab, item.transform.position, Quaternion.identity);
                go.transform.parent = item.transform;
            }
        }

        /*if(Input.GetKeyDown(KeyCode.F))
        {
            
        }*/
    }
}
