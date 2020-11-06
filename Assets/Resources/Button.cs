using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void amazon()
    {
        Application.OpenURL("https://amzn.to/3mX9OJV");
    }
    public void flipkart()
    {
        Application.OpenURL("https://www.flipkart.com/search?q=atta%20kneader&otracker=search&otracker1=search&marketplace=FLIPKART&as-show=on&as=off");
    }
    public void seniority()
    {
        Application.OpenURL("https://www.seniority.in/catalogsearch/result/?q=atta+kneader");
    }
    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCPxMZIFE856tbTfdkdjzTSQ");
    }
    public void twitter()
    {
        Application.OpenURL("https://twitter.com/BeerBicepsGuy");
    }
    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/beerbiceps/");
    }
}

