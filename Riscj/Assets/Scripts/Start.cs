using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Start : MonoBehaviour {

    public InputField text;
    public Text t0, t1, t2,signo,x,y,acumuladorn;
    public Text[] registros;

    void Update()
    {
                Time.timeScale = 0.7F;
        }

        public void starExecurition()
    {
        Time.timeScale = 0.0000000002F;
        string commando = text.text;
        string[] componentes = commando.Split(' ');
        string[] regis = componentes[1].Split(',');
        desglosar(componentes[0], regis);
        new WaitForSeconds(3);
        Contador.inicia();
    }

    public void desglosar(string instruccion,string[] regis)
    {
        Image panelRam = GameObject.Find("ramPanel").GetComponent<Image>();
        panelRam.color = new Color32(255,0,0,100);
        if (instruccion.ToLower().StartsWith("add"))
        {
            for(int i = 0; i < 3; i++)
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
    }


    private void validateCommand(string command){
        string variables = command.Substring(4);
        string[] separadas;
        separadas = variables.Split(',');
        int a = 0, b = 0, c = 0;
        for(int i = 0; i <separadas.Length;i++)
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
        if (command.ToLower().StartsWith("add")){
            signo.text = "+";
           //  acumulador.text = (a + b).ToString();
        }else if (command.ToLower().StartsWith("sub"))
        {
            signo.text = "-";
         //   acumulador.text = (a - b).ToString();
        }

        switch (separadas[2])
        {

        }
    }
}
