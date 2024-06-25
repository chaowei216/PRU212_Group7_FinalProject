using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public float deplayScreen = 2;
    public string nameScreen = "Level3";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.SetActive(false);
            MonoSelect();
        }
    }

    public void MonoSelect()
    {
        StartCoroutine(LoadAfterDeplay());
    }

    IEnumerator LoadAfterDeplay()
    {
        yield return new WaitForSeconds(deplayScreen);

        SceneManager.LoadScene(nameScreen);
    }
}
