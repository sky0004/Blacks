using UnityEngine;
using UnityEngine.SceneManagement;

public class FORButManager : MonoBehaviour {

    public GameObject gCamera;
    public GameObject gMapButton;
    public GameObject gInGameButton;
    public GameObject gPlayer;

    public void Foreste_01()
    {
        gCamera.transform.position += new Vector3(10, 0, 0);
        gCamera.transform.Find("inGameOBJ").gameObject.SetActive(true);
        gMapButton.gameObject.SetActive(false);
        gInGameButton.gameObject.SetActive(true);
        FORGameData.iNowForestNum = 1;
    }

    public void Foreste_02()
    {
        gCamera.transform.position += new Vector3(20, 0, 0);
        gCamera.transform.Find("inGameOBJ").gameObject.SetActive(true);
        gMapButton.gameObject.SetActive(false);
        gInGameButton.gameObject.SetActive(true);
        FORGameData.iNowForestNum = 2;
    }

    public void Foreste_03()
    {
        gCamera.transform.position += new Vector3(30, 0, 0);
        gCamera.transform.Find("inGameOBJ").gameObject.SetActive(true);
        gMapButton.gameObject.SetActive(false);
        gInGameButton.gameObject.SetActive(true);
        FORGameData.iNowForestNum = 3;
    }

    public void Touch()
    {
        FORGameData.bIsButtonClick = true;
        FORGameData.iTouchCount++;
        gPlayer.GetComponent<Animator>().Play("hitWood");
    }

    public void StoreButton()
    {
        SceneManager.LoadScene("Store");
    }
}