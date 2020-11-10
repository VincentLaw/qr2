using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoginController : MonoBehaviour
{


    public InputField userName;
    public InputField password;
    public GameObject errorText;
    public GameObject mainPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void login() {
        Debug.Log(userName.text);
       // Debug.Log(password.);
        if (userName.text.Equals("usuario1") && password.text.Equals("password1"))
        {
            Store.userLogged = "commonUser";
            mainPanel.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (userName.text.Equals("empresa1") && password.text.Equals("password2"))
        {
            Store.userLogged = "enterprise";
            mainPanel.SetActive(true);
            gameObject.SetActive(false);
        }
        else {
            errorText.SetActive(true);
        }
    }
}
