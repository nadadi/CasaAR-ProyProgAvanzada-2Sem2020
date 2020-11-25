using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private GameObject myPlane;

    public void Touch()
    {
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
    }

    public GameObject GetMyPlane()
    {
        return myPlane;
    }
}
