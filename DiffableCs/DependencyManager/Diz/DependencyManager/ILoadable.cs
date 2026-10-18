namespace Diz.DependencyManager;

public interface ILoadable
{

	public IEnumerable DependencyKeys
	{
		 get { } //Length: 0
	}

	public string Key
	{
		 get { } //Length: 0
	}

	public BindableState LoadState
	{
		 get { } //Length: 0
	}

	public float Progress
	{
		 get { } //Length: 0
	}

	public IEnumerable get_DependencyKeys() { }

	public string get_Key() { }

	public BindableState get_LoadState() { }

	public float get_Progress() { }

	public void Load() { }

	public void Unload() { }

}

