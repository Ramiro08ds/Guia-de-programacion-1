using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimales : MonoBehaviour
{
    public string CodigoAnimal;
    public int CantidadDias;
    int cantidadComidaTotal;
    int racionGatos = 300;
    int racionPerrosChicos = 400;
    int racionPerrosGrandes = 700;
    int racionAnimalActual;
    float costoAlimento;
    float precioPorcienG = 80;
    // Start is called before the first frame update
    void Start()
    {
        if (CantidadDias < 3) {
            Debug.Log("cantidad de dias no valida");
        }
        else
        {
            if (CodigoAnimal == "G" || CodigoAnimal == "g")
            {
                racionAnimalActual = racionGatos;
            }
            else if (CodigoAnimal == "PP" || CodigoAnimal == "pp")
            {
                racionAnimalActual = racionPerrosChicos;
            }
            else if (CodigoAnimal == "PG" || CodigoAnimal == "pg")
            {
                racionAnimalActual = racionPerrosGrandes;

            }
            else
            {
                Debug.Log("tipo de animal mal ingresado, por favor intente otra vez, igrese PG para perro grande, PP para perro pequeño y G para un gato");
                return;
            }
            cantidadComidaTotal = racionAnimalActual * CantidadDias;

            Debug.Log("para ese periodo se necesitan: " + cantidadComidaTotal + " gramos de alimento");
            costoAlimento = cantidadComidaTotal / 100 * precioPorcienG;
            Debug.Log(" el precio es de: " + costoAlimento + " pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
