﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEST : MonoBehaviour {
	public ArrayList itemsInNest;
	public int nestId;
	private int count;

	// Use this for initialization
	void Start ()
	{
		itemsInNest = new ArrayList();
		Vector4 color = this.transform.FindChild("Beacon").GetComponent<MeshRenderer>().material.color;
		this.transform.FindChild("Beacon").GetComponent<MeshRenderer>().material.color = new Vector4(color.x, color.y, color.z, 0.25f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public bool isInNest(GameObject obj)
	{
		if(itemsInNest.Contains(obj))
		{
			return true;
		}
		return false;
	}

	public void addObject(GameObject obj)
	{
		itemsInNest.Add(obj);
		count += obj.GetComponent<Pickups> ().pointVal;
	}

	public void removeFromNest(GameObject obj)
	{
		itemsInNest.Remove(obj);
		count -= obj.GetComponent<Pickups> ().pointVal;
	}

	public int GetScore()
	{
		return count;
	}
}
