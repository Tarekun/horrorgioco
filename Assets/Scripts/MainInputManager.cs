using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainInputManager : MonoBehaviour
{
    public Button firstSelectedButton;

    void Start()
    {
        // set initial selection
        EventSystem.current.SetSelectedGameObject(firstSelectedButton.gameObject);
    }

    void Update()
    {
        // Optional: re-focus if user clears selection
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(firstSelectedButton.gameObject);
        }
    }
}
