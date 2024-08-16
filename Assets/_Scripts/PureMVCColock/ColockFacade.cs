using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColockFacade : Facade
{
    public const string START_GAME = "start_game";
    public const string UPDATE_TIMER = "update_timer";
    public const string SHOW_TIMER = "show_timer";

    static ColockFacade()
    {
        m_instance = new ColockFacade();
    }

    public static ColockFacade GetInstance()
    {
        return m_instance as ColockFacade;
    }

    public void Luncher()
    {
        SendNotification(ColockFacade.START_GAME);
    }

    protected override void InitializeModel()
    {
        base.InitializeModel();
        RegisterProxy(new ColockProxy());
    }


    protected override void InitializeController()
    {
        base.InitializeController();
        //注册Command
        RegisterCommand(START_GAME, typeof(StartGameCommand));
        RegisterCommand(SHOW_TIMER, typeof(ColockCommand));
        RegisterCommand(UPDATE_TIMER, typeof(UpdateTimerCommand));
    }
}
