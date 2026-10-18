namespace EFT.GameTriggers;

public interface ITriggerSource
{

	public bool IsClientAuthority
	{
		 get { } //Length: 0
	}

	public bool get_IsClientAuthority() { }

	public IEnumerable GetTriggers() { }

	public bool TryRename(string oldTriggerId, string newTriggerId) { }

}

