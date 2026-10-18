//Type is in global namespace

public class ShallBeGroupParams
{
	public bool Group; //Field offset: 0x10
	public int RemainCount; //Field offset: 0x14
	[CompilerGenerated]
	private int <StartCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsBossSetted>k__BackingField; //Field offset: 0x1C

	public bool IsBossSetted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int StartCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ShallBeGroupParams(bool group, bool bossGroup, int groupCount = 4) { }

	public void DescreaseCount() { }

	[CompilerGenerated]
	public bool get_IsBossSetted() { }

	[CompilerGenerated]
	public int get_StartCount() { }

	[CompilerGenerated]
	public void set_IsBossSetted(bool value) { }

	[CompilerGenerated]
	private void set_StartCount(int value) { }

}

