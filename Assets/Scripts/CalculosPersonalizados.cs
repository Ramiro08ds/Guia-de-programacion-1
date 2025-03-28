using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour

{
    public float num1;
    public float num2;
     float resultadoSuma;
     float resultadoResta;
     float resultadoMultiplicacion;
     float resultadoDivision;

    // Start is called before the first frame update
    void Start()
    {
        resultadoDivision = num1 / num2;
        resultadoMultiplicacion = num1 * num2;
        resultadoResta = num1 - num2;
        resultadoSuma = num1 + num2;
        Debug.Log("el resultado de la suma entre" + num1 + " y " + num2 + " es " + resultadoSuma);
        Debug.Log("el resultado de la resta entre" + num1 + " y " + num2 + " es " + resultadoResta);
        Debug.Log("el resultado de la multiplicacion entre" + num1 + " y " + num2 + " es " + resultadoMultiplicacion);
        Debug.Log("el resultado de la division entre" + num1 + " y " + num2 + " es " + resultadoDivision);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
