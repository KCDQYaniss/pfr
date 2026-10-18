namespace Meta.XR.Acoustics;

public class MaterialData
{
	[SerializeField]
	internal Spectrum absorption; //Field offset: 0x10
	[SerializeField]
	internal Spectrum transmission; //Field offset: 0x18
	[SerializeField]
	internal Spectrum scattering; //Field offset: 0x20
	[SerializeField]
	internal Color color; //Field offset: 0x28

	internal bool IsEmpty
	{
		internal get { } //Length: 134
	}

	public MaterialData() { }

	internal void Clone(MaterialData other) { }

	internal bool get_IsEmpty() { }

}

