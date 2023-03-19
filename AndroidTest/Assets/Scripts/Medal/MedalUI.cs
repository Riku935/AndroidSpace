using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalUI : MonoBehaviour
{
    public GameObject red;
    public GameObject orange;
    public GameObject yellow;
    public GameObject blue;
    public GameObject green;
    public GameObject purple;
    public GameObject brown;
    public GameObject gray;
    public GameObject pink;
    public GameObject beige;

    public GameObject medalPanel;

    public void Red() 
    {
        medalPanel.SetActive(false);
        red.SetActive(true);
    }
    public void CloseRed() 
    {
        red.SetActive(false);
        medalPanel.SetActive(true);
    }

    public void Orange() 
    {
        medalPanel.SetActive(false);
        orange.SetActive(true);
    }
    public void CloseOrange() 
    {
        orange.SetActive(false);
        medalPanel.SetActive(true);
    }

    public void Yellow() 
    {
        medalPanel.SetActive(false);
        yellow.SetActive(true);
    }
    public void CloseYellow() 
    {
        yellow.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Blue() 
    {
        medalPanel.SetActive(false);
        blue.SetActive(true);
    }
    public void CloseBlue() 
    {
        blue.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Green() 
    {
        medalPanel.SetActive(false);
        green.SetActive(true);
    }
    public void CloseGreen() 
    {
        green.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Purple() 
    {
        medalPanel.SetActive(false);
        purple.SetActive(true);
    }
    public void ClosePurple() 
    {
        purple.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Brown() 
    {
        medalPanel.SetActive(false);
        brown.SetActive(true);
    }
    public void CloseBrown() 
    {
        brown.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Gray() 
    {
        medalPanel.SetActive(false);
        gray.SetActive(true);
    }
    public void CloseGray() 
    {
        gray.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Pink() 
    {
        medalPanel.SetActive(false);
        pink.SetActive(true);
    }
    public void ClosePink() 
    {
        pink.SetActive(false);
        medalPanel.SetActive(true);
    }
    public void Beige() 
    {
        medalPanel.SetActive(false);
        beige.SetActive(true);
    }
    public void CloseBeige() 
    {
        beige.SetActive(false);
        medalPanel.SetActive(true);
    }



}
