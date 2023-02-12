using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego1()
    {
        SceneManager.LoadScene("Juego1");
    }

    public void EscenaJuego2()
    {
        SceneManager.LoadScene("Juego 2");
    }

    public void EscenaJuego3()
    {
        SceneManager.LoadScene("Juego 3");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("EscenarioJuego");
    }
}
