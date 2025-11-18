using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI BloodCount;

    public void UpdateBloodCountText(int currentValue, int totalValue)
    {
        BloodCount.text = $"{currentValue}/{totalValue}";
    }
}
