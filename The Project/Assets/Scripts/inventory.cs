using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject inventoryGUI;
    [Space]
    public GameObject mainManager;
    MainManager MM;

    [Space]
    public GameObject[] item;
    public TMP_Text[] ItemText;

    public bool InvOpen;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab) && !InvOpen)
        {
            InvOpen = true;
            inventoryGUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
        }
        if (Input.GetKey(KeyCode.Escape) && InvOpen)
        {
            InvOpen = false;
            inventoryGUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.GetComponent<PlayerMovement>().enabled = true;
        }

        if (InvOpen)
        {
            Upgrade();
        }
    }

    public void Upgrade()
    {
        if (MM.ScrapPlanks >= 1)
        {
            item[0].SetActive(true);
            ItemText[0].text = MM.ScrapPlanks + " ";
        }
        if (MM.Planks >= 1)
        {
            item[1].SetActive(true);
            ItemText[1].text = MM.Planks + " ";
        }
        if (MM.ScrapMetal >= 1)
        {
            item[2].SetActive(true);
            ItemText[2].text = MM.ScrapMetal + " ";
        }
        if (MM.Metal >= 1)
        {
            item[3].SetActive(true);
            ItemText[3].text = MM.Metal + " ";
        }
    }
}
