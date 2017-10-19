using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

public class Kill_Respan : MonoBehaviour {

	public Rigidbody2D gamePlayer;
	private bool freeseRotation;

	[SerializeField]Transform spawnPoint;

	IEnumerator OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.CompareTag ("Player"))
			gamePlayer.freezeRotation = false; 
			yield return new WaitForSeconds (2f);
			col.transform.position = spawnPoint.position;
			gamePlayer.transform.rotation = spawnPoint.rotation;
			gamePlayer.freezeRotation = true;
			
	}


}

