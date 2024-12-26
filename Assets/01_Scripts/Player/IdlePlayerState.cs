using UnityEngine;

public class IdlePlayerState : IState
{
    private Player _player;
    private PlayerState _playerState;
    public IdlePlayerState(Player player, PlayerState playerState)
    {
        _player = player;
        _playerState = playerState;
    }

    public void EnterState()
    {
        Debug.Log("EnterState IdlePlayerState");

    }

    public void ExitState()
    {
        Debug.Log("ExitState IdlePlayerState");
    }

    public void UpdateState()
    {
        Debug.Log("UpdateState IdlePlayerState");

        if (_player.isRun)
        {
            _playerState.Transition(_player.runState);
        }
    }
}
