using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;

public class UITests : MonoBehaviour
{
    [SetUp]
    public void init()
    {
        SceneManager.LoadScene("Stage");
    }

    [UnityTest]
    public IEnumerator testClickLeaderBoardBtn()
    {
        var btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        var btnLeaderBoard = btnLeaderBoardGameObject.GetComponent<Button>();
        btnLeaderBoard.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var titleTodayTheme = GameObject.Find("Ttile");
        Assert.IsNotNull(titleTodayTheme, "Missing `Leader Board` title from `LeaderBoard` scene");
    }

        [UnityTest]
    public IEnumerator testClickBackBtn()
    {
        var btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        var btnLeaderBoard = btnLeaderBoardGameObject.GetComponent<Button>();
        btnLeaderBoard.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var titleTodayTheme = GameObject.Find("Ttile");
        Assert.IsNotNull(titleTodayTheme, "Missing `Leader Board` title from `LeaderBoard` scene");

        var btnBackGameObject = GameObject.Find("BackStage");
        var btnBack = btnBackGameObject.GetComponent<Button>();
        btnBack.onClick.Invoke();

        yield return new WaitForSeconds(3f);

        btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        Assert.IsNotNull(btnLeaderBoardGameObject);
    }


    [UnityTest]
    public IEnumerator testSubmitGameScore()
    {
        // click start
        var btnStartGameObject = GameObject.Find("coverButton");
        var btnStart = btnStartGameObject.GetComponent<Button>();
        btnStart.onClick.Invoke();

        // Wait for game over
        yield return new WaitForSeconds(50);

        var txtNameGObj = GameObject.Find("name");
        var txtName = txtNameGObj.GetComponent<Text>();
        txtName.text = "testpayer";

        var btnSumitGameObject = GameObject.Find("Submit");
        var btnSumit = btnSumitGameObject.GetComponent<Button>();
        btnSumit.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var tapToStartGameObject = GameObject.Find("ShootingGame Tap To Start");
        Assert.IsNotNull(tapToStartGameObject);
    }

    [TearDown]
    public void TearDown()
    {

    }
}
