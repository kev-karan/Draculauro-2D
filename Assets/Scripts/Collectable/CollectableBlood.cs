using UnityEngine;

public class CollectableBlood : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.UpdateBloodLeft();
        Destroy(gameObject);
    }
}
