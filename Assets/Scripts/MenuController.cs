using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Agregar esto para que funcione el SceneManager

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // Cargar la escena del juego cuando se haga clic en "Jugar"
        SceneManager.LoadScene("SampleScene"); // Asegúrate de que "SampleScene" sea el nombre exacto de tu escena de juego 
    }
}