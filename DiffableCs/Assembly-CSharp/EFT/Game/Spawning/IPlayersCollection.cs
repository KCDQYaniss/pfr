namespace EFT.Game.Spawning;

public interface IPlayersCollection : IEnumerable, IEnumerable
{

	public event Action OnPersonAdd
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPersonAdd(Action value) { }

	[CompilerGenerated]
	public void remove_OnPersonAdd(Action value) { }

}

