using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator AnimatorSilla;
    [SerializeField] Animator AnimatorCalabaza;
    [SerializeField] Animator AnimatorVelador;

    private void Start()
    {
        StartCoroutine(Orden());
    }

    IEnumerator Orden ()
    {
        AnimatorSilla.SetBool("ActiveS", true);
        yield return new WaitForSeconds(4f);
        AnimatorSilla.SetBool("ActiveS", false);
        AnimatorVelador.SetBool("ActiveV", true);
        yield return new WaitForSeconds(4f);
        AnimatorVelador.SetBool("ActiveV", false);
        AnimatorCalabaza.SetBool("ActiveC", true);
        yield return new WaitForSeconds(4f);
        AnimatorCalabaza.SetBool("ActiveC", false);
        StartCoroutine(Orden());

    } 

}
