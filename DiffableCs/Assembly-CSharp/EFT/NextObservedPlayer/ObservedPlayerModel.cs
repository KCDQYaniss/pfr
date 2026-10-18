namespace EFT.NextObservedPlayer;

public struct ObservedPlayerModel
{
	public float WorldTime; //Field offset: 0x0
	public bool IsNeedProcessMovement; //Field offset: 0x4
	public ObservedPlayerMovementModel Movement; //Field offset: 0x8
	public ObservedPlayerAnimatorModel PlayerAnimatorModel; //Field offset: 0xA4
	public int CommandsCount; //Field offset: 0xB0
	public ICommandMessage[] Commands; //Field offset: 0xB8

}

