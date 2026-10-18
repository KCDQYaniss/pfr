namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object
{
	private static class EncodingUtility
	{
		internal static readonly KeyValuePair[] encodingLookup; //Field offset: 0x0
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		private static EncodingUtility() { }

	}


	public byte[] bytes
	{
		 get { } //Length: 78
	}

	public string text
	{
		 get { } //Length: 162
	}

	internal static string DecodeString(byte[] bytes) { }

	public byte[] get_bytes() { }

	public string get_text() { }

	public virtual string ToString() { }

}

