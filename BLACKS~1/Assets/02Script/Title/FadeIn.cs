using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FadeIn : MonoBehaviour
{

    public GameObject Effect;

    public void Touching()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        /*while (Effect.transform.localScale.x <= 1.0f)
        {
            Effect.transform.localScale += new Vector3(0.1f, 0.1f);

            yield return new WaitForSeconds(0.01f);
        }*/
        SceneManager.LoadScene("Store");
        yield return null;
    }
}
