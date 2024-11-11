using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour {
    public void IniciarJogo() { 
        SceneManager.LoadScene("SandBox");

    }

    public void FecharJogo() {
        Application.Quit();
        Debug.Log("Fechou o jogo");

    }

}
