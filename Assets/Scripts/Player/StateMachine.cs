public class StateMachine
{
    public PlayerStates.States previousState;
    public PlayerStates.States currentState;
    public BaseAbility[] arrayOfAbilities;

    public void ChangeState(PlayerStates.States newState)
    {
        foreach (BaseAbility ability in arrayOfAbilities)
        {
            if (ability.thisAbilityState == currentState)
            {
                ability.ExitAbility();
                previousState = currentState;
            }
        }

        foreach (BaseAbility ability in arrayOfAbilities)
        {
            if (ability.thisAbilityState == newState)
            {
                if (ability.isPermitted)
                {
                    currentState = newState;
                    ability.EnterAbility();
                }
                break;
            }
        }
    }

    public void ForceChangeState(PlayerStates.States newState)
    {
        previousState = currentState;
        currentState = newState;
    }
}
