using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public float gameDuration;
    public GameObject timerGO;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delayedHelloWorld());
    }

    // Update is called once per frame
    void Update()
    {
        timerGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = gameDuration + "";
    }
    void FixedUpdate(){
        gameDuration -= Time.deltaTime;
    }

public void NextScene(){
    SceneManager.LoadScene(1);
}
    IEnumerator delayedHelloWorld(){
        yield return new WaitForSeconds(5f);
        Debug.Log("delayed message");
    }
}
