using UnityEngine;

public class CellDuplicator : MonoBehaviour
{
    public GameObject EndoCell; // Drag your prefab here in the Unity editor
    public GameObject BloodCell;
    private float spawnRange = 0.45f; //spawn range within cylinder
    private float cylinderRadius = 0.5f;

    void Start()
    {
        DuplicatePrefab(100, BloodCell, false);
        DuplicatePrefab(10, EndoCell, true);

    }

    void DuplicatePrefab(int spawns, GameObject obj, bool onSurface)
    {
        for (int i = 0; i < spawns; i++)
        {
            float randAngle = Random.Range(0f, Mathf.PI * 2f);
            float x = Mathf.Cos(randAngle) * cylinderRadius;
            float z = Mathf.Sin(randAngle) * cylinderRadius;
            float randX = Random.Range(-(spawnRange * 0.8f), spawnRange * 0.8f);
            float randY = Random.Range(-(spawnRange * 2), spawnRange * 2);
            float randZ = Random.Range(-(spawnRange * 0.8f), spawnRange * 0.8f);
            Quaternion theta = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            if (onSurface)
            {
                Quaternion rotation = Quaternion.Euler(randAngle, randAngle, randAngle);
                Vector3 position = new Vector3(x, 0.5f, z);
                Instantiate(obj, position, rotation);
            }
            else
            {
                Quaternion rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
                Vector3 position = new Vector3(randX, randY, randZ);
                Instantiate(obj, position, rotation);
            }
        }
    }
}

    /*
    void SpawnCellsOnCylinder(GameObject obj, bool onSurface)
    {
        for (int i = 0; i < 10; i++)
        {
            // Calculate random angle
            // Calculate position on cylinder
            
            float y = onSurface ? cylinderRadius * 2 * Random.Range(0, 1) - cylinderRadius : Random.Range(-cylinderRadius, cylinderRadius);

            Vector3 randPosition = new Vector3(x, y, z);
            Quaternion randRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            Instantiate(obj, randPosition, randRotation);
        }
    }
    */