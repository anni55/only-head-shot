using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour 
{
	public GameObject enemy;
	float randX;
	Vector3 whereToSpawn;
	public float spawnRate;
	float nextSpawn = 0.0f;

	void Start()
	{
		
	}

	void Update () 
	{
		if(Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-20f, 20f);
			whereToSpawn = new Vector3 (randX, transform.position.y, transform.position.z);
			Instantiate (enemy, whereToSpawn, Quaternion.identity);
		}
	}
	
	
	public void AdjustSpeed(float newspeed)
	{
		spawnRate = newspeed;
	}
}
