namespace EFT.Quests;

[DefaultMember("Item")]
public sealed class AchievementsGlobalProgressStorage : IReadOnlyDictionary, IEnumerable, IEnumerable, IReadOnlyCollection
{
	private static readonly Lazy _instance; //Field offset: 0x0
	public Dictionary Data; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 68
	}

	public static AchievementsGlobalProgressStorage Instance
	{
		 get { } //Length: 121
	}

	public override float Item
	{
		 get { } //Length: 103
	}

	public override IEnumerable Keys
	{
		 get { } //Length: 73
	}

	public override IEnumerable Values
	{
		 get { } //Length: 73
	}

	private static AchievementsGlobalProgressStorage() { }

	public AchievementsGlobalProgressStorage() { }

	public override bool ContainsKey(MongoID key) { }

	public override int get_Count() { }

	public static AchievementsGlobalProgressStorage get_Instance() { }

	public override float get_Item(MongoID key) { }

	public override IEnumerable get_Keys() { }

	public override IEnumerable get_Values() { }

	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(MongoID key, out float value) { }

}

