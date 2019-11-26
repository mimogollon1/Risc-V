using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decoder : MonoBehaviour {

    Multiplexor multiplexor;

    private IEnumerator rutina;

    public Text identificador;
    private string sentencia;

    public void decodificar()
    {
        multiplexor = gameObject.GetComponent<Multiplexor>();
        sentencia = identificador.text.Split(' ')[0];
        rutina = decodifica(); 
        StartCoroutine(rutina);
    }

    public IEnumerator decodifica()
    {
        yield return new WaitForSeconds(1f);
        RawImage raya1= GameObject.Find("raya1").GetComponent<RawImage>();
        raya1.color = new Color32(8, 30, 255, 255);
        RawImage raya2 = GameObject.Find("raya2").GetComponent<RawImage>();
        raya2.color = new Color32(8, 30, 255, 255);
        RawImage raya3 = GameObject.Find("raya3").GetComponent<RawImage>();
        raya3.color = new Color32(8, 30, 255, 255);
        RawImage raya4 = GameObject.Find("raya4").GetComponent<RawImage>();
        raya4.color = new Color32(255, 0, 0, 100);
        Image panelIR = GameObject.Find("IRPanel").GetComponent<Image>();
        panelIR.color = Color.white;
        Image DecorerPanel = GameObject.Find("DecorerPanel").GetComponent<Image>();
        DecorerPanel.color = new Color32(255, 0, 0, 100);



        //Image panelPc = GameObject.Find("PCPanel").GetComponent<Image>();
        //panelPc.color = Color.white;
        //Image r0 = GameObject.Find("01").GetComponent<Image>();
        //r0.color = new Color32(255, 0, 0, 100);
        //RawImage raya0 = GameObject.Find("raya0").GetComponent<RawImage>();
        //raya0.color = new Color32(255, 0, 0, 100);
        //RawImage raya1 = GameObject.Find("raya1").GetComponent<RawImage>();
        //raya1.color = new Color32(255, 0, 0, 100);
        //RawImage raya2 = GameObject.Find("raya2").GetComponent<RawImage>();
        //raya2.color = new Color32(255, 0, 0, 100);
        //Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        //panelRam.color = Color.clear;
    }
}
