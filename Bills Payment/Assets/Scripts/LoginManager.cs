using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HomeButton()
    {

        SceneManager.LoadScene(SceneConstants.BillPayCategory);
    }

    public void BillPayButton()
    {

        SceneManager.LoadScene(SceneConstants.BpServiceProvider);
    }

    public void BpServiceButton()
    {

        SceneManager.LoadScene(SceneConstants.BpConfirmation);
    }

    public void BpConfirmationButton()
    {

        SceneManager.LoadScene(SceneConstants.BpServiceProvider);
    }

    public void BackButton()
    {

        string SceneName = SceneManager.GetActiveScene().name;
        BackButtonManager.SwitchScene(SceneName);
    }

}

/* public class GlobalControl : MonoBehaviour
{

    public static GlobalControl Instance:

        private void Awake()
    {
        
        if(Instance == null)
        {

            //DontDestroyOnLoad(SceneConstants.BpServiceProvider.)
        }
    }
}   */