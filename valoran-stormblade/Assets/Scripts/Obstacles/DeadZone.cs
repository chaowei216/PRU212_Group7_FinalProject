using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private UIManager uiManager;
    public void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ditme a Vi");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("xin bao ngo gia");
            uiManager.GameOver();
            return;
        }
    }
}
