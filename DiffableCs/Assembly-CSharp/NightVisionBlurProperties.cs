//Type is in global namespace

public struct NightVisionBlurProperties
{
	[SerializeField]
	private bool _enabled; //Field offset: 0x0
	[SerializeField]
	private bool _overrideFromGraphics; //Field offset: 0x1
	[SerializeField]
	private float _focalDistance; //Field offset: 0x4
	[SerializeField]
	private float _focalSize; //Field offset: 0x8
	[SerializeField]
	private float _aperture; //Field offset: 0xC
	[SerializeField]
	private BlurType _defocusType; //Field offset: 0x10
	[SerializeField]
	private BlurSampleCount _sampleCount; //Field offset: 0x14
	[SerializeField]
	private float _maxBlurDistance; //Field offset: 0x18
	[SerializeField]
	private bool _highResolution; //Field offset: 0x1C
	[SerializeField]
	private bool _nearBlur; //Field offset: 0x1D
	[SerializeField]
	private float _overlapSize; //Field offset: 0x20

	public float Aperture
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public BlurType DefocusType
	{
		 get { } //Length: 164
		 set { } //Length: 4
	}

	public bool Enabled
	{
		 get { } //Length: 4
		 set { } //Length: 3
	}

	public float FocalDistance
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float FocalSize
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool HighResolution
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float MaxBlurDistance
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool NearBlur
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float OverlapSize
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool OverrideFromGraphics
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public BlurSampleCount SampleCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float get_Aperture() { }

	public BlurType get_DefocusType() { }

	public bool get_Enabled() { }

	public float get_FocalDistance() { }

	public float get_FocalSize() { }

	public bool get_HighResolution() { }

	public float get_MaxBlurDistance() { }

	public bool get_NearBlur() { }

	public float get_OverlapSize() { }

	public bool get_OverrideFromGraphics() { }

	public BlurSampleCount get_SampleCount() { }

	public void set_Aperture(float value) { }

	public void set_DefocusType(BlurType value) { }

	public void set_Enabled(bool value) { }

	public void set_FocalDistance(float value) { }

	public void set_FocalSize(float value) { }

	public void set_HighResolution(bool value) { }

	public void set_MaxBlurDistance(float value) { }

	public void set_NearBlur(bool value) { }

	public void set_OverlapSize(float value) { }

	public void set_OverrideFromGraphics(bool value) { }

	public void set_SampleCount(BlurSampleCount value) { }

}

