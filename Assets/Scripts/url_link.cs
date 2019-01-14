using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url_link : MonoBehaviour {

    public string insta;
    public string facebook;
    public string twit;

    public void Instagram()
    {
        Application.OpenURL(insta);
    }

    public void Facebook()
    {
        Application.OpenURL(facebook);
    }

    public void Twitter()
    {
        Application.OpenURL(twit);
    }
}
