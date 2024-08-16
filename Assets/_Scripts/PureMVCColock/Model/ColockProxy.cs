using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColockProxy : Proxy
{
    public static new string NAME = "ColockProxy";

    private string currentTimer;

    public ColockProxy() : base(NAME)
    {

    }

    public void SetCurrentTimer(string timer)
    {
        //数据验证
        currentTimer = timer;
        SendNotification(ColockFacade.SHOW_TIMER, currentTimer);
    }

}
