using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CurvedUI;

public class UserCanvas : MonoBehaviour {

    CurvedUISettings UI;
	// Use this for initialization
	void Start () {
        UI.ControlMethod = CurvedUIInputModule.CUIControlMethod.OCULUSVR;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
