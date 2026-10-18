namespace EFT.Vaulting.Models;

public class ObstacleCalculatorModel : IObstacleCalculatorModel, IObstacleCalculatorModelDebug
{
	private const float SPRINT_VAULT_Z_TRANSFORMATION = 2.6; //Field offset: 0x0
	private readonly Transform _gridRoot; //Field offset: 0x10
	private readonly Func _isSprintEnabled; //Field offset: 0x18
	private float _lengthThreshold; //Field offset: 0x20
	private float _slopedAreaThreshold; //Field offset: 0x24
	private float _rectangleAreaTreshold; //Field offset: 0x28
	private float _maxHeightOffset; //Field offset: 0x2C
	private float _mainObstacleLength; //Field offset: 0x30
	private float _mainObstacleHeight; //Field offset: 0x34
	private float _distanceToMainObstacle; //Field offset: 0x38
	private float _behindObstacleRatio; //Field offset: 0x3C
	private Nullable _minRoofHeight; //Field offset: 0x40
	private bool _isTerrain; //Field offset: 0x48
	[CompilerGenerated]
	private Collider <TargetCollider>k__BackingField; //Field offset: 0x50

	public override float BehindObstacleRatio
	{
		 get { } //Length: 6
	}

	public override float DistanceToMainObstacle
	{
		 get { } //Length: 6
	}

	public override bool IsTerrain
	{
		 get { } //Length: 5
	}

	public override float MainObstacleHeight
	{
		 get { } //Length: 6
	}

	public override float MainObstacleLength
	{
		 get { } //Length: 6
	}

	public override float MaxHeightOffset
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override Nullable MinRoofHeight
	{
		 get { } //Length: 5
	}

	public override float RectangleAreaThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override float SlopedAreaThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public private override Collider TargetCollider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ObstacleCalculatorModel(Transform gridRoot, Func isSprintEnabled) { }

	private float CalculateDistance(ref Vector3 p0) { }

	private float CalculateHeight(ref Vector3 p1, ref Vector3 p0) { }

	private float CalculateLength(ref Vector3 p1, ref Vector3 p0) { }

	private void CalculateMainObstacle(ref GridSurfaceCalculatorDataTransferModel data) { }

	private void CalculateMinOverObstacleHeight(Vector3 point) { }

	private void CalculateOverObstacleRatio(Vector3 lastPoint) { }

	public override void CalculateSurface(GridSurfaceCalculatorDataTransferModel data) { }

	private void Clear() { }

	public override float get_BehindObstacleRatio() { }

	public override float get_DistanceToMainObstacle() { }

	public override bool get_IsTerrain() { }

	public override float get_MainObstacleHeight() { }

	public override float get_MainObstacleLength() { }

	public override float get_MaxHeightOffset() { }

	public override Nullable get_MinRoofHeight() { }

	public override float get_RectangleAreaThreshold() { }

	public override float get_SlopedAreaThreshold() { }

	[CompilerGenerated]
	public override Collider get_TargetCollider() { }

	public override void set_MaxHeightOffset(float value) { }

	public override void set_RectangleAreaThreshold(float value) { }

	public override void set_SlopedAreaThreshold(float value) { }

	[CompilerGenerated]
	private void set_TargetCollider(Collider value) { }

}

