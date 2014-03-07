using UnityEngine;
using System.Collections;

public class Ventanas{

	public void CrearVentanas(){

		GameObject sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere1.transform.position = new Vector3(-0.4669209f,1.468104f,1.042795f);
		sphere1.transform.Rotate(0f,0f,0f);
		sphere1.transform.localScale= new Vector3(0.4394066f,0.4353871f,0.4015188f);

		GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere2.transform.position = new Vector3(0.4001961f,1.468104f,1.042795f);
		sphere2.transform.Rotate(0f,0f,0f);
		sphere2.transform.localScale= new Vector3(0.4186202f,0.4256032f,0.39685f);


		}
}
