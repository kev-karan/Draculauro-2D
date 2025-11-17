using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool AllBloodCollected => bloodLeftToCollect <= 0;

    private int totalBlood;
    private int bloodLeftToCollect;

    [SerializeField] private FinishPoint door;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;

        totalBlood = FindObjectsByType<CollectableBlood>(FindObjectsSortMode.None).Length;
        bloodLeftToCollect = totalBlood;
    }

    public void UpdateBloodLeft()
    {
        bloodLeftToCollect--;
        CheckAllBloodCollected();
    }

    private void CheckAllBloodCollected()
    {
        if (bloodLeftToCollect <= 0)
        {
            if (AllBloodCollected)
            {
                door.UnlockDoor();
            }
        }
    }
}
