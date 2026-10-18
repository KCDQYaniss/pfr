namespace EFT.InventoryLogic;

public class ItemEventArgs : EventArgs
{
	private const double DEFAULT_TIMEOUT = 25; //Field offset: 0x0
	private static int _staticEventsIdCounter; //Field offset: 0x0
	public readonly Item Item; //Field offset: 0x10
	[CanBeNull]
	public readonly ItemAddress Location; //Field offset: 0x18
	public readonly CommandStatus Status; //Field offset: 0x20
	public readonly int EventId; //Field offset: 0x24
	public readonly string OwnerId; //Field offset: 0x28
	private double _creationTimes; //Field offset: 0x30
	protected double _timeoutForOutdate; //Field offset: 0x38

	protected ItemEventArgs(Item item, CommandStatus status, IItemOwner itemOwner, ItemAddress location = null) { }

	public bool IsOutdated() { }

	public void SetCreationTime() { }

	protected override void SetTimeoutForOutdate() { }

}

