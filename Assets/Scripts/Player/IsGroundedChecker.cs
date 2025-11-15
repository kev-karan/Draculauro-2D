using UnityEngine;

public class IsGroundedChecker : MonoBehaviour
{
    [SerializeField] private Transform checkerPosition;
    [SerializeField] private Vector2 checkerSize;
    [SerializeField] private LayerMask groundLayer;
}
