using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private FinishPoint door;

    public bool AllBloodCollected => bloodLeftToCollect <= 0;
    public UIManager UIManager;
    private int totalBlood;
    private int bloodLeftToCollect;
    private int bloodCollected = 0;


    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;

        totalBlood = FindObjectsByType<CollectableBlood>(FindObjectsSortMode.None).Length;
        bloodLeftToCollect = totalBlood;

        UIManager.UpdateBloodCountText(bloodCollected, totalBlood);
    }

    public void UpdateBloodLeft()
    {
        bloodLeftToCollect--;
        bloodCollected++;
        UIManager.UpdateBloodCountText(bloodCollected, totalBlood);
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
