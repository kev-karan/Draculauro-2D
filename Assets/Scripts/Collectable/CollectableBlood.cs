using UnityEngine;

public class CollectableBlood : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("O item foi coletado");
        Destroy(gameObject);
    }
}
