namespace EFT.Animations;

public class OldRotationRecoilProcess : RotationRecoilProcessBase
{
	public AnimationCurve ReturnSpeedCurve; //Field offset: 0x60
	private float[] _originalReturnCurveValues; //Field offset: 0x68
	private float _curveTime; //Field offset: 0x70

	public OldRotationRecoilProcess() { }

	public virtual void CalculateRecoil(float deltaTime) { }

	public void SaveOriginalReturnSpeedCurveValues() { }

	public void SetReturnSpeedCurveScale(float mult) { }

}

