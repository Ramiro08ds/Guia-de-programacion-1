using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAconvertir;
    public string CodigoMoneda;
    float cotizacionDolar = 1350.4f;
    float cotizacionReal = 200.8f;
    float cotizacionEuro = 1600.6f;
    float montoConvertido;
    float montoMinimo = 1000;
    float cotizacionMonedaElegida;
    // Start is called before the first frame update
    void Start()
    {
       //ingreso y validacion de datos
       if(montoAconvertir < montoMinimo) {
            Debug.Log("el monto minimo es $1000");
            return;
        }
        if (CodigoMoneda == "D" || CodigoMoneda == "d") {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (CodigoMoneda == "E" || CodigoMoneda == "e") {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (CodigoMoneda == "R"|| CodigoMoneda == "r") {
            cotizacionMonedaElegida = cotizacionEuro; ;
        }
        else
        {
            Debug.Log("opcion de moneda extranjera no valida");
            return;
        }

        //procesamiendo datos
        montoConvertido = montoAconvertir * cotizacionMonedaElegida;

        //salida de datos
        Debug.Log("el monto ingresado equivale a: " + montoConvertido);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
