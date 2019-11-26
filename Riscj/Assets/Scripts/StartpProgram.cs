using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartpProgram : MonoBehaviour
{

    public InputField text;
    public Text t0, t1, t2, signo, x, y, acumuladorn;
    public Text[] registros;
    private IEnumerator coroutine;
    Contador contador;

    void Start()
    {
        contador = gameObject.GetComponent<Contador>();
    }

    public void starExecurition()
    {
        string commando = text.text;
        string[] componentes = commando.Split(' ');
        string[] regis = componentes[1].Split(',');
        if (validaRegis(regis))
        {
            coroutine = cargaRam(componentes[0], regis);
            StartCoroutine(coroutine);
        }
    }

    public IEnumerator cargaRam(string instruccion, string[] regis)
    {
        yield return new WaitForSeconds(1f);
        Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        panelRam.color = new Color32(255, 0, 0, 100);
        if (instruccion.ToLower().StartsWith("add"))
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        registros[2].text = "STORE " + regis[i];
                        break;
                    case 1:
                        registros[0].text = "LOAD " + regis[i];
                        break;
                    case 2:
                        registros[1].text = "ADD " + regis[i];
                        break;
                }
            }
        }
        else if (instruccion.ToLower().StartsWith("sub"))
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        registros[2].text = "STORE " + regis[i];
                        break;
                    case 1:
                        registros[0].text = "LOAD " + regis[i];
                        break;
                    case 2:
                        registros[1].text = "SUB " + regis[i];
                        break;
                }
            }
        }
        contador.inicia();
    }


    private Boolean validaRegis(string[] registros)
    {
        foreach (string reg in registros)
        {
            if (!(reg.ToLower().Contains("t0") || reg.ToLower().Contains("t1") || reg.ToLower().Contains("t2")))
            {
                this.text.text = "Se escribio algo mal";
                return false;
            }
        }
        return true;
    }

    private void validateCommand(string command)
    {
        string variables = command.Substring(4);
        string[] separadas;
        separadas = variables.Split(',');
        int a = 0, b = 0, c = 0;
        for (int i = 0; i < separadas.Length; i++)
        {
            int val = 0;
            switch (separadas[i].ToLower())
            {
                case "t0":
                    val = Int32.Parse(t0.text);
                    break;
                case "t1":
                    val = Int32.Parse(t1.text);
                    break;
                case "t2":
                    val = Int32.Parse(t2.text);
                    break;
                default:
                    this.text.text = "Se escribio algo mal";
                    break;

            }
            switch (i)
            {
                case 0:
                    a = val;
                    break;
                case 1:
                    b = val;
                    break;
                case 2:
                    c = val;
                    break;
            }
        }
        x.text = a.ToString();
        y.text = b.ToString();
        if (command.ToLower().StartsWith("add"))
        {
            signo.text = "+";
            //  acumulador.text = (a + b).ToString();
        }
        else if (command.ToLower().StartsWith("sub"))
        {
            signo.text = "-";
            //   acumulador.text = (a - b).ToString();
        }

        switch (separadas[2])
        {

        }
    }
}
