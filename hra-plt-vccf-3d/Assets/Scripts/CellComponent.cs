using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum CellType { Endo, Blood }

public class CellComponent : MonoBehaviour
{
    [SerializeField] private CellType _cellType;
    [SerializeField] private Vector3 position;


    void Start()
    {
        position = gameObject.transform.position;
    }


}

