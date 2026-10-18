namespace EFT.UI;

public class FavoriteQuestManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string questId; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <IsFavorite>b__0(Quest x) { }

	}

	[CompilerGenerated]
	private Action OnFavoriteQuestAddedOrRemoved; //Field offset: 0x10
	private readonly HashSet _favoriteQuests; //Field offset: 0x18
	private readonly QuestController _questController; //Field offset: 0x20

	public event Action OnFavoriteQuestAddedOrRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public FavoriteQuestManager(QuestController questController) { }

	[CompilerGenerated]
	public void add_OnFavoriteQuestAddedOrRemoved(Action value) { }

	public bool IsFavorite(string questId) { }

	[CompilerGenerated]
	public void remove_OnFavoriteQuestAddedOrRemoved(Action value) { }

	public void ToggleFavorite(string questId) { }

}

