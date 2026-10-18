//Type is in global namespace

[Extension]
public static class ObservedPlayerFrameExtension
{

	[Extension]
	public static ObservedPlayerFrame ReadObservedPlayerFrame(byte[] buffer, ref int offset) { }

	[Extension]
	public static int Write(byte[] buffer, ObservedPlayerFrame playerFrame, int offset = 0) { }

}

