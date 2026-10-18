namespace EFT.UI;

public sealed class StaticIcons : ScriptableObject
{
	internal sealed class BuffIdToSpriteDictionary : SerializableEnumDictionary
	{

		public BuffIdToSpriteDictionary() { }

	}

	internal sealed class CurrencyTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public CurrencyTypeToSpriteDictionary() { }

	}

	internal sealed class DamageEffectTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public DamageEffectTypeToSpriteDictionary() { }

	}

	internal sealed class DamageResultToSpriteDictionary : SerializableEnumDictionary
	{

		public DamageResultToSpriteDictionary() { }

	}

	internal sealed class EffectSprites : ISerializationCallbackReceiver
	{
		public Sprite Painkiller; //Field offset: 0x10
		public Sprite Tremor; //Field offset: 0x18
		public Sprite Fracture; //Field offset: 0x20
		public Sprite Exhaustion; //Field offset: 0x28
		public Sprite TunnelVision; //Field offset: 0x30
		public Sprite Dehydration; //Field offset: 0x38
		public Sprite Contusion; //Field offset: 0x40
		public Sprite Wound; //Field offset: 0x48
		public Sprite LightBleeding; //Field offset: 0x50
		public Sprite HeavyBleeding; //Field offset: 0x58
		public Sprite Pain; //Field offset: 0x60
		public Sprite Berserk; //Field offset: 0x68
		public Sprite Stun; //Field offset: 0x70
		public Sprite StimulatorBuff; //Field offset: 0x78
		public Sprite StimulatorDebuff; //Field offset: 0x80
		public Sprite ChronicStaminaFatigue; //Field offset: 0x88
		public Sprite Encumbered; //Field offset: 0x90
		public Sprite OverEncumbered; //Field offset: 0x98
		public Sprite Intoxication; //Field offset: 0xA0
		public Sprite LethalIntoxication; //Field offset: 0xA8
		public Sprite ImmunityPreventedContamination; //Field offset: 0xB0
		public Sprite HalloweenBuff; //Field offset: 0xB8
		public Sprite MisfireEffect; //Field offset: 0xC0
		public Sprite PanicEffect; //Field offset: 0xC8
		public Sprite MildMusclePain; //Field offset: 0xD0
		public Sprite SevereMusclePain; //Field offset: 0xD8
		public Sprite ZombieInfection; //Field offset: 0xE0
		public Sprite Frostbite; //Field offset: 0xE8
		public Sprite FrostbiteStrong; //Field offset: 0xF0
		public Sprite TearGasWeak; //Field offset: 0xF8
		public Sprite TearGasStrong; //Field offset: 0x100
		public readonly Dictionary EffectIcons; //Field offset: 0x108

		public EffectSprites() { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	}

	internal sealed class FinalIconsDictionaryPVE : SerializableEnumDictionary
	{

		public FinalIconsDictionaryPVE() { }

	}

	internal sealed class FinalIconsDictionaryRegular : SerializableEnumDictionary
	{

		public FinalIconsDictionaryRegular() { }

	}

	internal sealed class GestureToSpriteDictionary : SerializableEnumDictionary
	{

		public GestureToSpriteDictionary() { }

	}

	internal sealed class HealthFactorTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public HealthFactorTypeToSpriteDictionary() { }

	}

	internal sealed class ItemAttributeIdToSpriteDictionary : SerializableEnumDictionary
	{

		public ItemAttributeIdToSpriteDictionary() { }

	}

	internal sealed class ItemTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public ItemTypeToSpriteDictionary() { }

	}

	internal sealed class NotificationIconTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public NotificationIconTypeToSpriteDictionary() { }

	}

	internal sealed class QuestIconTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public QuestIconTypeToSpriteDictionary() { }

	}

	internal sealed class QuestTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public QuestTypeToSpriteDictionary() { }

	}

	internal sealed class SkillIdToSpriteDictionary : SerializableEnumDictionary
	{

		public SkillIdToSpriteDictionary() { }

	}

	internal sealed class StatGroupIdToSpriteDictionary : SerializableEnumDictionary
	{

		public StatGroupIdToSpriteDictionary() { }

	}

	internal sealed class StimulatorBuffTypeToSpriteDictionary : SerializableEnumDictionary
	{

		public StimulatorBuffTypeToSpriteDictionary() { }

	}

	internal sealed class TraderDialogLineSpriteDictionary : SerializableEnumDictionary
	{

		public TraderDialogLineSpriteDictionary() { }

	}

	internal sealed class WishlistIconSpriteDictionary : SerializableEnumDictionary
	{

		public WishlistIconSpriteDictionary() { }

	}

	public const string ASSET_NAME = "Static Icons"; //Field offset: 0x0
	public ItemTypeToSpriteDictionary ItemTypeSprites; //Field offset: 0x18
	public QuestTypeToSpriteDictionary QuestTypeSprites; //Field offset: 0x20
	public QuestIconTypeToSpriteDictionary QuestIconTypeSprites; //Field offset: 0x28
	public BuffIdToSpriteDictionary BuffIdSprites; //Field offset: 0x30
	public SkillIdToSpriteDictionary SkillIdSprites; //Field offset: 0x38
	public StatGroupIdToSpriteDictionary StatGroupSprites; //Field offset: 0x40
	public DamageResultToSpriteDictionary DamageResultSprites; //Field offset: 0x48
	public NotificationIconTypeToSpriteDictionary NotificationSprites; //Field offset: 0x50
	public GestureToSpriteDictionary GestureSprites; //Field offset: 0x58
	public TraderDialogLineSpriteDictionary DialogLineSprites; //Field offset: 0x60
	public WishlistIconSpriteDictionary WishlistSprites; //Field offset: 0x68
	public WishlistIconSpriteDictionary WishlistSpritesOutline; //Field offset: 0x70
	public FinalIconsDictionaryRegular FinalIconsRegular; //Field offset: 0x78
	public FinalIconsDictionaryPVE FinalIconsPVE; //Field offset: 0x80
	[Header("Attributes")]
	public ItemAttributeIdToSpriteDictionary ItemAttributeSprites; //Field offset: 0x88
	public HealthFactorTypeToSpriteDictionary HealEffectSprites; //Field offset: 0x90
	public DamageEffectTypeToSpriteDictionary DamageEffectSprites; //Field offset: 0x98
	public StimulatorBuffTypeToSpriteDictionary StimulatorBuffSprites; //Field offset: 0xA0
	[Header("Currencies")]
	public CurrencyTypeToSpriteDictionary CurrencyTypeSmallSprites; //Field offset: 0xA8
	public CurrencyTypeToSpriteDictionary CurrencyTypeBigSprites; //Field offset: 0xB0
	public Sprite BarterSign; //Field offset: 0xB8
	[Header("Misc")]
	public Sprite YesCheck; //Field offset: 0xC0
	public Sprite NoCheck; //Field offset: 0xC8
	public Sprite TogglableOn; //Field offset: 0xD0
	public Sprite TogglableOff; //Field offset: 0xD8
	public Sprite CompletableOn; //Field offset: 0xE0
	public Sprite CompletableOff; //Field offset: 0xE8
	public Sprite OpenHideoutArea; //Field offset: 0xF0
	public Sprite PlayerIconPlaceholder; //Field offset: 0xF8
	[Header("Health Effects")]
	public EffectSprites EffectIcons; //Field offset: 0x100
	private HideoutCustomizationIcons _hideoutCustomizationIcons; //Field offset: 0x108

	public StaticIcons() { }

	public Sprite GetAttributeIcon(Enum id) { }

	public Sprite GetBigCurrencySign(Nullable templateId) { }

	public Sprite GetCompletableSprite(bool completed) { }

	public Sprite GetHideoutCustomizationIcon(string itemId) { }

	[CanBeNull]
	public Sprite GetItemTypeIcon(EItemType type) { }

	[CanBeNull]
	public Sprite GetQuestIcon(Condition condition) { }

	[CanBeNull]
	public Sprite GetSmallCurrencySign(Nullable templateId, bool nullable = false) { }

	public Sprite GetStatGroupIcon(EStatGroupId groupId) { }

	public bool TryGetFinalSprite(EFinalType finalType, bool isPve, out Sprite icon) { }

}

