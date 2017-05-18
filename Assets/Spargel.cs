using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spargel : MonoBehaviour {
    public int countTime = 0;
    public GameObject myGameObject;
    // Use this for initialization
    void Start () {
        int spargelDelayTime = Random.Range(10,20);

    }
	
	// Update is called once per frame
	void Update () {

        int delay = Time.deltaTime;
        if (timer > 10)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        Vector3 temp = new Vector3(0, 0.1f, 0);
        myGameObject.transform.position += temp;
    }
    void SpargelCounter()
    {
        for(int i = 0; i <= 10; i++)
        {
            this.countTime++;

        }

    }
}
