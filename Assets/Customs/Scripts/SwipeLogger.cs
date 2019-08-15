using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    private void Awake()
    {
        Swipe.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        Debug.Log("Swipe in Direction: " + data.Direction);
    }
}