using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplay : MonoBehaviour {

    [SerializeField] GameObject panel;
	// Use this for initialization
	void Start () {
        
	}

    public void hidepanel()
    {
        panel.SetActive(false);
    }
}
