using UnityEngine;
using System.Collections;

public class PrincipalTren : MonoBehaviour {


	void Start () {

		LlantasTren llantas = new LlantasTren ();
		llantas.CrearLLantasTren ();
		Ventanas ventanas = new Ventanas ();
		ventanas.CrearVentanas ();
		CarroceriaTren carroceria = new CarroceriaTren ();
		carroceria.CrearCarroceria ();

	
	}
	
	void Update () {
	
	}
}
