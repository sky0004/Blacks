using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FORBar : MonoBehaviour {

    public GameObject gBar;
    public GameObject[] gBars = new GameObject[5];
    public GameObject gCamera;

    void Start () {
        for(int i = 0; i < 5; i++)
        {
            GameObject temp = Instantiate(gBar);
            gBars[i] = temp;
            temp.transform.SetParent(this.transform);
        }
	}
	
	void Update () {
        if (FORGameData.iTouchCount % 4 == 0 && FORGameData.iTouchCount != 0 && FORGameData.iTouchCount <= 20)
        {
            GameObject temp = gBars[FORGameData.iTouchCount / 4 - 1];
            temp.SetActive(true);
            if (temp.transform.position.x < 10)
            {
                temp.transform.position = new Vector3(0.5f * FORGameData.iTouchCount / 4 + 0.75f - 2.3f, 2.05f, 9) + gCamera.transform.position;
                Debug.Log(FORGameData.iTouchCount / 4 - 1);
                if (FORGameData.iTouchCount / 4 - 1 == 4)
                {
                    gBars[4].GetComponent<SpriteRenderer>().flipX = true;
                    gBars[4].transform.position += new Vector3(-0.5f, 0, 0);
                }
            }
        }
    }
}
