using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suggestion : MonoBehaviour
{
    public string UrlHere;

    public void toLink()
    {
        Application.OpenURL(UrlHere);
    }
}
