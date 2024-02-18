using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum CellType { Endo, NonEndo }

public class CellComponent : MonoBehaviour
{
    [SerializeField] private CellType _cellType;
    [SerializeField] private Vector3 position;
    //[SerializeField] private List distToCells;

    void Start()
    {
        position = gameObject.transform.position;
      //  distToCells = ;
    }


}

