namespace Audio.AmbientSubsystem;

public class MyPlayerInOutBlendBalanceCalculator
{
	private float _blendSpeed; //Field offset: 0x10
	private float _currentOutdoorFilterValue; //Field offset: 0x14

	public MyPlayerInOutBlendBalanceCalculator() { }

	public float CalculateNormalizedScore(in PortalCalculatedData calculatedData, float dt, Vector3 listenerPosition, float minValue, float depthCalculationMult, float listenerHeightWeight) { }

	private float CalculateOutdoorFilterValue(float portalDepth, float currentDistance, float minValue, float depthMult) { }

	public void SetBlendSpeed(float speed) { }

}

