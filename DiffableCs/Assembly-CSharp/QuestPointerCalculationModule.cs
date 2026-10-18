//Type is in global namespace

public class QuestPointerCalculationModule
{
	private const float InvSqrt2 = 0.70710677; //Field offset: 0x0
	private const float SqrDeltaEpsilon = 1E-06; //Field offset: 0x0
	private const float SqrToTargetEpsilon = 1E-08; //Field offset: 0x0
	[SerializeField]
	private float _fullAlphaDistance; //Field offset: 0x10
	[SerializeField]
	private float _directionSharpness; //Field offset: 0x14
	[SerializeField]
	private float _alphaLerpSpeed; //Field offset: 0x18
	[SerializeField]
	private float _lookAtConeHalfAngleDeg; //Field offset: 0x1C
	[SerializeField]
	private float _minDistanceForFullPointer; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _minAlpha; //Field offset: 0x24
	private float _sqrMinDistanceForFullPointer; //Field offset: 0x28
	private float _sqrFullAlphaDistance; //Field offset: 0x2C
	private float _clampedMinDistanceAlpha; //Field offset: 0x30
	private float _coneCosSq; //Field offset: 0x34
	private int _cornerWeightPower; //Field offset: 0x38
	private float _upLeftPointAlpha; //Field offset: 0x3C
	private float _upRightPointAlpha; //Field offset: 0x40
	private float _downLeftPointAlpha; //Field offset: 0x44
	private float _downRightPointAlpha; //Field offset: 0x48

	public QuestPointerCalculationModule() { }

	[CompilerGenerated]
	internal static float <GetQuestCornerWeightsFromDirection>g__RaiseCornerWeight01|25_0(float u, int power) { }

	private void GetQuestCornerWeightsFromDirection(Vector2 directionNormalized, float sharpness, out float upLeft, out float upRight, out float downLeft, out float downRight) { }

	public void GetQuestItemPointAlphas(out float upLeft, out float upRight, out float downLeft, out float downRight) { }

	private float GetQuestPointerDistanceAlphaMultiplier(GamePlayerOwner owner, float sqrDist) { }

	private Vector3 GetQuestPointerScreenDelta(Camera camera, Vector3 questWorldPosition) { }

	private bool IsQuestLootInsideLookCone(Camera camera, Vector3 questLootWorldPosition) { }

	public void SetQuestCornerAlphas(float targetUl, float targetUr, float targetDl, float targetDr, bool ignoreClamp = false) { }

	public void Setup() { }

	public void UpdateQuestItemPointerAlphas(GamePlayerOwner owner, Vector3 questLootPosition) { }

}

