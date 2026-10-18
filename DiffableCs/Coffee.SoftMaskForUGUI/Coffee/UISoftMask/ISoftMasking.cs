namespace Coffee.UISoftMask;

public interface ISoftMasking : IMeshModifier
{

	public bool alphaHitTest
	{
		 get { } //Length: 0
	}

	public float antiAliasingThreshold
	{
		 get { } //Length: 0
	}

	public bool enabled
	{
		 get { } //Length: 0
	}

	public MaskingMethod maskingMethod
	{
		 get { } //Length: 0
	}

	public RaycastMethod raycastMethod
	{
		 get { } //Length: 0
	}

	public bool showMaskGraphic
	{
		 get { } //Length: 0
	}

	public MinMax01 softnessRange
	{
		 get { } //Length: 0
	}

	public bool get_alphaHitTest() { }

	public float get_antiAliasingThreshold() { }

	public bool get_enabled() { }

	public MaskingMethod get_maskingMethod() { }

	public RaycastMethod get_raycastMethod() { }

	public bool get_showMaskGraphic() { }

	public MinMax01 get_softnessRange() { }

}

