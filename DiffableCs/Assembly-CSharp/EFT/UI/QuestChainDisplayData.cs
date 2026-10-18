namespace EFT.UI;

[IsReadOnly]
public struct QuestChainDisplayData
{
	[CompilerGenerated]
	private readonly string <ChainId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IReadOnlyList <Quests>k__BackingField; //Field offset: 0x8

	public string ChainId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public IReadOnlyList Quests
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public QuestChainDisplayData(string chainId, IReadOnlyList quests) { }

	[CompilerGenerated]
	public string get_ChainId() { }

	[CompilerGenerated]
	public IReadOnlyList get_Quests() { }

}

