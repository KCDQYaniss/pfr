//Type is in global namespace

public class CoverPointCreatorPreset
{
	[SerializeField]
	private string _name; //Field offset: 0x10
	[SerializeField]
	private DirectionCalculationType _directionCalculation; //Field offset: 0x18
	[SerializeField]
	private float _angleToRemovePointOnEdge; //Field offset: 0x1C
	[SerializeField]
	private float _distanceBetweenCoversOnEdge; //Field offset: 0x20
	[SerializeField]
	private float _smallEdgeSize; //Field offset: 0x24
	[SerializeField]
	private float _clusterLargeDist; //Field offset: 0x28
	[SerializeField]
	private float _clusterAmbushDist; //Field offset: 0x2C
	[SerializeField]
	private float _clusterLargeAngle; //Field offset: 0x30
	[SerializeField]
	private float _clusterNearDist; //Field offset: 0x34
	[SerializeField]
	private float _clusterFirePosDist; //Field offset: 0x38
	[SerializeField]
	private float _fireStepDist; //Field offset: 0x3C
	[SerializeField]
	private bool _bothFireposIsBadCover; //Field offset: 0x40
	[SerializeField]
	private float _distanceRaycastMultiplier; //Field offset: 0x44
	[SerializeField]
	private float _distanceFireposMultiplier; //Field offset: 0x48
	[SerializeField]
	private float _ambushMinSegment; //Field offset: 0x4C
	[SerializeField]
	private float _legWallCheck; //Field offset: 0x50
	[SerializeField]
	private float _legsCheckMinDist; //Field offset: 0x54
	[SerializeField]
	private bool _highQualityBorder; //Field offset: 0x58
	[FormerlySerializedAs("_checkLineCast")]
	[SerializeField]
	private bool _ignoreRayCast; //Field offset: 0x59
	[SerializeField]
	private bool _withCheckPointStay; //Field offset: 0x5A
	[SerializeField]
	private float _checkOnNavMeshDist; //Field offset: 0x5C
	[SerializeField]
	private float _sphereCastRadius; //Field offset: 0x60
	[SerializeField]
	private bool _removeCoversNearDoorAfterCalc; //Field offset: 0x64
	[SerializeField]
	private float _stepFromEndOfWall; //Field offset: 0x68

	public float AmbushMinSegment
	{
		 get { } //Length: 6
	}

	public float ANGLE_TO_REMOVE_POINT_ON_EDGE
	{
		 get { } //Length: 6
	}

	public bool BOTH_FIREPOS_IS_BAD_COVER
	{
		 get { } //Length: 5
	}

	public float CheckOnNavMeshDist
	{
		 get { } //Length: 6
	}

	public float CLUSTER_AMBUSH_DIST
	{
		 get { } //Length: 6
	}

	public float CLUSTER_FIREPOS_DIST
	{
		 get { } //Length: 6
	}

	public float CLUSTER_LARGE_ANGLE
	{
		 get { } //Length: 6
	}

	public float CLUSTER_LARGE_DIST
	{
		 get { } //Length: 6
	}

	public float CLUSTER_NEAR_DIST
	{
		 get { } //Length: 6
	}

	public DirectionCalculationType DirectionCalculation
	{
		 get { } //Length: 4
	}

	public float DISTANCE_BETWEEN_COVERS_ON_EDGE
	{
		 get { } //Length: 6
	}

	public float DISTANCE_FIREPOS_MULTIPLIER
	{
		 get { } //Length: 6
	}

	public float DISTANCE_RAYCAST_MULTIPLIER
	{
		 get { } //Length: 6
	}

	public float FIRE_STEP_DIST
	{
		 get { } //Length: 6
	}

	public bool HighQualityBorder
	{
		 get { } //Length: 5
	}

	public bool IgnoreLineCast
	{
		 get { } //Length: 5
	}

	public float LEG_WALL_CHECK
	{
		 get { } //Length: 6
	}

	public float LegsCheckMinDist
	{
		 get { } //Length: 6
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public bool RemoveCoversNearDoorAfterCalc
	{
		 get { } //Length: 5
	}

	public float SMALL_EDGE_SIZE
	{
		 get { } //Length: 6
	}

	public float SphereCastRadius
	{
		 get { } //Length: 6
	}

	public float STEP_FROM_END_OF_WALL
	{
		 get { } //Length: 6
	}

	public bool WithCheckPointStay
	{
		 get { } //Length: 5
	}

	public CoverPointCreatorPreset() { }

	public float get_AmbushMinSegment() { }

	public float get_ANGLE_TO_REMOVE_POINT_ON_EDGE() { }

	public bool get_BOTH_FIREPOS_IS_BAD_COVER() { }

	public float get_CheckOnNavMeshDist() { }

	public float get_CLUSTER_AMBUSH_DIST() { }

	public float get_CLUSTER_FIREPOS_DIST() { }

	public float get_CLUSTER_LARGE_ANGLE() { }

	public float get_CLUSTER_LARGE_DIST() { }

	public float get_CLUSTER_NEAR_DIST() { }

	public DirectionCalculationType get_DirectionCalculation() { }

	public float get_DISTANCE_BETWEEN_COVERS_ON_EDGE() { }

	public float get_DISTANCE_FIREPOS_MULTIPLIER() { }

	public float get_DISTANCE_RAYCAST_MULTIPLIER() { }

	public float get_FIRE_STEP_DIST() { }

	public bool get_HighQualityBorder() { }

	public bool get_IgnoreLineCast() { }

	public float get_LEG_WALL_CHECK() { }

	public float get_LegsCheckMinDist() { }

	public string get_Name() { }

	public bool get_RemoveCoversNearDoorAfterCalc() { }

	public float get_SMALL_EDGE_SIZE() { }

	public float get_SphereCastRadius() { }

	public float get_STEP_FROM_END_OF_WALL() { }

	public bool get_WithCheckPointStay() { }

	public static CoverPointCreatorPreset LoadDefault() { }

}

