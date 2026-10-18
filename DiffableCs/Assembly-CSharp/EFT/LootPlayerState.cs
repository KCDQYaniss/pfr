namespace EFT;

internal class LootPlayerState : MovementState
{

	public LootPlayerState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Loot(bool enabled) { }

	public virtual void SetTilt(float tilt) { }

}

