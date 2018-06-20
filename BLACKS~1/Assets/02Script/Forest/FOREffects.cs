using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOREffects : MonoBehaviour {

    public GameObject gEffect;
    public GameObject[] gEffects;
    public bool bIsButtonClick = false;
    private int iCh;

    void Awake () {
        gEffects = new GameObject[10];
    }

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            gEffects[i] = Instantiate(gEffect);
            gEffects[i].transform.SetParent(this.transform);
        }
        iCh = 0;
    }
	
	// Update is called once per frame
	void Update () {

        bIsButtonClick = FORGameData.bIsButtonClick;

        if (FORGameData.bIsButtonClick)
        {
            bIsButtonClick = false;
            gEffects[iCh].transform.position = new Vector2(Random.Range(-0.5f, 0.6f), Random.Range(-0.5f, 0.6f));
            gEffects[iCh].SetActive(true);
            if (iCh == 9)
                iCh = 0;
            else
                iCh++;
        }
	}
}
