namespace EFT;

public sealed class TutorialHintData
{
	private Nullable _showKey; //Field offset: 0x10
	private Nullable _closeKey; //Field offset: 0x18
	public string Key; //Field offset: 0x20
	public int Activations; //Field offset: 0x28
	public bool OnlyInTrigger; //Field offset: 0x2C
	public bool IsImportant; //Field offset: 0x2D
	public bool IgnoreQueue; //Field offset: 0x2E
	public float Lifetime; //Field offset: 0x30
	public List Lines; //Field offset: 0x38

	public int CloseKey
	{
		 get { } //Length: 266
	}

	public int ShowKey
	{
		 get { } //Length: 227
	}

	public TutorialHintData(TutorialHintLine[] lisnes) { }

	public bool CheckKey(int key, out bool isShowKey) { }

	public int get_CloseKey() { }

	public int get_ShowKey() { }

}

