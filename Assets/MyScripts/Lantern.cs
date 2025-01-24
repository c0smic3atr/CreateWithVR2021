using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{

    public Light lightSource;

    public void TurnOnLight()
    {
        lightSource.enabled = true;
    }

    public void TurnOffLight()
    {
        lightSource.enabled = false;
    }
}
