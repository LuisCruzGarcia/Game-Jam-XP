using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class itemSlot : MonoBehaviour, IDropHandler
{
    public int slotNumber;
    execute execute;

    private void Start()
    {
        execute = GameObject.Find("execute").GetComponent<execute>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        //Gameobject being dropped
        //eventData.pointerDrag
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;


        }


        if(eventData.pointerDrag.name == "instructionUp")
        {
            execute.instructions[slotNumber] = 1;
        } else if (eventData.pointerDrag.name == "instructionDown")
        {
            execute.instructions[slotNumber] = 2;
        }
        else if (eventData.pointerDrag.name == "instructionRigth")
        {
            execute.instructions[slotNumber] = 3;
        }
        else if (eventData.pointerDrag.name == "instructionLeft")
        {
            execute.instructions[slotNumber] = 4;
        }
        else if (eventData.pointerDrag.name == "Fire")
        {
            execute.instructions[slotNumber] = 5;
        }
        else if (eventData.pointerDrag.name == "doorWifi")
        {
            execute.instructions[slotNumber] = 6;
        }


    }

}
