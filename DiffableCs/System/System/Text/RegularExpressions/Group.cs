namespace System.Text.RegularExpressions;

public class Group : Capture
{
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	internal readonly int[] _caps; //Field offset: 0x20
	internal int _capcount; //Field offset: 0x28
	internal CaptureCollection _capcoll; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x38

	public CaptureCollection Captures
	{
		 get { } //Length: 264
	}

	public bool Success
	{
		 get { } //Length: 8
	}

	private static Group() { }

	internal Group(string text, int[] caps, int capcount, string name) { }

	internal Group() { }

	public CaptureCollection get_Captures() { }

	public bool get_Success() { }

}

