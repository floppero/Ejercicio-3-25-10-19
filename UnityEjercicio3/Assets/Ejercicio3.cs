using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour {
	public int numeroUno = 10;
	public int numeroDos = 20;
	public int numeroTres;
	public float numeroCuatro;
	public float numeroCinco = 5.5f;



	// Use this for initialization
	void Start () {
		Debug.Log("La suma de " + numeroUno + " mas " + numeroTres + " mas " + numeroCuatro + " es igual a = " + (numeroUno + numeroTres + numeroCuatro));
		Debug.Log("La resta de " + numeroUno + " menos " + numeroDos + " menos " + numeroCinco + " es igual a = " + (numeroUno - numeroDos - numeroCinco));
		Debug.Log("La operacion de " + numeroUno + " mas " + numeroDos + " por " + numeroCinco + " es igual a = " + ((numeroUno + numeroDos) * numeroCinco));
		Debug.Log("La operacion de " + numeroUno + " menos " + numeroTres + " dividido entre " + numeroCinco + " mas " + numeroCuatro + " es igual a = " + ((numeroUno - numeroTres) / (numeroCinco + numeroCuatro)));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
