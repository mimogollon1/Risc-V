using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	public static void inicia()
    {
        Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        panelRam.color = Color.clear;
        Image panelPc = GameObject.Find("PCPanel").GetComponent<Image>();
        panelPc.color = panelPc.color = new Color32(255, 0, 0, 100);
    }
}
