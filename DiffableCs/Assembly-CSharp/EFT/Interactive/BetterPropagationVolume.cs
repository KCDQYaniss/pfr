namespace EFT.Interactive;

public class BetterPropagationVolume : MonoBehaviour, IPhysicsTrigger
{
	public BoxCollider Collider; //Field offset: 0x20
	public bool MutuallyExclusive; //Field offset: 0x28
	public EVolumeRelations SelfRelation; //Field offset: 0x2C
	public bool IsIsolated; //Field offset: 0x30
	[Range(0, 1)]
	public float SelfOcclusionIntensity; //Field offset: 0x34
	[SerializeField]
	private bool _decayEnabled; //Field offset: 0x38
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x40
	[HideInInspector]
	public EVolumeRelationsMask SelfRelationMask; //Field offset: 0x48
	public List Connections; //Field offset: 0x50
	public Vector4 PropagationDistance; //Field offset: 0x58

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BetterPropagationVolume() { }

	public float Audibility(Vector3 globalPosition) { }

	public float ConnectionAudibility(BetterPropagationVolume volume) { }

	[ContextMenu("ConvertEnums")]
	private void ConvertEnums() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public EVolumeRelationsMask GetRelation(BetterPropagationVolume volume) { }

	public static RelationParameters GetRelation(Player player, IPlayer sourcePlayer, Vector3 lPosition, Vector3 sPosition) { }

	public static RelationParameters GetRelationByPosition(Vector3 listenerPosition, Vector3 sourcePosition) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private float LocalAudibility(Vector3 localPosition) { }

	private void OnDestroy() { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	private void Start() { }

	public bool UseManualAudibilitySettings(BetterPropagationVolume volume) { }

}

