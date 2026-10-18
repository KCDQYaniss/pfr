namespace Diz.Skinning;

public class Skin : AbstractSkin
{
	[HideInInspector]
	[SerializeField]
	private SkinnedMeshRenderer _skinnedMeshRenderer; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private string[] _bonePaths; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private string _rootBonePath; //Field offset: 0x38
	private Skeleton _skeleton; //Field offset: 0x40

	public virtual SkinnedMeshRenderer SkinnedMeshRenderer
	{
		 get { } //Length: 5
	}

	public Skin() { }

	public virtual void ApplySkin() { }

	public virtual SkinnedMeshRenderer get_SkinnedMeshRenderer() { }

	public string[] GetBonePaths() { }

	public string GetRootBonePath() { }

	public void Init(Skeleton skeleton) { }

	public virtual void Unskin() { }

}

