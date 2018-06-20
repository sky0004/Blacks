using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOREffect : MonoBehaviour {

    public Animation ani;
	
	// Update is called once per frame
	void Update () {
        if (!ani.IsPlaying("forest_Effect"))
            this.gameObject.SetActive(false);
    }
}
