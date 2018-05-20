using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad1 : MonoBehaviour {


    public void ClickIt()
    {
        SceneManager.LoadScene("Level1");
    }
}
