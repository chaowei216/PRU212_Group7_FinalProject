using System.Collections;
using UnityEngine;

public class CheatCodeManager : MonoBehaviour
{
    private KeyCode[] cheatCode;
    private int index;
    private float timer;
    public float maxTimeBetweenKeys = 3.0f; // thời gian tối đa giữa các phím

    void Start()
    {
        cheatCode = new KeyCode[] {KeyCode.LeftArrow, KeyCode.LeftArrow, KeyCode.DownArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.RightArrow, KeyCode.M };
        index = 0;
        timer = 0;
    }

    void Update()
    {
        if (index > 0) 
        {
            timer += Time.deltaTime;
            if (timer > maxTimeBetweenKeys)
            {
                index = 0; // Đặt lại nếu quá thời gian tối đa
                timer = 0;
            }
        }

        if (index < cheatCode.Length)
        {
            if (Input.GetKeyDown(cheatCode[index]))
            {
                index++;
                timer = 0; // Đặt lại bộ đếm thời gian khi nhập đúng phím
                if (index == cheatCode.Length)
                {
                    ActivateCheat();
                }
            }
            else if (Input.anyKeyDown)
            {
                index = 0; // Đặt lại nếu bất kỳ phím nào sai được nhấn
                timer = 0;
            }
        }
    }

    void ActivateCheat()
    {
        Debug.Log("Cheat Activated: Immortal Mode");
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.GetComponent<HealthPlayer>().SetImmortal(true);
        }
    }
}
