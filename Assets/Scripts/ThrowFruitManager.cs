using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ThrowFruitManager : MonoBehaviour
{
    public GameObject[] fruitPrefab;
    public Transform[] throwPlaces;

    public float minElapseTime = 0.3f;
    public float maxElapseTime = 1f;

    public int minForce = 10;
    public int maxForce = 15;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Throw());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Throw()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minElapseTime,maxElapseTime));

    
               Transform t = throwPlaces[Random.Range(0, throwPlaces.Length)];
            GameObject fruit = Instantiate(fruitPrefab[Random.Range(0,fruitPrefab.Length)], t.position, t.rotation);
            fruit.GetComponent<Rigidbody2D>().AddForce(t.transform.up * Random.Range(minForce,maxForce), ForceMode2D.Impulse);
            Destroy(fruit, 5);


        }
    }

    
}
