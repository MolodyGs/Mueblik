using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BCambioEscena : Boton
{
    [SerializeField] string NombreEscena;
    override
    public void OnUp()
    {
        SceneManager.LoadScene(NombreEscena);
    }
}
