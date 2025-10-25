using UnityEngine;

public class BaseAbility : MonoBehaviour
{
    protected Player player;
    protected ListenPlayerInput linkedPlayerInput;
    protected StateMachine linkedStateMachine;

    public PlayerStates.States thisAbilityState;
    public bool isPermitted = true;

    protected virtual void Start()
    {
        Initialization();
    }

    public virtual void EnterAbility()
    {

    }

    public virtual void ExitAbility()
    {

    }

    public virtual void ProcessAbility()
    {

    }

    public virtual void ProcessFixedAbility()
    {

    }
    
    
    protected void Initialization()
    {
        player = GetComponent<Player>();

        if (player != null)
        {
            linkedPlayerInput = player.listenPlayerInput;
            linkedStateMachine = player.stateMachine;
        }
    }

}


