namespace EFT.Ballistics;

public class BallisticCollider : BaseBallistic
{
	public const int OLD_PRESET_ID = -900; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private int _presetId; //Field offset: 0x28
	public int NetId; //Field offset: 0x2C
	public EHitType HitType; //Field offset: 0x30
	[SerializeField]
	private MaterialType _typeOfMaterial; //Field offset: 0x34
	[CompilerGenerated]
	private Action OnHitAction; //Field offset: 0x38
	public float PenetrationLevel; //Field offset: 0x40
	[Range(0, 1)]
	public float PenetrationChance; //Field offset: 0x44
	[Range(0, 1)]
	public float RicochetChance; //Field offset: 0x48
	[Range(0, 1)]
	public float FragmentationChance; //Field offset: 0x4C
	[Range(0, 1)]
	public float TrajectoryDeviationChance; //Field offset: 0x50
	[Range(0, 1)]
	public float TrajectoryDeviation; //Field offset: 0x54

	public event Action OnHitAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public MaterialType TypeOfMaterial
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public BallisticCollider() { }

	[CompilerGenerated]
	public void add_OnHitAction(Action value) { }

	public override PlayerHitInfo ApplyHit(DamageInfo damageInfo, ShotId shotID) { }

	public override void Awake() { }

	public override bool Deflects(float _hitCosDirectionToNormal, Shot shot, Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection) { }

	public int FindPresetIndex() { }

	public static int FindPresetIndex(BallisticCollider collider) { }

	public virtual BallisticCollider Get(Vector3 pos) { }

	public MaterialType get_TypeOfMaterial() { }

	public override bool IsPenetrated(Shot shot, Vector3 hitPoint) { }

	public bool IsUnsetup() { }

	[CompilerGenerated]
	public void remove_OnHitAction(Action value) { }

	public void set_TypeOfMaterial(MaterialType value) { }

	public virtual void TakeSettingsFrom(BaseBallistic collider) { }

	public override void UnsubscribeHitAction() { }

}

