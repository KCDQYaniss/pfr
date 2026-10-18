namespace Diz.Resources;

public interface IBundleLock
{

	public bool IsLocked
	{
		 get { } //Length: 0
	}

	public bool get_IsLocked() { }

	public void Lock() { }

	public void Unlock() { }

}

