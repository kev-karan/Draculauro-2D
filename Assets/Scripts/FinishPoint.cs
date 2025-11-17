using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    [SerializeField] private Transform crossIndicator;

    private void Start()
    {
        crossIndicator.rotation = Quaternion.identity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (GameManager.Instance.AllBloodCollected)
        {
            SceneController.Instance.NextLevel();
        }
    }
    public void UnlockDoor()
    {
        crossIndicator.localRotation = Quaternion.Euler(0, 0, 180);
    }
}
