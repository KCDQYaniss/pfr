namespace EFT;

public struct InteractionInfo
{
	public int PlayerId; //Field offset: 0x0
	public WorldInteractiveObject WorldInteractiveObject; //Field offset: 0x8
	public InteractionResult Result; //Field offset: 0x10
	public Action Callback; //Field offset: 0x18

}

