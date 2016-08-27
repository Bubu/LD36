using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;

public class WebRequest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void doRequest() {

		Dictionary<string, string> openWith = 
			new Dictionary<string, string>();
		openWith.Add("txt", "notepad.exe");
		openWith.Add("bmp", "paint.exe");
		openWith.Add("dib", "paint.exe");
		openWith.Add("rtf", "wordpad.exe");

		var client = new WebClient();


		client.Headers.Add("Content-Type","application/json");
		string json = new JavaScriptSerializer ().Serialize (openWith);
		byte[] data = Encoding.ASCII.GetBytes(json);
		byte[] responseArray = client.UploadData ("http://localhost:8080/plans",data);

		Debug.Log ("\nResponse received was: " + Encoding.ASCII.GetString(responseArray));
	}
}
