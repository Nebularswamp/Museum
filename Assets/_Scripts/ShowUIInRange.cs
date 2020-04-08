using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIInRange : MonoBehaviour
{
    public GameObject ui;

    void Start()
    {
        HideUI();
    }


    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ShowUI();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HideUI();
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
    }

    public void ShowUI()
    {
        ui.SetActive(true);
    }
}
