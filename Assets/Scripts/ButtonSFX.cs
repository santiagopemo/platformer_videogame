using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSFX : MonoBehaviour
{
    [Header("Buttons Sounds")]
    public AudioSource buttonRollover;
    public AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        AddButtonsTriggers();
    }

    // Start is called before the first frame update

    void AddButtonsTriggers()
    {
        
        EventTrigger btnETrigger = gameObject.AddComponent<EventTrigger>();
        // Adding Hover Trigger
        EventTrigger.Entry hoverEntry = new EventTrigger.Entry();
        hoverEntry.eventID = EventTriggerType.PointerEnter;
        hoverEntry.callback.AddListener((data) => {OnButtonHover();});
        btnETrigger.triggers.Add(hoverEntry);
        // Adding Click Trigger
        EventTrigger.Entry clickEntry = new EventTrigger.Entry();
        clickEntry.eventID = EventTriggerType.PointerDown;
        clickEntry.callback.AddListener((data) => {OnButtonClick();});
        btnETrigger.triggers.Add(clickEntry);            

    }

    public void OnButtonHover()
    {
        buttonRollover.Play();
    }

    public void OnButtonClick()
    {
        buttonClick.Play();
    }
}
