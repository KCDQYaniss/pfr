namespace EFT.Visual;

public class TorsoSkin : AbstractSkin
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Create; //Field offset: 0x0

	}

	[SerializeField]
	private Skin _skin; //Field offset: 0x28
	[SerializeField]
	private Mesh _base; //Field offset: 0x30
	[SerializeField]
	private Mesh _armor; //Field offset: 0x38
	[SerializeField]
	private Mesh _vest; //Field offset: 0x40
	private PlayerBody _playerBody; //Field offset: 0x48

	public virtual SkinnedMeshRenderer SkinnedMeshRenderer
	{
		 get { } //Length: 42
	}

	public TorsoSkin() { }

	[CompilerGenerated]
	private void <ApplySkin>b__9_0(Tuple tuple) { }

	public virtual void ApplySkin() { }

	public virtual SkinnedMeshRenderer get_SkinnedMeshRenderer() { }

	public Skin GetSkin() { }

	public void Init(Skeleton skeleton, PlayerBody playerBody) { }

	public virtual void Unskin() { }

}

