using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T1MenuPrincipale : MonoBehaviour {
    public void lancerJeu()
    {
        SceneManager.LoadScene("T1GamePaul", LoadSceneMode.Single);
    }

    public void quitterJeu()
    {
        Debug.Log("QUITTER");
        Application.Quit();
    }

}
