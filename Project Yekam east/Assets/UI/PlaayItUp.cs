using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaayItUp : MonoBehaviour {

    public GameObject Panel;

    public void SelectItUp()
    {
        Panel.SetActive(true);
    }

}
