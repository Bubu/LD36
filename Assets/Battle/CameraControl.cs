using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	private Camera m_camera;
	private float size = 25f;

	// Use this for initialization
	void Start () {
		m_camera = GetComponent<Camera>();
		m_camera.orthographicSize = size;
		m_camera.transform.position = new Vector3 (size * m_camera.aspect, size, -10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
