using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Boton : MonoBehaviour
{

    private bool exit;
    private bool enter;

    public abstract void OnUp();

    public void OnExit()
    {
        exit = true;
    }

}
