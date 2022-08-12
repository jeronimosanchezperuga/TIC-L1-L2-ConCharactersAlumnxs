using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{

	[SerializeField] GameObject[] objectCollection;
	[SerializeField] int randomNumber;
	[SerializeField] Transform spawnPoint;

	// Start is called before the first frame update
	void Start()
	{
		objectCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
		AgregarColliderAElementosDelArray();


	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			PosicionarElementosDelArray();
			GenerarNumeroAlAzar();
			IntanciarObjetosAlAzar();
		}
		if (Input.GetKeyDown(KeyCode.I))
		{
			IntanciarObjetosAlAzar();
		}
	}

	void DestruirElementosDelArray()
	{
		for (int i = 0; i < objectCollection.Length; i++)
		{
			Destroy(objectCollection[i]);
		}
	}

	void PosicionarElementosDelArray()
	{
		for (int i = 0; i < objectCollection.Length; i++)
		{
			objectCollection[i].transform.position = new Vector3(1.21f, 0.5f + i, 0.95f);
		}
	}

	void AgregarColliderAElementosDelArray()
	{
		for (int i = 0; i < objectCollection.Length; i++)
		{
			objectCollection[i].AddComponent<BoxCollider>();
		}
	}

	void GenerarNumeroAlAzar()
	{
		randomNumber = Random.Range(1, 11);
	} 

	void IntanciarObjetosAlAzar()
	{
		Instantiate(objectCollection[Random.Range(0, objectCollection.Length)], spawnPoint.position,Quaternion.identity);
	}
}
