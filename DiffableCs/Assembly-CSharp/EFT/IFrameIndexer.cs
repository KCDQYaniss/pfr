namespace EFT;

public interface IFrameIndexer
{

	public ulong LocalIndex
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LocalTime
	{
		 get { } //Length: 0
	}

	public ulong get_LocalIndex() { }

	public float get_LocalTime() { }

	public void set_LocalIndex(ulong value) { }

}

