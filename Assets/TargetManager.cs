using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TargetManager : MonoBehaviour {


	public GameObject targetManager;



	private float ScreenDPI;
	private Vector2 ScreenSize; 
	private Vector2 BottomLeftCorner;
	private Vector2 UpperRightCorner;
	// Use this for initialization

	public List<GameObject> targets;
	public List<GameObject> bushes;






	void Start ()
	{



		BottomLeftCorner = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
		UpperRightCorner = Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, Screen.height));

		Debug.Log(UpperRightCorner);

		int a = 0;
		for(int h=1;h<=3;++h)
		{
			for(int w=1;w<=2;++w)
			{
				Debug.Log(Random.insideUnitSphere);


				float RandomX=0.5f+(float)Random.insideUnitSphere.x*(UpperRightCorner.x-0.5f);
				float RandomY=0.5f+(float)Random.insideUnitSphere.y*(UpperRightCorner.y-0.5f);
				targets[a].transform.Translate(new Vector2(RandomX,RandomY));
				bushes[a].transform.Translate(new Vector2(0.5f+(float)Random.insideUnitSphere.x*(UpperRightCorner.x-0.5f),0.5f+(float)Random.insideUnitSphere.y*(UpperRightCorner.y-0.5f)));
				a++;
			}
		}
	
			}


			
	
	// Update is called once per frame
	void Update ()
	{

	
	}
}
