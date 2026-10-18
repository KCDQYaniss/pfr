//Type is in global namespace

public class BotGlobalsMoveSettings
{
	[Comment("degree per second")]
	public float BASE_ROTATE_SPEED; //Field offset: 0x10
	[Comment("Дистанция меньше которой бот считает что он пришел в точку назначения")]
	public float REACH_DIST; //Field offset: 0x14
	[Comment("Дистанция меньше которой бот считает что он пришел в точку назначения при беге")]
	public float REACH_DIST_RUN; //Field offset: 0x18
	[Comment("Дистанция на которой бот начинает замедлятся когда приближается к точке конц маршрута")]
	public float START_SLOW_DIST; //Field offset: 0x1C
	[Comment("Если не было указано чо надозамедлятся в конце то коэфиц замедления такой")]
	public float BASESTART_SLOW_DIST; //Field offset: 0x20
	[Comment("Коэфициент замедления")]
	public float SLOW_COEF; //Field offset: 0x24
	[Comment("Никогда не останавливаться при патруле One by one")]
	public bool ONE_BY_ONE_NEVER_STOP; //Field offset: 0x28
	[Comment("Дистанция на которой")]
	public float DIST_TO_CAN_CHANGE_WAY; //Field offset: 0x2C
	[Comment("Дистанция с которой начинаются попытки увидеть точку опастности")]
	public float DIST_TO_START_RAYCAST; //Field offset: 0x30
	[Comment("Базовый радиус круга поиска точек укрытия для продвижения к точке апостности")]
	public float BASE_START_SERACH; //Field offset: 0x34
	[Comment("Частота перерасчета пути то точки назначения")]
	public float UPDATE_TIME_RECAL_WAY; //Field offset: 0x38
	[Comment("Дистанция до точки что бы начать бежать к ней")]
	public float FAR_DIST; //Field offset: 0x3C
	[Comment("    public float NEAR_DIST_SQR;")]
	public float FAR_DIST_SQR; //Field offset: 0x40
	[Comment(null)]
	public float DIST_TO_CAN_CHANGE_WAY_SQR; //Field offset: 0x44
	[Comment(null)]
	public float DIST_TO_START_RAYCAST_SQR; //Field offset: 0x48
	[Comment(null)]
	public float BASE_SQRT_START_SERACH; //Field offset: 0x4C
	[Comment("Если точка до который идет меьше чем Х по У то она срежется до 0")]
	public float Y_APPROXIMATION; //Field offset: 0x50
	[Comment("по бот идет и если время видения последнего места врага то меньше Х то он будет смотреть туда")]
	public float DELTA_LAST_SEEN_ENEMY; //Field offset: 0x54
	[Comment("если новое укрыти которое нашел бот ближе чем Х то бт ужэе счиатет что он в укрытии")]
	public float REACH_DIST_COVER; //Field offset: 0x58
	[Comment(" Если бот бежит к точке то если до дистанции было меньше чем Х то бот перейдет на шаг")]
	public float RUN_TO_COVER_MIN; //Field offset: 0x5C
	[Comment("Вероятность того что бот будет бегать когда у него закончатся патроны и он вне укрытия")]
	public float CHANCE_TO_RUN_IF_NO_AMMO_0_100; //Field offset: 0x60
	[Comment("Если я не вижу врага то я буду убегать если у меня состояние Ambush")]
	public bool RUN_IF_CANT_SHOOT; //Field offset: 0x64
	[Comment("Бежать можно если враг дальше чем Х метров")]
	public float RUN_IF_GAOL_FAR_THEN; //Field offset: 0x68
	[Comment("Через сколько секунд после начала движения со стрельбой будет совершена проверка на возможность убежать")]
	public float SEC_TO_CHANGE_TO_RUN; //Field offset: 0x6C
	[Comment(null)]
	public bool ETERNITY_STAMINA; //Field offset: 0x70
	public bool STOP_SPRINT_AT_TREE; //Field offset: 0x71
	[Comment("Сколько ждать анимации двери")]
	public float WAIT_DOOR_OPEN_SEC; //Field offset: 0x74
	[Comment("Шанс на открывание двери с ноги    ")]
	public float BREACH_CHANCE_100; //Field offset: 0x78
	[Comment("Скорость первого поворота при менее 90 градусов")]
	public float FIRST_TURN_SPEED; //Field offset: 0x7C
	[Comment("Скорость первого поворота при более 90 градусов")]
	public float FIRST_TURN_BIG_SPEED; //Field offset: 0x80
	[Comment("Скорость поворота при спринте")]
	public float TURN_SPEED_ON_SPRINT; //Field offset: 0x84
	[Comment("Отключает переделку пути в зиг-заг")]
	public bool NO_ZIG_ZAG; //Field offset: 0x88
	[Comment("может ли спринтовать когда идет в ноде GoToSomepoint")]
	public bool CAN_SPRINT_GO_TO_SOME_POINT; //Field offset: 0x89
	[Comment("до какой дистанции может спринтовать")]
	public float DIST_SPRINT_GO_TO_SOME_POINT; //Field offset: 0x8C
	[Comment("Мили атака в зиг заге")]
	public bool MELEE_ATTACK_ZIG_ZAG; //Field offset: 0x90
	[Comment("Мили атака будт реже пересчитывать путь")]
	public bool MELEE_ATTACK_OPTIMIZE; //Field offset: 0x91
	[Comment("Отключить локальное расталкивание ботов")]
	public bool DISABLE_LOCAL_AVOIDANCE; //Field offset: 0x92
	[Comment("Расстояние, с которого боты переходят на спринт при типе патруля OneByOne")]
	public float ONE_BY_ONE_SPRINT_BEGIN_DIST; //Field offset: 0x94
	[Comment("Расстояние, с которого боты выходят из спринта при типе патруля OneByOne")]
	public float ONE_BY_ONE_SPRINT_FINISH_DIST; //Field offset: 0x98
	[Comment("Принудительно устанавливать SetTargetMoveSpeed(1f) в one by one атруле")]
	public bool ONE_BY_ONE_FORCE_MOVE_SPEED; //Field offset: 0x9C

	public BotGlobalsMoveSettings() { }

	public void Update() { }

}

