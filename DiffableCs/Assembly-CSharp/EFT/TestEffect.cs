namespace EFT;

public class TestEffect : MonoBehaviour
{
	public static bool IsOfflineMode; //Field offset: 0x0
	public ActiveHealthController PlayerHealth; //Field offset: 0x20
	public Transform AreasParent; //Field offset: 0x28
	public Transform ButtonParent; //Field offset: 0x30
	public Transform ShootArea; //Field offset: 0x38
	public Transform BloodlossArea; //Field offset: 0x40
	public Transform BreackPartArea; //Field offset: 0x48
	public Transform ContusionArea; //Field offset: 0x50
	public Transform ShootOnArmorArea; //Field offset: 0x58
	public Transform SandInEyeArea; //Field offset: 0x60
	public Transform DisorientArea; //Field offset: 0x68
	public Transform StunArea; //Field offset: 0x70
	public Transform FlashArea; //Field offset: 0x78
	public Transform HydraTionArea; //Field offset: 0x80
	public Transform EnergyArea; //Field offset: 0x88
	public Transform HydrationSettings; //Field offset: 0x90
	public Transform EnergySettings; //Field offset: 0x98
	public Transform ToxicationArea; //Field offset: 0xA0
	public Transform RadiationArea; //Field offset: 0xA8
	public Transform HealingArea; //Field offset: 0xB0
	public Transform CureBreackPartArea; //Field offset: 0xB8
	public GameObject _currentEffectsText; //Field offset: 0xC0
	public GameObject _destroyebleEffectsText; //Field offset: 0xC8
	public GameObject _innerEffectsText; //Field offset: 0xD0
	public GameObject Hydration; //Field offset: 0xD8
	public GameObject Energy; //Field offset: 0xE0
	public GameObject Head; //Field offset: 0xE8
	public GameObject Breast; //Field offset: 0xF0
	public GameObject Stomatch; //Field offset: 0xF8
	public GameObject RightHand; //Field offset: 0x100
	public GameObject LeftHand; //Field offset: 0x108
	public GameObject RightLeg; //Field offset: 0x110
	public GameObject LeftLeg; //Field offset: 0x118
	public GameObject UseSpeed; //Field offset: 0x120
	public GameObject LootSpeed; //Field offset: 0x128
	public GameObject Precision; //Field offset: 0x130
	public GameObject WeaponGetSpeed; //Field offset: 0x138
	public GameObject ReloadSpeed; //Field offset: 0x140
	public GameObject Sense; //Field offset: 0x148
	public GameObject WalkSpeed; //Field offset: 0x150
	public GameObject WorkingState; //Field offset: 0x158
	public Slider _bloodlossHeadSlider; //Field offset: 0x160
	public Slider _dehydrationSlider; //Field offset: 0x168
	public Slider _exhaustionSlider; //Field offset: 0x170
	public Slider _breackPartSlider; //Field offset: 0x178
	[HideInInspector]
	public Dictionary _bloodlossEffectsDict; //Field offset: 0x180
	[HideInInspector]
	public Dictionary _bodyPartSlidersDict; //Field offset: 0x188
	private Dictionary _destroyebleEffects; //Field offset: 0x190

	public TestEffect() { }

	public void AddBloodloss() { }

	public void AddContusion() { }

	public void CloseAllButThis(Transform trans) { }

	public void Disorient() { }

	public void Fracture() { }

	public float GetBloodlossValue() { }

	public float GetBreackPartValue() { }

	public float GetDehydrationValue() { }

	public float GetExhausionValue() { }

	public void Healing() { }

	public void Intoxication() { }

	public void Load() { }

	private void OnEnable() { }

	public void PainOnOff() { }

	public void Radiation() { }

	public void SandInEye() { }

	public void SetEnergySettings() { }

	public void SetHydration() { }

	private bool SetState() { }

	public void Shoot() { }

	public void ShootOnArmor() { }

	private void Start() { }

	private void Update() { }

}

