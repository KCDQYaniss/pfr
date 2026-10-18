namespace EFT.GameTriggers;

public interface ITriggerEntity
{

	public GameObject GameObject
	{
		 get { } //Length: 0
	}

	public IEnumerable InputTriggerIds
	{
		 get { } //Length: 0
	}

	public bool IsClientAuthority
	{
		 get { } //Length: 0
	}

	public IEnumerable OutputTriggerIds
	{
		 get { } //Length: 0
	}

	public GameObject get_GameObject() { }

	public IEnumerable get_InputTriggerIds() { }

	public bool get_IsClientAuthority() { }

	public IEnumerable get_OutputTriggerIds() { }

	public bool TryRenameId(string oldId, string newId) { }

}

