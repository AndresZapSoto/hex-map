using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMapGenerator : MonoBehaviour {

	public GameObject[] hexArray;

	public int hexRepeatX;
	public int hexRepeatY;
	public float hexDistanceX = 5.02f;
	public float hexDistanceY = 1.446f;
	public float plusX = 2.51f;

	// Use this for initialization
	void Start () {
		HexMapCreator ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GOarray()
	{
		for (int i=0; i<hexArray.Length; i++)
		{
			Debug.Log(hexArray[i].name);
		}
	}


	void HexMapCreator()
	{
		for (int x = 0; x < hexRepeatX; x++) {
			for (int y = 0; y < hexRepeatY; y++) {
				int i = Random.Range (0, 20);
				Debug.Log (i);
				if (i >= 0 && i <= 4) {
					if((y % 2) == 0){
						Instantiate (hexArray [0], new Vector3 (x * hexDistanceX, y * hexDistanceY, 0), Quaternion.identity);
					}
					else{
						Instantiate (hexArray[0], new Vector3 (((x * hexDistanceX) + plusX), y * hexDistanceY, 0), Quaternion.identity);
					}
				}

				if(i > 4 && i <= 10){
					if ((y % 2) == 0) {
						Instantiate (hexArray [1], new Vector3 (x * hexDistanceX, y * hexDistanceY, 0), Quaternion.identity);
					}
					else{
						Instantiate (hexArray[1], new Vector3(((x * hexDistanceX) + plusX), y * hexDistanceY, 0), Quaternion.identity);
					}
				}
					
				if(i > 10 && i <= 12){
					if ((y % 2) == 0) {
						Instantiate (hexArray [4], new Vector3 (x * hexDistanceX, y * hexDistanceY, 0), Quaternion.identity);
					}
					else{
						Instantiate (hexArray[4], new Vector3(((x * hexDistanceX) + plusX), y * hexDistanceY, 0), Quaternion.identity);
					}
				}

				if(i > 12 && i <= 14){
					if ((y % 2) == 0) {
						Instantiate (hexArray [3], new Vector3 (x * hexDistanceX, y * hexDistanceY, 0), Quaternion.identity);
					}
					else{
						Instantiate (hexArray[3], new Vector3(((x * hexDistanceX) + plusX), y * hexDistanceY, 0), Quaternion.identity);
					}
				}

				if(i > 14 && i <= 20){
					if ((y % 2) == 0) {
						Instantiate (hexArray [2], new Vector3 (x * hexDistanceX, y * hexDistanceY, 0), Quaternion.identity);
					}
					else{
						Instantiate (hexArray[2], new Vector3(((x * hexDistanceX) + plusX), y * hexDistanceY, 0), Quaternion.identity);
					}
				}
			}
		}
	}
		
}
