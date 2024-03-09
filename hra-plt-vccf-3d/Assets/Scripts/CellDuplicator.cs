using UnityEngine;

public class CellDuplicator : MonoBehaviour
{
    public GameObject EndoCell; // Drag your prefab here in the Unity editor
    public GameObject BloodCell;
    private float spawnRange = 0.43f;

void Start()
    {
        DuplicatePrefab(100, BloodCell);
        DuplicatePrefab(10, EndoCell);
    }

    void DuplicatePrefab(int spawns, GameObject obj)
    {
        for (int i = 0; i < spawns; i++)
        {
            float randX = Random.Range(-(spawnRange* (float)0.8), spawnRange* (float)0.8);
            float randY = Random.Range(-(spawnRange*2), spawnRange*2);
            float randZ = Random.Range(-(spawnRange*(float)0.8), spawnRange* (float)0.8);
            Vector3 randPosition = new Vector3(randX, randY, randZ);
            Quaternion randRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            Instantiate(obj, randPosition, randRotation);
        }
    }
}
