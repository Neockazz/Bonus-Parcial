using UnityEngine;
using System.Collections;

public class CarroceriaTren{

	public void CrearCarroceria(){

		GameObject cube1  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube1.transform.position = new Vector3(-0.4981257f, 2.008713f,1.035208f);
		cube1.transform.Rotate(0f,0f,198.6419f);
		cube1.transform.localScale= new Vector3(1f,0.1989722f,1f);
		
		GameObject cube2  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube2.transform.position = new Vector3(-0.03784224f,0.6048528f,-0.2761179f);
		cube2.transform.Rotate(0f,0f,0f);
		cube2.transform.localScale= new Vector3(1f,0.2499997f,3.621517f);
		
		GameObject cube3  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube3.transform.position = new Vector3(0.3664985f,1.978444f,1.041988f);
		cube3.transform.Rotate(0f,0f,337.1367f);
		cube3.transform.localScale= new Vector3(1f,0.1989722f,1f);
		
		GameObject cube4  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube4.transform.position = new Vector3(-0.03784224f,1.38077f,1.042941f);
		cube4.transform.Rotate(0f,0f,0f);
		cube4.transform.localScale= new Vector3(1f,1.325f,1f);

		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3(0.6408671f,0.6129094f,-1.700665f);
		cylinder.transform.Rotate(0f,268.0404f,90f);
		cylinder.transform.localScale= new Vector3(0.3081249f,0.3871416f,0.3803391f);
		
		GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder2.transform.position = new Vector3(-0.3514875f,0.5706336f,-2.256441f);
		cylinder2.transform.Rotate(270f,0f,0f);
		cylinder2.transform.localScale= new Vector3(0.2625001f,0.1750434f,0.1705308f);
		
		GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder3.transform.position = new Vector3(0.3045149f,0.5776867f,-2.256514f);
		cylinder3.transform.Rotate(270f,0f,0f);
		cylinder3.transform.localScale= new Vector3(0.2789063f,0.1750434f,0.1705308f);
		
		GameObject cylinder4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder4.transform.position = new Vector3(-0.35257958f,0.5826768f,-2.459877f);
		cylinder4.transform.Rotate(359.6285f,87.37486f,273.155f);
		cylinder4.transform.localScale= new Vector3(0.3148609f,0.05018808f,0.3241195f);
		
		GameObject cylinder5 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder5.transform.position = new Vector3(-0.7365525f,0.6129093f,-1.691296f);
		cylinder5.transform.Rotate(0f,268.04045f,90f);
		cylinder5.transform.localScale= new Vector3(0.3081249f,0.3871416f,0.3803391f);
		
		GameObject cylinder6 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder6.transform.position = new Vector3(-0.02122211f,1.771601f,-1.657897f);
		cylinder6.transform.Rotate(0f,0f,0f);
		cylinder6.transform.localScale= new Vector3(0.65f,0.3964061f,0.4401784f);

		GameObject cylinder7 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder7.transform.position = new Vector3(-0.0378418f,1.209629f,-0.7697408f);
		cylinder7.transform.Rotate(90f,0f,0f);
		cylinder7.transform.localScale= new Vector3(1f,1.319123f,1f);
		
		GameObject cylinder8 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder8.transform.position = new Vector3(0.3187878f,0.5877135f,-2.441507f);
		cylinder8.transform.Rotate(359.8313f,83.70782f,271.6658f);
		cylinder8.transform.localScale= new Vector3(0.3148609f,0.05018808f,0.3241195f);
		
		GameObject cylinder9 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder9.transform.position = new Vector3(-0.02122211f,1.503916f,-0.07350969f);
		cylinder9.transform.Rotate(0f,0f,0f);
		cylinder9.transform.localScale= new Vector3(0.6125f,0.4703124f,0.4374299f);
		
		GameObject cylinder10 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder10.transform.position = new Vector3(-0.02122211f,1.574095f,-0.8333055f);
		cylinder10.transform.Rotate(0f,0f,0f);
		cylinder10.transform.localScale= new Vector3(0.6374999f,0.3964061f,0.4353605f);


		}
}
