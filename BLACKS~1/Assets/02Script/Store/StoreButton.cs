using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreButton : MonoBehaviour
{
    public GameObject MapPopup;
    public GameObject SellPopup;
    private int PopupKind;

    private void Start()
    {
        PopupKind = 0;
    }

    /*MapButton*/
    public void MapButton()
    {
        PopupKind = 1;
        StartCoroutine(Popup());
    }
    public void SelectForest()
    {
        SceneManager.LoadScene("Forest");
    }
    public void SelectMine()
    {
        SceneManager.LoadScene("MineMap");
    }
    public void CloseMap()
    {
        MapPopup.transform.localScale = new Vector3(0, 0);
    }

    /*Workplace*/
    public void WorkplaceButton()
    {
        SceneManager.LoadScene("Workplace");
    }

    /*SellButton*/
    public void SellButton()
    {
        PopupKind = 2;
        StartCoroutine(Popup());
    }
    public void CloseSell()
    {
        SellPopup.transform.localScale = new Vector3(0, 0);
    }

    /*MapSelectMove*/
    IEnumerator Popup()
    {
        if (PopupKind == 1)
        {
            while (MapPopup.transform.localScale.x <= 1.0f)
            {
                MapPopup.transform.localScale += new Vector3(0.1f, 0.1f);

                yield return new WaitForSeconds(0.01f);
            }
        }
        if (PopupKind == 2)
        {
            while (SellPopup.transform.localScale.x <= 1.0f)
            {
                SellPopup.transform.localScale += new Vector3(0.1f, 0.1f);

                yield return new WaitForSeconds(0.01f);
            }
        }

        PopupKind = 0;
    }
}
