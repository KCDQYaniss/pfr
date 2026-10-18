namespace UnityEngine;

[NativeType("Runtime/Graphics/DisplayInfo.h")]
[UsedByNativeCode]
public struct DisplayInfo : IEquatable
{
	internal ulong handle; //Field offset: 0x0
	public int width; //Field offset: 0x8
	public int height; //Field offset: 0xC
	public RefreshRate refreshRate; //Field offset: 0x10
	public RectInt workArea; //Field offset: 0x18
	public string name; //Field offset: 0x28

	public override bool Equals(DisplayInfo other) { }

}

