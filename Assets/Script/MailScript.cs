using System.Collections;
using UnityEngine;

public class MailScript : MonoBehaviour
{
    public void changeScene(int scene)
    {
        Application.LoadLevel(scene);
    }
}