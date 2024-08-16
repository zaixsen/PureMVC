using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections.Generic;
using UnityEngine;

public class ColockViewMediator : Mediator
{
    public new const string NAME = "ColockViewMediator";
    public ColockView View;
    public ColockProxy colockProxy;
    
    public ColockViewMediator(object viewComponent) : base(NAME, viewComponent)
    {
        View = ((GameObject)viewComponent).GetComponent<ColockView>();

        colockProxy = Facade.RetrieveProxy(ColockProxy.NAME) as ColockProxy;

        View.colockButton.onClick.AddListener(RefreshTimer);
    }

    /// <summary>
    /// 处理事件
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        base.HandleNotification(notification);
        switch (notification.Name)
        {
            case ColockFacade.SHOW_TIMER:
                View.colockText.text = notification.Body.ToString();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 注册事件
    /// </summary>
    /// <returns></returns>
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>() { ColockFacade.SHOW_TIMER };

        return list;
    }

    private void RefreshTimer()
    {
        SendNotification(ColockFacade.UPDATE_TIMER);
    }
}
