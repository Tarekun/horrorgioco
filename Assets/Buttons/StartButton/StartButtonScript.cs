using UnityEngine;
using TMPro;

public class StartButtonScript : MonoBehaviour
{
    int i = 0;

    public void Test()
    {
        i++;
        Debug.Log($"test n {i}");
    }
}
