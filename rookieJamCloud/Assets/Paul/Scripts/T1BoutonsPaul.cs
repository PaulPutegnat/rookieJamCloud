using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boutons : MonoBehaviour {
    public void lancerJeu()
    {
        SceneManager.LoadScene("T1GamePaul", LoadSceneMode.Single);
    }

}
