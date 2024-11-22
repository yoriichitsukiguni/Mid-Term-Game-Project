using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;  // Spawn edilecek nesneler
    public int howManyObjects;  // Ka� tane nesne spawn edilecek

    void Start()
    {
        SpawnObjects();  // Ba�lat�nca nesneleri yerle�tir
    }

    void SpawnObjects()
    {
        for (int i = 0; i < howManyObjects; i++)
        {
            // Rastgele bir yer se�
            Vector3 position = new Vector3(Random.Range(-2, 3), 2f, Random.Range(-3, 3));
            // Rastgele bir nesne se�
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            // O nesneyi yarat
            Instantiate(objectsToSpawn[randomIndex], position, Quaternion.identity);
        }
    }
}
