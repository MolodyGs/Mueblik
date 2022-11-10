using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSalir : Boton
{
    override
    public void OnUp()
    {
        Application.Quit();
    }
}
