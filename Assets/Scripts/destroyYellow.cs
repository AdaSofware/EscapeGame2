using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class destroyYellow : MonoBehaviour {

    public GameObject other;
    public AudioClip clip;
    public GameObject bonusS;


    public void Start()
    {

      //  Advertisement.Initialize("1096270", true);
    }


    public void OnMouseDown() {
        GameObject copLights = GameObject.Find("GameController");
        Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
        targetScript.yellow += 1;
        //timer -= Time.deltaTime;
        ScoreY();
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(clip, transform.position);

       // if (Advertisement.IsReady())
       // { // If the platform is supported,
         //   Advertisement.Show(); // initialize Unity Ads 
        //  //  StartCoroutine(WaitForAd());
        
     //   }


    }

    IEnumerator WaitForAd()
    {
        GameObject copLights = GameObject.Find("GameController");
        Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();

        float currentTimeScale = targetScript.timer;
        Time.timeScale = 0f;
        yield return null;

       // while (Advertisement.isShowing)
        //    yield return null;
      //  Time.timeScale = currentTimeScale;
   
    }
    public void ScoreY() {
        GameObject copLights = GameObject.Find("GameController");
        Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
        if (targetScript.destroyBox = true) {

            targetScript.score += 200;
            targetScript.guiTextScore.text = targetScript.score.ToString();
            targetScript.destroyBox = false;
            GameObject blast;
            blast = Instantiate(bonusS, gameObject.transform.position, bonusS.transform.rotation) as GameObject;
        }
    }
}

