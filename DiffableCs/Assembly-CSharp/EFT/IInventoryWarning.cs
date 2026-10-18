namespace EFT;

public interface IInventoryWarning
{

	public int ErrorCode
	{
		 get { } //Length: 0
	}

	public int get_ErrorCode() { }

	public bool TryGetMessage(out string header, out string description) { }

}

