using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public int boxNum;
    public float nowTime;

    // Use this for initialization
    void Start()
    {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if (boxNum <= 0)
        {
            GameOver(nowTime.ToString("F0") + "•b‚ÅƒNƒŠƒA‚Å‚«‚½I");  //<=====•b”‚ðstringŒ^‚ÉƒLƒƒƒXƒg‚µ‚Äˆø”‚Ö
        }
    }

    public void GameOver(string resultMessage)
    {   //<=====ˆø”‚ð‚à‚½‚¹‚½
        DataSender.resultMessage = resultMessage;  //<=====Žó‚¯Žæ‚Á‚½ˆø”‚ðstatic•Ï”‚ÖŠi”[
        SceneManager.LoadScene("Result");
    }
}