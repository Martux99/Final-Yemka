using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause2 : MonoBehaviour {

    public GameObject Panel;

    public void pauseItUp2()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
    }
}
