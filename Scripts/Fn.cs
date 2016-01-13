using UnityEngine;
using UnityEngine.VR;
using System.Collections;
using System;

public class Fn {

	// Use this for initialization
	//void Start () {
	
	//}
	private Camera camera;

	public Fn(Camera camera){
		this.camera = camera;
	}
	public Fn(){
	}

	public void TestingObjects(System.Type type, System.Object obj){

	}

	public Vector3 getLocalRotation(){
		return camera.transform.localRotation.eulerAngles;
	}

	public Vector3 getGlobalRotation(){
		return camera.transform.rotation.eulerAngles;
	}

	public Vector3 getDirectLocalRotation(){
		return InputTracking.GetLocalRotation (VRNode.Head).eulerAngles;
	}

	public Vector3 getLocalPosition(){
		return camera.transform.localPosition;
	}

	public Vector3 getGlobalPosition(){
		return camera.transform.position;
	}

	public Vector3 getDirectLocalPosition(){
		return InputTracking.GetLocalPosition (VRNode.Head);
	}

}
