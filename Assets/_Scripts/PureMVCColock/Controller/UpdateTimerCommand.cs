using PureMVC.Interfaces;
using PureMVC.Patterns;
using System;

public class UpdateTimerCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);

        //获取始终代理 
        ColockProxy colockProxy = Facade.RetrieveProxy(ColockProxy.NAME) as ColockProxy;
        //更新数据
        colockProxy.SetCurrentTimer(DateTime.Now.ToString("T"));
    }
}
