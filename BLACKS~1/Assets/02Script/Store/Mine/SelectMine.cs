using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectMine : MonoBehaviour
{
    public int MineKind;

    void Start()
    {
        MineKind = 0;
    }
    /*Back Store*/
    public void BackStorebutton()
    {
        SceneManager.LoadScene("Store");
    }
    /*Select Mine*/
    public void FirstMine()
    {
        MineKind = 1;
        NextMine();
    }
    public void SecondMine()
    {
        MineKind = 2;
        NextMine();
    }
    public void ThirdMine()
    {
        MineKind = 3;
        NextMine();
    }
    /*Next Scene*/
    private void NextMine()
    {
        SceneManager.LoadScene("Mine");
    }


}
