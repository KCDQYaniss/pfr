namespace EFT.Animations;

public class NewRotationRecoilProcess : RotationRecoilProcessBase
{
	private enum ReturnTrajectorySideType
	{
		Left = 0,
		Right = 1,
		None = 2,
	}

	[Tooltip("Диапазон вертикального смещения ствола в состоянии покоя после отдачи, прилетает с бэка")]
	public Vector2 AfterRecoilOffsetVerticalRange; //Field offset: 0x60
	[Tooltip("Диапазон горизонтального смещения ствола в состоянии покоя после отдачи, прилетает с бэка")]
	public Vector2 AfterRecoilOffsetHorizontalRange; //Field offset: 0x68
	[Tooltip("Диапазон допустимых значений для добавляемого во время стабилизации к основному углу разброса, прилетает с бэка")]
	public Vector2 ProgressRecoilAngleOnStable; //Field offset: 0x70
	[Tooltip("Диапазон вертикального смещения ствола в состоянии покоя после отдачи")]
	public float ToNextStablePointDistanceLimit; //Field offset: 0x78
	[Tooltip("Диапазон рандомной дистанции следующией точки отдачи по расчитанному направлению из точки стабилизации")]
	public Vector2 NextStablePointDistanceRange; //Field offset: 0x7C
	[Tooltip("Сила с которой ствол будет отклоняться в сторону во время расчет траектории возврата оружия, прилетает с бэка")]
	public float RecoilReturnTrajectoryOffset; //Field offset: 0x84
	[Tooltip("Величина, добавляемая к общему углу разброса отдачи за каждый выстрел во время стабилизации огня, прилетает с бэка")]
	public float StableAngleIncreaseStep; //Field offset: 0x88
	[Tooltip("Величина затухания импульса силы смещения траектории возвращения ствола, прилетает с бэка")]
	public float ReturnTrajectoryDumping; //Field offset: 0x8C
	[Tooltip("Множитель силы вращения ствола для категории оружия, прилетает с бэка")]
	public float CategoryIntensityMultiplier; //Field offset: 0x90
	[Tooltip("Скорость смещения ствола к следующей точке потенциального выстрела во время стабилизации огня")]
	public float ToNextCurrentSpeed; //Field offset: 0x94
	[Tooltip("Дополнительный модификатор отдачи, работающий при вертикальном упоре оружия")]
	public float MountVerticalRecoilMultiplier; //Field offset: 0x98
	[Tooltip("Дополнительный модификатор отдачи, работающий при горизонтальном упоре оружия")]
	public float MountHorizontalRecoilMultiplier; //Field offset: 0x9C
	[Tooltip("Дополнительный модификатор cкорости возврата к исходному положению, работающий при упоре оружия")]
	public float MountingReturnHandSpeedMultiplier; //Field offset: 0xA0
	[Tooltip("Дополнительный модификатор отдачи, работающий при упоре оружия на сошки")]
	public float BipodRecoilMultiplier; //Field offset: 0xA4
	[Tooltip("Дополнительный модификатор cкорости возврата к исходному положению, работающий при упоре оружия на сошки")]
	public float BipodReturnHandSpeedMultiplier; //Field offset: 0xA8
	[Tooltip("Параметр указывающий на сброс данных отдачи после выстрела в дефолтное состояние")]
	public bool ResetAfterShot; //Field offset: 0xAC
	[Tooltip("Множитель скорости возврата вращения ствола в зависимости от времени автоматического огня")]
	public AnimationCurve ReturnSpeedCurve; //Field offset: 0xB0
	[HideInInspector]
	public bool AutoFireOn; //Field offset: 0xB8
	[HideInInspector]
	public float MultiplayerByShotIndex; //Field offset: 0xBC
	[HideInInspector]
	public float CurrentAngleAdd; //Field offset: 0xC0
	private Vector3 _previousCurrent; //Field offset: 0xC4
	private Vector2 _afterRecoilDefaultPosition; //Field offset: 0xD0
	private Vector3 _stableCurrent; //Field offset: 0xD8
	private Vector3 _nextCurrent; //Field offset: 0xE4
	private Vector3 _nextCurrentDirection; //Field offset: 0xF0
	private float _curveTime; //Field offset: 0xFC
	private float _autoFireSpeed; //Field offset: 0x100
	private float _toOffsetPosSpeed; //Field offset: 0x104
	private float _recoilOffsetImpulse; //Field offset: 0x108
	private float _afterOffsetCalculateCurrentX; //Field offset: 0x10C
	private bool _returnTrajectoryOn; //Field offset: 0x110
	private bool _mountedMode; //Field offset: 0x111
	private bool _verticalMount; //Field offset: 0x112
	private bool _bipodMode; //Field offset: 0x113
	private ReturnTrajectorySideType ReturnTrajectorySide; //Field offset: 0x114

	public NewRotationRecoilProcess() { }

	public virtual void AddAccelerationLimitless(int comp, float val) { }

	private void CalculateAfterRecoilWeaponOffset() { }

	public virtual void CalculateRecoil(float deltaTime) { }

	private void CalculateReturnTrajectory(float deltaTime) { }

	private void CalculateReturnTrajectoryParameters() { }

	private Vector3 GetLerpCurrentWithAfterRecoilOffset() { }

	public void Reset() { }

	public void SetAutoFireMode(bool enable) { }

	public void SetBipodMode(bool enable) { }

	public void SetMountedMode(bool enable, bool isVerticalMounting) { }

	public void SetStableMode(bool enable) { }

}

