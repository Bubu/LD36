using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;

public class WebRequest : MonoBehaviour {

	public Warplan testplan;

	// Use this for initialization
	void Start () {
		testplan = new Warplan();	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void doRequest() {
		var client = new WebClient();
		client.Headers.Add("Content-Type","application/json");
		string json = new JavaScriptSerializer ().Serialize (testplan);
		byte[] data = Encoding.ASCII.GetBytes(json);
		byte[] responseArray = client.UploadData ("http://localhost:8080/plans",data);

		Debug.Log ("\nResponse received was: " + Encoding.ASCII.GetString(responseArray));
	}
}
