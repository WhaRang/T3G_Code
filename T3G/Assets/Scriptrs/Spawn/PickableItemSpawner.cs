using UnityEngine;

public class PickableItemSpawner : MonoBehaviour
{
    [SerializeField]
    private PickableItemFactory factory;

    [SerializeField]
    private PickableItamObjectPool pool;

    public void SpawnPickableItem()
    {
        PickableItem spawnedObj = factory.GetNewInstance();

        Vector3 spawnedObjPos = new Vector3(transform.position.x + Random.Range(-5.0f, 5.0f),
            transform.position.y, transform.position.z + Random.Range(-5.0f, 5.0f));

        spawnedObj.transform.position = spawnedObjPos;
    }

    public void DespawnAllItems()
    {
        pool.ReturmAllToPool();
    }
}
