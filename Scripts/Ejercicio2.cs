using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    
    // Actividad 2.1
    float ConvertirAProbabilidad (float valor)
    {
        if (valor < 0.0f || valor > 1.0f)
            return 0.0f;

        return valor * 100.0f;
    }


    // Actividad 2.2

    float ConvertirADecimal(float porcentaje)
    {
        if ((porcentaje < 0.0f || porcentaje > 100.0f)
            return 0.0f;     

        return porcentaje / 100.0f; 
    }


    // Actividad 2.3




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
