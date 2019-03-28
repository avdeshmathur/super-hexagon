using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

    public float shrinkpeed = 3f;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale -= Vector3.one * shrinkpeed * Time.deltaTime;
        if (transform.localScale.x <= 0.5)
        {
            Destroy(gameObject);
        }
	}
}
