using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplexor : MonoBehaviour
{
    Ram ram;
    Alu alu;
    private IEnumerator rutina,rutina2, rutina3;
    // Use this for initialization
    public void carga(string registro)
    {
        ram = gameObject.GetComponent<Ram>();
        alu = gameObject.GetComponent<Alu>();
        rutina = indexa(registro);
        StartCoroutine(rutina);
    }

    public IEnumerator indexa(string registro)
    {
        yield return new WaitForSeconds(2f);
       
        RawImage raya5 = GameObject.Find("raya5").GetComponent<RawImage>();
        raya5.color = new Color32(8, 30, 255, 255);
        RawImage raya6 = GameObject.Find("raya6").GetComponent<RawImage>();
        raya6.color = new Color32(8, 30, 255, 255);
        RawImage raya7 = GameObject.Find("raya7").GetComponent<RawImage>();
        raya7.color = new Color32(8, 30, 255, 255);
        Image IRPanel = GameObject.Find("IRPanel").GetComponent<Image>();
        IRPanel.color = new Color32(255, 0, 0, 100);
        RawImage raya2 = GameObject.Find("raya2").GetComponent<RawImage>();
        raya2.color = new Color32(255, 0, 0, 100);
        RawImage raya3 = GameObject.Find("raya3").GetComponent<RawImage>();
        raya3.color = new Color32(255, 0, 0, 100);
        RawImage raya1 = GameObject.Find("raya1").GetComponent<RawImage>();
        raya1.color = new Color32(255, 0, 0, 100);
        Image ALUPanel = GameObject.Find("ALUPanel").GetComponent<Image>();
        ALUPanel.color = Color.white;
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = Color.white;
        ram.enviRegistro(registro);
    }

    public void agregaNumero(string valor, string panel)
    {
        rutina2 = pasarAlu(valor, panel);
        StartCoroutine(rutina2);
    }

    public IEnumerator pasarAlu(string valor,string panel)
    {
        yield return new WaitForSeconds(1f);
        if (String.IsNullOrEmpty(alu.x.text))
        {
            alu.x.text = valor;
        }
        else
        {
            alu.y.text = valor;
        }

        RawImage raya8 = GameObject.Find("raya8").GetComponent<RawImage>();
        raya8.color = new Color32(8, 30, 255, 255);
        RawImage raya9 = GameObject.Find("raya9").GetComponent<RawImage>();
        raya9.color = new Color32(8, 30, 255, 255);
        Image IRPanel = GameObject.Find(panel).GetComponent<Image>();
        IRPanel.color = Color.white;
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = Color.white;
        Image ALUPanel = GameObject.Find("ALUPanel").GetComponent<Image>();
        ALUPanel.color = new Color32(255, 0, 0, 100);
        RawImage raya10 = GameObject.Find("raya10").GetComponent<RawImage>();
        raya10.color = new Color32(255, 0, 0, 100);
        alu.ejecuta();
    }

    public void guardaNumero(string valor, string panel)
    {
        rutina3 = pasarRam(valor, panel);
        StartCoroutine(rutina3);
    }

    public IEnumerator pasarRam(string valor, string panel)
    {
        yield return new WaitForSeconds(1f);

        RawImage raya4 = GameObject.Find("raya4").GetComponent<RawImage>();
        raya4.color = new Color32(8, 30, 255, 255);
        RawImage raya5 = GameObject.Find("raya5").GetComponent<RawImage>();
        raya5.color = new Color32(255, 0, 0, 100);
        RawImage raya6 = GameObject.Find("raya6").GetComponent<RawImage>();
        raya6.color = new Color32(255, 0, 0, 100);
        Image IRPanel = GameObject.Find(panel+"panel").GetComponent<Image>();
        IRPanel.color = new Color32(255, 0, 0, 100);
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = new Color32(255, 0, 0, 100);
        Image DecorerPanel = GameObject.Find("DecorerPanel").GetComponent<Image>();
        DecorerPanel.color = Color.white;

        Text registro = GameObject.Find(panel).GetComponent<Text>();
        registro.text = valor;
    }

    public IEnumerator reset(string panel)
    {
        yield return new WaitForSeconds(1f);


        RawImage raya5 = GameObject.Find("raya5").GetComponent<RawImage>();
        raya5.color = new Color32(255, 0, 0, 100);
        RawImage raya6 = GameObject.Find("raya6").GetComponent<RawImage>();
        raya6.color = new Color32(255, 0, 0, 100);
        Image IRPanel = GameObject.Find(panel + "panel").GetComponent<Image>();
        Text registro = GameObject.Find(panel).GetComponent<Text>();
        IRPanel.color = Color.white;
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = new Color32(255, 0, 0, 100);

    }
}
