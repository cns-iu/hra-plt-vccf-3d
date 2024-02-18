using UnityEngine;

public class CellDuplicator : MonoBehaviour
{
    public GameObject EndoCell; // Drag your prefab here in the Unity editor
    public GameObject Cell;
    private float randRange = 0.48f;

void Start()
    {
        DuplicatePrefab();
    }

    void DuplicatePrefab()
    {
        for (int i = 0; i < 10; i++)
        {
            float randX = Random.Range(-randRange, randRange);
            float randY = Random.Range(-randRange, randRange);
            float randZ = Random.Range(-randRange, randRange);
            Instantiate(EndoCell, new Vector3(randX,randY,randZ), Quaternion.identity);
        }
        for (int i = 0; i < 100; i++)
        {
            float randX = Random.Range(-randRange, randRange);
            float randY = Random.Range(-randRange, randRange);
            float randZ = Random.Range(-randRange, randRange);
            Instantiate(Cell, new Vector3(randX, randY, randZ), Quaternion.identity);
        }
    }
}
