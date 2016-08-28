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
		var js = new JavaScriptSerializer (new SimpleTypeResolver());
		var client = new WebClient();
		client.Headers.Add("Content-Type","application/json");
		string json = js.Serialize (testplan);
		byte[] data = Encoding.ASCII.GetBytes(json);
		byte[] responseArray = client.UploadData ("http://localhost:8080/plans",data);
		var response = Encoding.ASCII.GetString (responseArray);
		Debug.Log ("\nResponse received was: " + response);

		var dict = js.Deserialize<Dictionary<string,int>> (response);
		response = client.DownloadString ("http://localhost:8080/plans/" + dict ["id"]);
		Debug.Log (response);
		Warplan wp = js.Deserialize<Warplan>(response);
		Debug.Log (wp.blueprints [1].armor.GetType ());
	}
}
