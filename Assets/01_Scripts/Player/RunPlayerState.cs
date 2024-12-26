using UnityEngine;

public class RunPlayerState : IState
{
    private Player _player;
    private PlayerState _playerState;

    public RunPlayerState(Player player, PlayerState playerState)
    {
        _player = player;
        _playerState = playerState;
    }

    public void EnterState()
    {
        Debug.Log("EnterState RunState");
        _player._animator.SetBool("Run",true);
    }

    public void ExitState()
    {
        Debug.Log("ExitState RunState");
        _player._animator.SetBool("Run", false);
    }

    public void UpdateState()
    {
        Debug.Log("UpdateState RunState");

       

        //if ()
        { 
        
        }

    }
}
