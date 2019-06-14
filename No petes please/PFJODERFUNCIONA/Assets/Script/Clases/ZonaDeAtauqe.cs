using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZonaDeAtauqe : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
    /// <summary>
    /// Metodo encargado de activar o desativar el componente del ataque asociado al jugador
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public IEnumerator ShowArea(string name) {
        anim.Play("Area_Show");
        transform.GetChild(0).GetComponent<Text>().text = name;
        transform.GetChild(1).GetComponent<Text>().text = name;
        yield return new WaitForSeconds(1f);
        anim.Play("Area_FadeOut");
    }

}
