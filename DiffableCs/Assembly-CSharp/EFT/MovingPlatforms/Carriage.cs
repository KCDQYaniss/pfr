namespace EFT.MovingPlatforms;

public class Carriage : MovingPlatform
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <LegacyPlaceAtEndPosition>b__33_0(Keyframe x) { }

	}

	internal enum CarriageMoveType
	{
		LegacyBySelfRoute = 0,
		BasedOnLocomotivePos = 1,
	}

	[SerializeField]
	private float _suspensionStiffness; //Field offset: 0xE8
	[SerializeField]
	private Vector2 _suspension; //Field offset: 0xEC
	[SerializeField]
	private float _shiftDelta; //Field offset: 0xF4
	public CarriageMoveType carriageMoveType; //Field offset: 0xF8
	public Locomotive Locomotive; //Field offset: 0x100
	public Vector3 LocomotivePivot; //Field offset: 0x108
	public Vector3 LocalPivot; //Field offset: 0x114
	[Header("Trailer shift and jitter")]
	[Tooltip("Смещение вагона относительно локомотива")]
	public float Shift; //Field offset: 0x120
	[Tooltip("Диапозон тряски вагона назад/вперед")]
	public Vector3 ShiftRange; //Field offset: 0x124
	[Tooltip("Объект в направлении которого вагон смотрит (локомотив или след. вагон)")]
	public Transform RotationTarget; //Field offset: 0x130
	[Tooltip("Смещение вагона, использовать чтобы выровнять его (менять крайне аккуратно)")]
	public Vector3 CarriagePosOffset; //Field offset: 0x138
	private Transform _parentPlatform; //Field offset: 0x148
	private float _currentShift; //Field offset: 0x150
	private Vector2 _shiftRange; //Field offset: 0x154
	private float _shiftT; //Field offset: 0x15C
	private bool _shiftReverse; //Field offset: 0x160
	private float _jitterRnd; //Field offset: 0x164

	public virtual Vector3[] CachedDirections
	{
		 get { } //Length: 45
	}

	public virtual float CurveApproxLength
	{
		 get { } //Length: 45
	}

	public Transform ParentPlatform
	{
		 get { } //Length: 640
	}

	public virtual BezierSpline Spline
	{
		 get { } //Length: 45
	}

	public Carriage() { }

	public virtual Vector3[] get_CachedDirections() { }

	public virtual float get_CurveApproxLength() { }

	public Transform get_ParentPlatform() { }

	public virtual BezierSpline get_Spline() { }

	public virtual void Init(DateTime depart) { }

	private void LegacyPlaceAtEndPosition() { }

	private void LegacyPlaceAtStartPosition() { }

	public virtual void Move(bool force = false) { }

	[ContextMenu("End_Position")]
	public virtual void PlaceAtEndPosition() { }

	[ContextMenu("Start_Position")]
	public virtual void PlaceAtStartPosition() { }

	private void RefreshPositionBasedOnLoco(float currentDistance, float locomotiveDistance) { }

	private void RefreshPositionBasedOnRoute() { }

}

