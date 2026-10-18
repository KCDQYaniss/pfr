//Type is in global namespace

public sealed class EnemyPart
{
	[CompilerGenerated]
	private readonly IPlayer <EnemyPlayer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly BodyPartType <BodyPartType>k__BackingField; //Field offset: 0x18
	private readonly BifacialTransform _bifacialTransform; //Field offset: 0x20
	public readonly BodyPartCollider PartCollider; //Field offset: 0x28
	private int _posCachedForFrame; //Field offset: 0x30
	private Vector3 _positionCached; //Field offset: 0x34

	public BodyPartType BodyPartType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IPlayer EnemyPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Vector3 Position
	{
		 get { } //Length: 217
	}

	private EnemyPart(BodyPartType bodyPartType, IPlayer enemy, BifacialTransform bifacialTransform) { }

	private EnemyPart(BodyPartType bodyPartType, IPlayer enemy, BifacialTransform bifacialTransform, BodyPartCollider partCollider) { }

	public static Dictionary Create(IPlayer person, PlayerBones bones) { }

	[CompilerGenerated]
	public BodyPartType get_BodyPartType() { }

	[CompilerGenerated]
	public IPlayer get_EnemyPlayer() { }

	public Vector3 get_Position() { }

	public Vector3 GetPartPositionWithOffset(Vector3 offset) { }

}

