namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionStatistic : ConditionOneTarget
{
	private Identifier _counter; //Field offset: 0xE8
	private Nullable _counterTag; //Field offset: 0xF0
	public bool byTag; //Field offset: 0xF8

	[JsonIgnore]
	public Identifier Counter
	{
		 get { } //Length: 415
	}

	[JsonIgnore]
	public CounterTag CounterTag
	{
		 get { } //Length: 643
	}

	public ConditionStatistic() { }

	public Identifier get_Counter() { }

	public CounterTag get_CounterTag() { }

}

