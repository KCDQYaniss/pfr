//Type is in global namespace

public static class AIGrenadeHelper
{
	public static float tan45; //Field offset: 0x0
	private static readonly Dictionary _angs; //Field offset: 0x8

	private static AIGrenadeHelper() { }

	private static float CalcY(float angRad, float power, float xDist, float percent) { }

	public static AIGreanageThrowData CanThrowGrenade2(Vector3 fromPlayerPosition, Vector3 trg, BotGrenadeController bot, AIGreandeAng greandeAng, float maxThrowDistSqrt = -1) { }

	public static AIGreanageThrowData CanThrowGrenade2(AIGrenadeThrowPositionPair positions, Vector3 trg, BotGrenadeController bot, AIGreandeAng greandeAng, float maxThrowDistSqrt = -1) { }

	public static AIGreanageThrowData CanThrowGrenade2(Vector3 fromPlayerPosition, Vector3 trg, float maxPower, AIGreandeAng greandeAng, float minThrowDistSqrt = -1, float maxPercent = 0.5) { }

	public static AIGreanageThrowData CanThrowGrenade2(AIGrenadeThrowPositionPair positions, Vector3 trg, float maxPower, AIGreandeAng greandeAng, float minThrowDistSqrt = -1, float maxPercent = 0.5) { }

	public static bool CheckThreePoints(Vector3 from, Vector3 midPoint, Vector3 target, out Vector3 hitPos) { }

	public static Vector3 FindDangerPoint(Vector3 position, Vector3 force, float mass) { }

	public static AIGreanageThrowData GetSuicideData(Vector3 from, Vector3 curLookDir) { }

	private static Vector3 RandomizeResult(Vector3 trg, float dist, float grenadePerMeter) { }

	private static Vector3 ResultTarget(Vector3 from, Vector3 force) { }

	public static AIGrenadeThrowPositionPair ThrowPositionFromGrenadePoint(Vector3 playerPosition) { }

	private static float YByX(float x, float power, float tan, float cos) { }

}

