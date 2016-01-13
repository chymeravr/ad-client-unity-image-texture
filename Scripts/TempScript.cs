using UnityEngine;
using System.Collections;
using System;

public class TempScript : MonoBehaviour {
	long lastTime;
	// Use this for initialization
	void Start () {
		lastTime = DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond;
		TestClass testClass = new TestClass ();
		Fn fn = new Fn ();
		fn.TestingObjects (testClass.GetType(), testClass);
	}

	// Update is called once per frame
	void Update () {
		/*Quaternion c = Camera.main.transform.rotation;
		Quaternion r = transform.rotation;
		Quaternion x = r * Quaternion.Inverse (c);
		Quaternion xnew = new Quaternion ();
		xnew.w = 0.5f;
		xnew.x = 0.5f;
		xnew.y = -0.5f;
		xnew.z = 0.5f;
		Camera.main.transform.rotation = xnew * Camera.main.transform.rotation;
		print ("prints");
		print (c);
		print (r);
		print (x);
		print (Camera.main.transform.rotation);
		*/
		/*Vector3 cameraLookat = Camera.main.transform.forward.normalized;
		Vector3 objectLookAt = (transform.position - Camera.main.transform.position).normalized;
		float cos = Vector3.Dot (cameraLookat, objectLookAt);
		float theta = Mathf.Acos (cos)*180f/Mathf.PI;
		print ("theta");
		print (theta);*/

		/*long newTime = DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond;
		print (newTime);
		print ((newTime-lastTime));
		lastTime = newTime;*/
	}
}
