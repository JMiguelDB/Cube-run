using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeGameUI;

    public void EndGame(){
        if(!gameHasEnded){
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            //Invoca el metodo nombrado tras N segundos
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteGame(){
        Debug.Log("Game completed");
        completeGameUI.SetActive(true);
    }

    void Restart(){
        //Carga la escena activa
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
