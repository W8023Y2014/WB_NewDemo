using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour {

    public Transform Model;

    Vector3 modelStartPos;
    Quaternion modelStartQua;

    // Use this for initialization
    void Start () {
        modelStartPos = Model.position;
        modelStartQua = Model.rotation;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetModel()
    {
        Model.position = modelStartPos;
        Model.rotation = modelStartQua;
    }
}
