using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {
    	// Use this for initialization
	void Start () {
       Vector3 lookAwayTarget = Camera.main.transform.position - transform.position;
       transform.LookAt(transform.position + -(lookAwayTarget));
    }