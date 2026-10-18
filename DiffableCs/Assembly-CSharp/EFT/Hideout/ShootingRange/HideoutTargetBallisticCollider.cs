namespace EFT.Hideout.ShootingRange;

public class HideoutTargetBallisticCollider : BallisticCollider
{
	private const float DECAL_OFFSET = 0.001; //Field offset: 0x0
	public const int MISS_SHOT_TARGET = 2147483647; //Field offset: 0x0
	public const int PERFECT_SHOT_TARGET = 0; //Field offset: 0x0
	[SerializeField]
	[Space]
	private DecalSystem _decal; //Field offset: 0x58
	[SerializeField]
	[Space]
	private TargetColliderType _targetType; //Field offset: 0x60
	[SerializeField]
	private float[] _sizes; //Field offset: 0x68
	[SerializeField]
	[Space]
	private Vector3 _direction; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0x80
	private List _segments; //Field offset: 0x88

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private Vector3 _normal
	{
		private get { } //Length: 679
	}

	public HideoutTargetBallisticCollider() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	public virtual PlayerHitInfo ApplyHit(DamageInfo damageInfo, ShotId shotID) { }

	public void DrawGizmosCircle(Vector3 pos, Vector3 normal, float radius, int numSegments) { }

	public void DrawGizmosCircles(Vector3 pos) { }

	private void FixedUpdate() { }

	private Vector3 get__normal() { }

	private int GetSegmentTarget(float distance) { }

	private void OnDrawGizmos() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

}

