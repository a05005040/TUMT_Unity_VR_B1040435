using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject a, b;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ThrowPickUp()
    {
        print("撿起物件");
        Destroy(a);
        b.SetActive(true);

    }
    public void ThrowDetach()
    {
        print("放開物件");
    }
    public void ThrowHeld()
    {
        print("拿著物件");
    }
}
