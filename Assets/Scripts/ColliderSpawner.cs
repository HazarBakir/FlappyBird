using System.Collections;
using UnityEngine;

public class ColliderSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (true)
        {
            Instantiate(objectToSpawn, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

        }

    }
}
