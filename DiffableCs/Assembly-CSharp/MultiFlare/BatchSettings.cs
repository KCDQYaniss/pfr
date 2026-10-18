namespace MultiFlare;

public class BatchSettings
{
	private float _alphaMultiplier; //Field offset: 0x10
	private float _sizeMultiplier; //Field offset: 0x14
	[SerializeField]
	private int _capacity; //Field offset: 0x18
	[SerializeField]
	private Material _material; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _blindProtectionAlphaFactor; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	private float _blindProtectionSizeFactor; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsNvEnabled>k__BackingField; //Field offset: 0x30

	public float AlphaMultiplier
	{
		 get { } //Length: 21
	}

	public int Capacity
	{
		 get { } //Length: 4
	}

	public bool IsNvEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Material Material
	{
		 get { } //Length: 5
	}

	public float SizeMultiplier
	{
		 get { } //Length: 21
	}

	public BatchSettings() { }

	public float get_AlphaMultiplier() { }

	public int get_Capacity() { }

	[CompilerGenerated]
	public bool get_IsNvEnabled() { }

	public Material get_Material() { }

	public float get_SizeMultiplier() { }

	[CompilerGenerated]
	public void set_IsNvEnabled(bool value) { }

	public void SetBlindnessProtectionFactor(float value) { }

}

