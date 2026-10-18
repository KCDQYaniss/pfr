namespace System.IO;

public struct WaitForChangedResult
{
	internal static readonly WaitForChangedResult TimedOutResult; //Field offset: 0x0
	[CompilerGenerated]
	private WatcherChangeTypes <ChangeType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <OldName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <TimedOut>k__BackingField; //Field offset: 0x18

	public WatcherChangeTypes ChangeType
	{
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string OldName
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool TimedOut
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static WaitForChangedResult() { }

	internal WaitForChangedResult(WatcherChangeTypes changeType, string name, string oldName, bool timedOut) { }

	[CompilerGenerated]
	public void set_ChangeType(WatcherChangeTypes value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_OldName(string value) { }

	[CompilerGenerated]
	public void set_TimedOut(bool value) { }

}

