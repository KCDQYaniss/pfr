//Type is in global namespace

public class BotGlobalLayData
{
	[Comment("Главный ограничитель на тайминги попытки проверки лечь")]
	public float DELTA_LAY_CHECK; //Field offset: 0x10
	[Comment("Бот может встать только через Х после того как лег")]
	public float DELTA_GETUP; //Field offset: 0x14
	[Comment("После того как встал опять лечь можно только через Х")]
	public float DELTA_AFTER_GETUP; //Field offset: 0x18
	[Comment("если бот пролежит Х сек то все точки страха обнулятся")]
	public float CLEAR_POINTS_OF_SCARE_SEC; //Field offset: 0x1C
	[Comment("Если бот лежит больше Х то он встанет")]
	public float MAX_LAY_TIME; //Field offset: 0x20
	[Comment("Дельта проверки во время атаки: стоит ли ложится")]
	public float DELTA_WANT_LAY_CHECL_SEC; //Field offset: 0x24
	[Comment("Шанс лечь если все уловия выполнены")]
	public float ATTACK_LAY_CHANCE; //Field offset: 0x28
	[Comment("если до укрытия больше Х. одно из необходимых условий что бы лечь")]
	public float DIST_TO_COVER_TO_LAY; //Field offset: 0x2C
	[Comment("если между землей и травой меньше Х то можно лечь")]
	public float DIST_TO_COVER_TO_LAY_SQRT; //Field offset: 0x30
	[Comment("если между землей и травой меньше Х то можно лечь")]
	public float DIST_GRASS_TERRAIN_SQRT; //Field offset: 0x34
	[Comment("Если враг подошел ближе чем Х то обнуляем все точки страха")]
	public float DIST_ENEMY_NULL_DANGER_LAY; //Field offset: 0x38
	[Comment(null)]
	public float DIST_ENEMY_NULL_DANGER_LAY_SQRT; //Field offset: 0x3C
	[Comment("Если враг ближе чем Х то пора вставать")]
	public float DIST_ENEMY_GETUP_LAY; //Field offset: 0x40
	[Comment(null)]
	public float DIST_ENEMY_GETUP_LAY_SQRT; //Field offset: 0x44
	[Comment("Если враг ближе чем Х то запрещает ложится если есть видимый врга ближе чем Х")]
	public float DIST_ENEMY_CAN_LAY; //Field offset: 0x48
	[Comment(null)]
	public float DIST_ENEMY_CAN_LAY_SQRT; //Field offset: 0x4C
	[Comment("На Х умножается коэфициент разлета при прицеливание когда бот лежит.")]
	public float LAY_AIM; //Field offset: 0x50
	[Comment(null)]
	public float MIN_CAN_LAY_DIST_SQRT; //Field offset: 0x54
	[Comment("Если точка напугания была дальше чем Х то бот может попытаться лечь")]
	public float MIN_CAN_LAY_DIST; //Field offset: 0x58
	[Comment(null)]
	public float MAX_CAN_LAY_DIST_SQRT; //Field offset: 0x5C
	[Comment("Если точка напугания была ближе чем Х то бот может попытаться лечь")]
	public float MAX_CAN_LAY_DIST; //Field offset: 0x60
	[Comment("Шанс лечь вместо того что бы убежать (0..100)")]
	public float LAY_CHANCE_DANGER; //Field offset: 0x64
	[Comment(null)]
	public int DAMAGE_TIME_TO_GETUP; //Field offset: 0x68
	[Comment("Будет ли бот вставать когда ему мешает повернуться рельеф")]
	public bool SHALL_GETUP_ON_ROTATE; //Field offset: 0x6C
	[Comment("Может ли бот ложится без проверки")]
	public bool SHALL_LAY_WITHOUT_CHECK; //Field offset: 0x6D
	[Comment("Запрещено ли ложится без наличия врага")]
	public bool IF_NO_ENEMY; //Field offset: 0x6E
	[Comment("Вероятность того, что бот решит лечь, если находится в зоне поражения артиллерии")]
	public int SHALL_LAY_PROBABILTY_WHEN_ARTILLERY; //Field offset: 0x70
	[Comment("Можно ли ложиться в ноде ShootFromPlace")]
	public bool CAN_LAY_AT_SHOOTFROMPLACE; //Field offset: 0x74

	public float DIST_LAY_CHECK
	{
		 get { } //Length: 9
	}

	public BotGlobalLayData() { }

	public float get_DIST_LAY_CHECK() { }

	public void Update() { }

}

