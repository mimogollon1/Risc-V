using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decoder : MonoBehaviour {

    Alu alu;
    Multiplexor multiplexor;

    private IEnumerator rutina;

    public Text identificador,acumulador,contador;
    private string sentencia, registro;

    public void decodificar()
    {
        alu = gameObject.GetComponent<Alu>();
        multiplexor = gameObject.GetComponent<Multiplexor>();
        sentencia = identificador.text.Split(' ')[0];
        registro = identificador.text.Split(' ')[1];
        rutina = decodifica(); 
        StartCoroutine(rutina);
    }

    public IEnumerator decodifica()
    {
        bool flag = true;
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
        switch (sentencia.ToLower())
        {
            case "load":
                sentencia = "=";
                break;
            case "sub":
                sentencia = "-";
                break;
            case "add":
                sentencia = "+";
                break;
            case "store":
                sentencia = "";
                alu.x.text = "";
                alu.y.text = "";
                alu.signo.text = "";
                contador.text = "0";
                multiplexor.guardaNumero(acumulador.text, registro);
                flag = false;
                break;
        }
        if (flag)
        {
            alu.activar(sentencia);
            multiplexor.carga(registro);
        }
    }
}
