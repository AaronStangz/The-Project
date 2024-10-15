using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Hub : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int pickUpRange;
    public bool HubOpen;

    public GameObject HubGUI;
    public GameObject Player;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && HubOpen)
        {
            HubOpen = false;
            HubGUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    public void Open()
    {
        HubOpen = true;
        HubGUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<PlayerMovement>().enabled = false;
    }
}
