using UnityEngine;

public class PickupObject : MonoBehaviour
{

    bool isAvailable = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (isAvailable)
        {
            if (collider.TryGetComponent<PlayerInventory>(out PlayerInventory inv))
            {
                isAvailable = false;
                this.gameObject.SetActive(false);
                inv.total++;
            }
        }
    }
}
