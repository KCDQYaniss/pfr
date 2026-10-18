namespace EFT.InventoryLogic.Operations;

internal sealed class PlayerToggleOperation : ToggleOperation
{
	private readonly IPlayer _player; //Field offset: 0x88
	private readonly InventoryController _playerInventoryController; //Field offset: 0x90

	internal PlayerToggleOperation(ushort id, InventoryController controller, ToggleResult toggleResult, IPlayer player) { }

	public virtual void Dispose() { }

}

