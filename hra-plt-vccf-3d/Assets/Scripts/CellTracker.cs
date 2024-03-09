using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CellTracker : MonoBehaviour {

    [SerializeField]
    private Vector3 CellPosition;

    void Start() 
    {
        //positions.Add()
        CellPosition = transform.position;
    }

    void Update()
    {

    }
}
