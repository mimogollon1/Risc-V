using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    public Text idReg,contProg;

    private IEnumerator rutina;
    private IEnumerator rutina2;
    Decoder decoder;



    public void inicia()
    {
        decoder = gameObject.GetComponent<Decoder>();
        Image panelPc = GameObject.Find("PCPanel").GetComponent<Image>();
        panelPc.color = new Color32(255, 0, 0, 100);
        rutina = cargaRegistro(); ;
        StartCoroutine(rutina);
        rutina2 = cargaIdentificador(); ;
        StartCoroutine(rutina2);
    }

    public IEnumerator cargaRegistro()
    {
        yield return new WaitForSeconds(1f);
        Image panelPc = GameObject.Find("PCPanel").GetComponent<Image>();
        panelPc.color = Color.white;
        Image r0 = GameObject.Find("01").GetComponent<Image>();
        r0.color = new Color32(255, 0, 0, 100);
        RawImage raya0 = GameObject.Find("raya0").GetComponent<RawImage>();
        raya0.color = new Color32(255, 0, 0, 100);
        RawImage raya1 = GameObject.Find("raya1").GetComponent<RawImage>();
        raya1.color = new Color32(255, 0, 0, 100);
        RawImage raya2 = GameObject.Find("raya2").GetComponent<RawImage>();
        raya2.color = new Color32(255, 0, 0, 100);
        Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        panelRam.color = Color.clear;
    }

    public IEnumerator cargaIdentificador()
    {
        yield return new WaitForSeconds(2f);
        Image panelPc = GameObject.Find("PCPanel").GetComponent<Image>();
        panelPc.color = Color.white;
        Image r0 = GameObject.Find("01").GetComponent<Image>();
        r0.color = Color.white;
        RawImage raya0 = GameObject.Find("raya0").GetComponent<RawImage>();
        raya0.color = new Color32(8, 30, 255, 255);
        RawImage raya1 = GameObject.Find("raya3").GetComponent<RawImage>();
        raya1.color = new Color32(255, 0, 0, 100);
        Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        panelRam.color = Color.clear;
        idReg.text = GameObject.Find("r"+contProg.text).GetComponent<Text>().text;
        Image panelIR = GameObject.Find("IRPanel").GetComponent<Image>();
        panelIR.color = new Color32(255, 0, 0, 100);
        decoder.decodificar();
    }

}
