using UnityEngine;

public class GrabSystem : MonoBehaviour
{
    [SerializeField]
    private Camera playerCamera;

    [SerializeField]
    private Transform grabber;

    [SerializeField]
    private float throwPower;

    private PickableItem pickedItem;

    [SerializeField]
    private float grabLength;

    [SerializeField]
    private PickableItamObjectPool pool;

    private void Start()
    {
        GameController.Instance.Controls.Player.Pick.performed += _ => Pick();
        GameController.Instance.Controls.Player.ReturnToPool.performed += _ => ReturnToPool();
    }

    private void ReturnToPool()
    {
        if (pickedItem)
            return;

        Ray ray = playerCamera.ViewportPointToRay(Vector3.one * 0.5f);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, grabLength))
        {
            PickableItem pickable = hit.transform.GetComponent<PickableItem>();
            if (pickable != null)
            {
                pool.ReturnToPool(pickable);  
            }
        }
    }

    private void Pick()
    {
        if (pickedItem)
        {
            DropItem(pickedItem);
        }
        else
        {
            Ray ray = playerCamera.ViewportPointToRay(Vector3.one * 0.5f);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, grabLength))
            {
                PickableItem pickable = hit.transform.GetComponent<PickableItem>();
                if (pickable != null)
                {
                    PickItem(pickable);
                }
            }
        }
    }

    private void DropItem(PickableItem item)
    {
        pickedItem = null;
        item.transform.SetParent(null);
        item.Rb.isKinematic = false;
        item.Rb.AddForce(item.transform.forward * throwPower, ForceMode.VelocityChange);
    }

    private void PickItem(PickableItem item)
    {
        pickedItem = item;

        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        item.transform.SetParent(grabber);

        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;
    }
}
