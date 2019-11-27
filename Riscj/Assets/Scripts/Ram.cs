using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ram : MonoBehaviour {

    Multiplexor multiplexor;
    public Text t0, t1, t2;
    string valor;
    private IEnumerator rutina;

    // Use this for initialization
    public void enviRegistro(string registro)
    {
        multiplexor = gameObject.GetComponent<Multiplexor>();
        rutina = llamar(registro);
        StartCoroutine(rutina);
    }

    private IEnumerator llamar(string registro)
    {
        yield return new WaitForSeconds(1f);

        switch (registro.ToLower())
        {
            case "t0":
                valor = t0.text;
                break;
            case "t1":
                valor = t1.text;
                break;
            case "t2":
                valor = t2.text;
                break;
        }

        RawImage raya1 = GameObject.Find("raya1").GetComponent<RawImage>();
        raya1.color = new Color32(8, 30, 255, 255);
        RawImage raya2 = GameObject.Find("raya2").GetComponent<RawImage>();
        raya2.color = new Color32(8, 30, 255, 255);
        RawImage raya3 = GameObject.Find("raya3").GetComponent<RawImage>();
        raya3.color = new Color32(8, 30, 255, 255);
        Image IRPanel = GameObject.Find(registro.ToLower()+"panel").GetComponent<Image>();
        IRPanel.color = new Color32(255, 0, 0, 100);
        Image ALUPanel = GameObject.Find("IRPanel").GetComponent<Image>();
        ALUPanel.color = Color.white;
        RawImage raya8 = GameObject.Find("raya8").GetComponent<RawImage>();
        raya8.color = new Color32(255, 0, 0, 100);
        RawImage raya9 = GameObject.Find("raya9").GetComponent<RawImage>();
        raya9.color = new Color32(255, 0, 0, 100);
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = new Color32(255, 0, 0, 100);
        multiplexor.agregaNumero(valor, registro.ToLower() + "panel");
    }
}
