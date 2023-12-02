using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFruitManager : MonoBehaviour
{
    public GameObject fruitPrefab;
    
    public void CutFruit()
    {
        GameObject instance = (GameObject) Instantiate(fruitPrefab,transform.position, transform.rotation);
        
        Rigidbody[] rigidBodies = instance.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rigidBodies)
        {
            rb.transform.rotation = Random.rotation;
            rb.AddExplosionForce(Random.Range(500, 1000),transform.position,5f);
        }
        Destroy(instance.gameObject,5);
        Destroy(gameObject);
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var e = collision.GetComponent<SwordManager>();
        if (e != null)
        {
            CutFruit();
            FindObjectOfType<GameManager>().IncreaseScore();
        } else return;
    
    }
}
