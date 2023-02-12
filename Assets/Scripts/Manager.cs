using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject oso, carro, subebaja, teenager, tortuga, osodark, carrodark, subebajadark, teenagerdark, tortugadark;

    Vector2 osoInitialPos, carroInitialPos, subebajaInitialPos, teenagerInitialPos, tortugaInitialPos;

    void Start()
    {
        osoInitialPos = oso.transform.position;
        carroInitialPos = carro.transform.position;
        subebajaInitialPos = subebaja.transform.position;
        teenagerInitialPos = teenager.transform.position;
        tortugaInitialPos = tortuga.transform.position;
    }

    public void Dragoso()
    {
        oso.transform.position = Input.mousePosition;
    }

    public void Dragcarro()
    {
        carro.transform.position = Input.mousePosition;
    }

    public void Dragsubebaja()
    {
        subebaja.transform.position = Input.mousePosition;
    }

    public void Dragteenager()
    {
        teenager.transform.position = Input.mousePosition;
    }

    public void Dragtortuga()
    {
        tortuga.transform.position = Input.mousePosition;
    }

    public void Droposo()
    {
        float Distance = Vector3.Distance(oso.transform.position, osodark.transform.position);
        if(Distance<50)
        {
            oso.transform.position = osodark.transform.position;
        }
        else
        {
            oso.transform.position = osoInitialPos;
        }
    }

    public void Dropcarro()
    {
        float Distance = Vector3.Distance(carro.transform.position, carrodark.transform.position);
        if (Distance < 50)
        {
            carro.transform.position = carrodark.transform.position;
        }
        else
        {
            carro.transform.position = carroInitialPos;
        }
    }

    public void Dropsubebaja()
    {
        float Distance = Vector3.Distance(subebaja.transform.position, subebajadark.transform.position);
        if (Distance < 50)
        {
            subebaja.transform.position = subebajadark.transform.position;
        }
        else
        {
            subebaja.transform.position = subebajaInitialPos;
        }
    }

    public void Dropteenager()
    {
        float Distance = Vector3.Distance(teenager.transform.position, teenagerdark.transform.position);
        if (Distance < 50)
        {
            teenager.transform.position = teenagerdark.transform.position;
        }
        else
        {
            teenager.transform.position = teenagerInitialPos;
        }
    }

    public void Droptortuga()
    {
        float Distance = Vector3.Distance(tortuga.transform.position, tortugadark.transform.position);
        if (Distance < 50)
        {
            tortuga.transform.position = tortugadark.transform.position;
        }
        else
        {
            tortuga.transform.position = tortugaInitialPos;
        }
    }
}
