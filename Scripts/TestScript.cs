using UnityEngine;
using UnityEngine.VR;
using System.Collections;

public class TestScript : MonoBehaviour {
	int count = 0;
	private Fn fn;
	// Use this for initialization
	void Start () {
		fn = new Fn (Camera.main);
	}
	
	// Update is called once per frame
	void Update () {
		//print (InputTracking.GetLocalPosition (VRNode.CenterEye));
		//print (InputTracking.GetLocalRotation (VRNode.CenterEye).eulerAngles);
		if (count == 100) {
			count = 0;

			print ("loc");
			//print (Camera.main.transform.localPosition);
			//print (Camera.main.transform.position);
			//print (InputTracking.GetLocalPosition(VRNode.Head));
			print (fn.getLocalPosition());
			print (fn.getGlobalPosition());
			print (fn.getDirectLocalPosition());

			print ("rot");
			//print (Camera.main.transform.localRotation.eulerAngles);
			//print (Camera.main.transform.eulerAngles);
			//print (InputTracking.GetLocalRotation(VRNode.Head).eulerAngles);
			print (fn.getLocalRotation());
			print (fn.getGlobalRotation());
			print (fn.getDirectLocalRotation());
		} else
			count++;
	}
}
