namespace EFT.UI.Matchmaker;

public sealed class RaidPlayer : GroupPlayer, IUpdatable
{
	public readonly BindableEvent InfoChanged; //Field offset: 0x40
	public readonly BindableEvent VisualChanged; //Field offset: 0x48
	public readonly BindableEvent StatusChanged; //Field offset: 0x50

	public bool HasAccessToCoop
	{
		 get { } //Length: 143
	}

	public RaidPlayer(GroupPlayer player) { }

	public RaidPlayer Clone() { }

	public override bool Compare(RaidPlayer other) { }

	public bool get_HasAccessToCoop() { }

	public override void UpdateFromAnotherItem(RaidPlayer other) { }

	public void UpdateFromAnotherItem(GroupPlayer other) { }

	public void UpdateReadyStatus(bool ready, bool removeVisual = true) { }

	private void UpdateVisualRepresentation(PlayerVisualRepresentation playerVisualRepresentation) { }

}

