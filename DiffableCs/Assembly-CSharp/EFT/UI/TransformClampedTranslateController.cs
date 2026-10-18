namespace EFT.UI;

public class TransformClampedTranslateController : MonoBehaviour
{
	internal class CameraPoint
	{
		public string Key; //Field offset: 0x10
		public Transform DefaultPosition; //Field offset: 0x18
		public Transform MinPosition; //Field offset: 0x20
		public Transform MaxPosition; //Field offset: 0x28

		public CameraPoint() { }

	}

	[SerializeField]
	private CameraPoint[] _points; //Field offset: 0x20
	[SerializeField]
	private Transform _moveTransform; //Field offset: 0x28
	[SerializeField]
	private float _speed; //Field offset: 0x30
	[SerializeField]
	private float _forceMul; //Field offset: 0x34
	private CameraPoint _currentPoint; //Field offset: 0x38
	private float _force; //Field offset: 0x40

	public TransformClampedTranslateController() { }

	public void Reset() { }

	public void SelectPoint(string key) { }

	public void Translate(int side) { }

	private void Update() { }

}

