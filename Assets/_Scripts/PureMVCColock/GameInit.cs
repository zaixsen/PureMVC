using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    private void Start()
    {
        ColockFacade colockFacade = ColockFacade.GetInstance();
        colockFacade.Luncher();
    }
}
