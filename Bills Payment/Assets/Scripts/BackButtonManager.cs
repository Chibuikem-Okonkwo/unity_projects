using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonManager
{

    string SceneName = SceneManager.GetActiveScene().name;

    public static void SwitchScene(string SceneName) {

        if (SceneName == "BillPayCategory")
        {

            SceneManager.LoadScene(SceneConstants.Home);
        }

        if (SceneName == "BpServiceProvider")
        {

            SceneManager.LoadScene(SceneConstants.BillPayCategory);
        }
    }
}