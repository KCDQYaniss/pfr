namespace EFT.Hideout.ShootingRange;

public class PaperTarget : MonoBehaviour
{
	[SerializeField]
	private DecalSystem _decal; //Field offset: 0x20
	[SerializeField]
	private HideoutTargetBallisticCollider[] _colliders; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0x30

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public PaperTarget() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	private void HandleHitTarget(TargetColliderType targetColliderType, int segmentTarget) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	public void Replace() { }

}

