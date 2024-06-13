using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelesController : MonoBehaviour
{
    public void CargarSiguienteNivel()
    {
        int siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (siguienteNivel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(siguienteNivel);
        }
        else
        {
            StartCoroutine(MostrarMensajeFinDeNiveles());
        }
    }

    private IEnumerator MostrarMensajeFinDeNiveles()
    {
        yield return new WaitForSeconds(5);
        UnityEngine.Debug.Log("¡Has completado todos los niveles!");
    }
}