namespace Cinemachine;

public class CinemachineBlend
{
	public ICinemachineCamera CamA; //Field offset: 0x10
	public ICinemachineCamera CamB; //Field offset: 0x18
	public AnimationCurve BlendCurve; //Field offset: 0x20
	public float TimeInBlend; //Field offset: 0x28
	public float Duration; //Field offset: 0x2C

	public float BlendWeight
	{
		 get { } //Length: 226
	}

	public string Description
	{
		 get { } //Length: 514
	}

	public bool IsComplete
	{
		 get { } //Length: 36
	}

	public bool IsValid
	{
		 get { } //Length: 123
	}

	public CameraState State
	{
		 get { } //Length: 1222
	}

	public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	public float get_BlendWeight() { }

	public string get_Description() { }

	public bool get_IsComplete() { }

	public bool get_IsValid() { }

	public CameraState get_State() { }

	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public bool Uses(ICinemachineCamera cam) { }

}

