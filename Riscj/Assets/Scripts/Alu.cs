using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alu : MonoBehaviour {

    private IEnumerator rutina,rutina2;
    public Text x,signo,y,acumulador;
    Contador contador;

    public void activar(string operador)
    {
        contador = gameObject.GetComponent<Contador>();

        rutina = aplicarSigno(operador);
        StartCoroutine(rutina);
    }


    public IEnumerator aplicarSigno(string operador)
    {
        yield return new WaitForSeconds(1f);
        signo.text = operador.ToLower();

        RawImage raya4 = GameObject.Find("raya4").GetComponent<RawImage>();
        raya4.color = new Color32(8, 30, 255, 255);
        RawImage raya5 = GameObject.Find("raya5").GetComponent<RawImage>();
        raya5.color = new Color32(255, 0, 0, 100);
        RawImage raya6 = GameObject.Find("raya6").GetComponent<RawImage>();
        raya6.color = new Color32(255, 0, 0, 100);
        RawImage raya7 = GameObject.Find("raya7").GetComponent<RawImage>();
        raya7.color = new Color32(255, 0, 0, 100);
        Image DecorerPanel = GameObject.Find("DecorerPanel").GetComponent<Image>();
        DecorerPanel.color = Color.white;
        Image ALUPanel = GameObject.Find("ALUPanel").GetComponent<Image>();
        ALUPanel.color = new Color32(255, 0, 0, 100);
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = new Color32(255, 0, 0, 100);

    }

    public void ejecuta()
    {
        rutina2 = aplicarOperacion();
        StartCoroutine(rutina2);
    }

    public IEnumerator aplicarOperacion()
    {
        yield return new WaitForSeconds(1f);
        int val1 = 0, val2 = 0;
        bool flag = false;

        if (!string.IsNullOrEmpty(x.text) && !string.IsNullOrEmpty(y.text))
        {
            string num = x.text;
            val1 = Convert.ToInt32(num);
            num = y.text;
            val2 = Int32.Parse(num);
        }
        switch (signo.text.ToLower())
        {
            case "=":
                acumulador.text = x.text;
                flag = true;
                break;
            case "-":
                acumulador.text = (val1 - val2).ToString() ;
                break;
            case "+":
                acumulador.text = (val1 + val2).ToString();
                flag = true;
                break;
            case "":
                acumulador.text = (val1 + val2).ToString();
                break;
        }
        Image MUXPanel = GameObject.Find("MUXPanel").GetComponent<Image>();
        MUXPanel.color = Color.white;
        RawImage raya10 = GameObject.Find("raya10").GetComponent<RawImage>();
        raya10.color = new Color32(8, 30, 255, 255);
        Image DecorerPanel = GameObject.Find("ACCPanel").GetComponent<Image>();
        DecorerPanel.color = new Color32(255, 0, 0, 100);
        RawImage raya11 = GameObject.Find("raya11").GetComponent<RawImage>();
        raya11  .color = new Color32(255, 0, 0, 100);
        Image ALUPanel = GameObject.Find("ALUPanel").GetComponent<Image>();
        ALUPanel.color = Color.white;
        if (flag)
        {
            contador.aumenta();
        }
    }
}
