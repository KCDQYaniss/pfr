namespace Comfort.Common;

public interface IUnityScheduller
{

	public event Action Event
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Event(Action value) { }

	[CompilerGenerated]
	public void remove_Event(Action value) { }

	public Coroutine StartCoroutine(IEnumerator enumerator) { }

}

