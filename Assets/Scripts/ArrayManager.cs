using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectsCollection;
    [SerializeField] int randomNumber;
    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PosicionarElementosDelArray();
            GenerarNroAlAzar();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstanciarObjetoAlAzarDelArray();
        }
    }

    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            Destroy(objectsCollection[i]);
        }
    }

    void PosicionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(2.8f + i, 0.7f, 9f);
        }
        
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }

    void GenerarNroAlAzar()
    {
        randomNumber = Random.Range(1,11);
    }

    void InstanciarObjetoAlAzarDelArray()
    {
        Instantiate(objectsCollection[Random.Range(0,objectsCollection.Length)],
            spawnPoint.position,Quaternion.identity);
    }
}
