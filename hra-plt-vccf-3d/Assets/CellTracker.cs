using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CellTracker : MonoBehaviour {
    [SerializeField]
    public Vector3 position;
    void Start() 
    {
        position = gameObject.transform.position;
        //next is to modify the script so that the script affects ALL endo cells
        // achieved by creating a condition about the tag of the cells
    }

    void Update()
    {

    }
}
