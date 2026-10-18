//Type is in global namespace

public class NightVisionZBlur : MonoBehaviour
{
	private DepthOfField _depthOfField; //Field offset: 0x20
	private NightVisionBlurProperties _cachedProperties; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsApplied>k__BackingField; //Field offset: 0x4C
	[SerializeField]
	private NightVisionBlurProperties _targetProperties; //Field offset: 0x50

	public private bool IsApplied
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public NightVisionZBlur() { }

	public void Apply(bool isEnabled) { }

	public void Construct(DepthOfField feature) { }

	[CompilerGenerated]
	public bool get_IsApplied() { }

	private void PasteFrom(NightVisionBlurProperties nightVisionBlurProperties) { }

	[CompilerGenerated]
	private void set_IsApplied(bool value) { }

}

