using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class StartGameCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);

        //创建主界面
        GameObject colockPanel = GameObjectUtility.Instance.CreateGameObject("_Prefabs/ColockPanelView");

        colockPanel.SetActive(true);
        //绑定中介者
        ColockViewMediator colockViewMediator = new ColockViewMediator(colockPanel);
        Facade.RegisterMediator(colockViewMediator);
    }
}

