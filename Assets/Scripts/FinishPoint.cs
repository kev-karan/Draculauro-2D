using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (GameManager.Instance.AllBloodCollected)
        {
            SceneController.Instance.NextLevel();
        }
    }
}
