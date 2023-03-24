using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    public delegate void ammoDelegate();

    public static event ammoDelegate ableToAttack;
    public int ammo = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "ammo:" + ammo.ToString();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        Player.getAmmo += ammoListener;
        Player.schoot += enoughAmmo;

    }

    private void OnDisable()
    {
        Player.getAmmo -= ammoListener;
        Player.schoot -= enoughAmmo;
    }

    void ammoListener()
    {
        ammo += 4;
        gameObject.GetComponent<Text>().text = "ammo:" + ammo.ToString();
    }

    void enoughAmmo()
    {
        if (ammo > 0)
        {
            ammo--;
            AllowAttack();
            gameObject.GetComponent<Text>().text = "ammo:" + ammo.ToString();
        }
    }

    void AllowAttack()
    {
        if (ableToAttack != null)
        {
            ableToAttack();
        }
    }
}
