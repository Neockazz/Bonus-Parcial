using UnityEngine;
using System.Collections;

public class LlantasTren{

	public void CrearLLantasTren(){

		
		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3(0.5256788f,0.6230345f,-0.8897912f);
		cylinder.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);
		
		GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder2.transform.position = new Vector3(0.5164415f,0.6146755f,0.0885019f);
		cylinder2.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder2.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);
		
		GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder3.transform.position = new Vector3(0.5070613f,0.57714f,079788f);
		cylinder3.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder3.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);
		
		GameObject cylinder4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder4.transform.position = new Vector3(-0.6075308f,0.5762644f,1.077517f);
		cylinder4.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder4.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);

		GameObject cylinder5 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder5.transform.position = new Vector3(-0.5981333f,0.6074383f,0.08392415f);
		cylinder5.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder5.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);
		
		GameObject cylinder6 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder6.transform.position = new Vector3(-0.5888344f,0.6238123f,-0.900308f);
		cylinder6.transform.Rotate(-85.7695f,-7.629395e-05f,-90.54205f);
		cylinder6.transform.localScale= new Vector3(0.8192979f,0.06475279f,0.7843509f);

	}
	
}
