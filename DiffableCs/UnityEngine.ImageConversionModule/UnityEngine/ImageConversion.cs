namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[Extension]
	public static bool LoadImage(Texture2D tex, byte[] data) { }

}

