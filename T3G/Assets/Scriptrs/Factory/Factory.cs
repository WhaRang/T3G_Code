using UnityEngine;

public class Factory<T> : MonoBehaviour where T: MonoBehaviour
{
    [SerializeField]
    private ObjectPool<T> pool;

    public T GetNewInstance()
    {
        T objectFromPool = pool.GetItemFromPool();
        objectFromPool.gameObject.SetActive(true);

        return objectFromPool;
    }
}
