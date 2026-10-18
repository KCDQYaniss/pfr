namespace EFT.UI.Matchmaker;

public sealed class MatchmakerUpdatableGroup
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	public readonly BindableState Owner; //Field offset: 0x18

	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string OwnerAccountId
	{
		 get { } //Length: 53
	}

	public MatchmakerUpdatableGroup(RaidPlayer owner) { }

	[CompilerGenerated]
	public string get_Id() { }

	public string get_OwnerAccountId() { }

	public void RemoveOwner() { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	public void UpdateOwner(RaidPlayer owner) { }

}

