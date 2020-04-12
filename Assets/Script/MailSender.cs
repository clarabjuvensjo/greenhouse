using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class MailSender : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        button.GetComponent<Button>().onClick.AddListener(SendEmail);
    }

    public void SendEmail()
    {
        string email = "MY EMAIL ADDRESS";
        string subject = MyEscapeURL("My Subject");
        string body = MyEscapeURL("My Body\r\nFull of non-escaped chars");

        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string URL)
    {
        return WWW.EscapeURL(URL).Replace("+", "%20");
    }
}

