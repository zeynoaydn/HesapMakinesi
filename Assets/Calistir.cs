using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calistir : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    List<float> islem = new List<float>();
    List<string> islemType = new List<string>();
    float toplam = 0.0f;
    void Start()
    {


    }
    void Update()
    {
    }
    public void ClickNumbers(int temp)
    {
        //proUGUI.text=temp.ToString();

        if (textMesh.text == "0")
        {
            textMesh.text = $"{temp}";
        }
        else
        {
            textMesh.text += $"{temp}";
        }
    }
    public void Plus()
    {
        islem.Add(float.Parse(textMesh.text));
        toplam = float.Parse(textMesh.text);

        textMesh.text = "+";
        islemType.Add("+");
        textMesh.text = "";
    }
    public void Minus()
    {
        islem.Add(float.Parse(textMesh.text));
        toplam = float.Parse(textMesh.text);

        textMesh.text = "-";
        islemType.Add("-");
        textMesh.text = "";
    }
    public void Multi()
    {
        islem.Add(float.Parse(textMesh.text));
        toplam = float.Parse(textMesh.text);

        textMesh.text = "*";
        islemType.Add("*");
        textMesh.text = "";
    }
    public void Divide()
    {
        islem.Add(float.Parse(textMesh.text));
        toplam = float.Parse(textMesh.text);

        textMesh.text = "/";
        islemType.Add("/");
        textMesh.text = "";
    }
    public void Percent()
    {
        float percentValue = float.Parse(textMesh.text) / 100f;
        textMesh.text = percentValue.ToString();
    }
    public void Negatif()
    {
        if (textMesh.text != "0")
        {
            float currentValue = float.Parse(textMesh.text);
            float newValue = -currentValue;
            textMesh.text = newValue.ToString();
        }
    }
    public void Equal()
    {
        islem.Add(float.Parse(textMesh.text));

        switch (islemType[0])
        {
            case "+":
                toplam = 0; 
                for (int i = 0; i < islem.Count; i++)
                {
                    toplam += islem[i];
                }
                break;

            case "-":
                toplam = islem[0]; 
                for (int i = 1; i < islem.Count; i++)
                {
                    toplam -= islem[i];
                }
                break;
            case "*": 
                toplam = 1;
                for (int i = 0; i < islem.Count; i++)
                {
                    toplam *= islem[i];
                }
                break;
            case "/": 
                toplam = islem[0]; // Ýlk elemaný al
                for (int i = 1; i < islem.Count; i++)
                {
                    if (islem[i] != 0) 
                    {
                        toplam /= islem[i];
                    }
                    else
                    {
                        textMesh.text = "Hata";
                        islemType.Clear();
                        islem.Clear();
                        return;
                    }
                }
                break;
        }

        textMesh.text = Convert.ToString(toplam);
        islemType.Clear();
        islem.Clear();       
    }
    public void Clear()
    {
        textMesh.text = "0";
        islemType.Clear();  
        islem.Clear();
    }
}
