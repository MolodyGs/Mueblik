using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCambioPanel : Boton
{
    [SerializeField] GameObject panelToOpen;
    [SerializeField] GameObject panelToClose;

    override
    public void OnUp()
    {
        this.panelToClose.SetActive(false);
        this.panelToOpen.SetActive(true);
    }
}
