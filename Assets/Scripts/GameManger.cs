using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private string[] NombresDeAlumnos = new string[10];

    [SerializeField] private List<string> NombresDeAlumnos2 = new List<string>();
    void Start()
    {
        NombresDeAlumnos[0] = "Jualian";
        NombresDeAlumnos[9] = "Jualiano";

        NombresDeAlumnos = new string[20];


        NombresDeAlumnos2.Add("asdasd");
        NombresDeAlumnos2.Add("asdasd");
        NombresDeAlumnos2.Add("asdasd");
        NombresDeAlumnos2.Add("asdasd");
        NombresDeAlumnos2.Add("asdasd");
        NombresDeAlumnos2[0] = "aasdasd";

        NombresDeAlumnos2.Clear();  
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
