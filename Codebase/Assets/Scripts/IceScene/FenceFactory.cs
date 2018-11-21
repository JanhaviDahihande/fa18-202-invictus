﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceFactory : IObstacleFactory 
{
	public IObstacle createObstacle(GameObject fence,float x, float y, float z)
	{
		// Fence fenceobj = new Fence();
		// fenceobj.obj = MonoBehaviour.Instantiate(fence,new Vector3(x,y,z),Quaternion.Euler(0, 90, 0)) as GameObject;
		
		GameObject o =  MonoBehaviour.Instantiate(fence,new Vector3(x,y,z),Quaternion.Euler(0, 90, 0)) as GameObject;	
		Fence fenceScript = o.AddComponent<Fence>();

		return (IObstacle)fenceScript;
	}
}
