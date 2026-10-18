namespace BSG.CameraEffects;

public class FaceCoverMaskEffect : MonoBehaviour, ITextureMaskHolder
{
	[SerializeField]
	private List _masks; //Field offset: 0x20
	[SerializeField]
	private TextureMask _textureMask; //Field offset: 0x28
	private Dictionary _maskDictionary; //Field offset: 0x30
	[CompilerGenerated]
	private bool <On>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <LastMaskNotNone>k__BackingField; //Field offset: 0x39

	public private bool LastMaskNotNone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool On
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FaceCoverMaskEffect() { }

	private void CreateMaskDictionary() { }

	[CompilerGenerated]
	public bool get_LastMaskNotNone() { }

	[CompilerGenerated]
	public bool get_On() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_LastMaskNotNone(bool value) { }

	[CompilerGenerated]
	private void set_On(bool value) { }

	public void SetMask(EFaceCoverMask mask, float maskSize) { }

	public void SetOn(bool isOn) { }

}

