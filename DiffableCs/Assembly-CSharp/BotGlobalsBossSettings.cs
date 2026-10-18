//Type is in global namespace

public class BotGlobalsBossSettings
{
	[Comment("Дистанция ближе которой босс будет предупреждать")]
	public float BOSS_DIST_TO_WARNING; //Field offset: 0x10
	[Comment("Дистанция ближе которой босс будет предупреждать. Только для друзей отряда")]
	public float BOSS_DIST_TO_WARNING_ALLY; //Field offset: 0x14
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT; //Field offset: 0x18
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT_ALLY; //Field offset: 0x1C
	[Comment("Дистанция ближе которой босс будет предупреждать игроков фракции юсек")]
	public float BOSS_DIST_TO_WARNING_USEC; //Field offset: 0x20
	[Comment("Дистанция ближе которой босс будет предупреждать игроков фракции юсек. Только для друзей отряда")]
	public float BOSS_DIST_TO_WARNING_USEC_ALLY; //Field offset: 0x24
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT_USEC; //Field offset: 0x28
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT_USEC_ALLY; //Field offset: 0x2C
	[Comment("Дистанция ближе которой босс будет предупреждать игроков фракции bear")]
	public float BOSS_DIST_TO_WARNING_BEAR; //Field offset: 0x30
	[Comment("Дистанция ближе которой босс будет предупреждать игроков фракции bear. Только для друзей отряда")]
	public float BOSS_DIST_TO_WARNING_BEAR_ALLY; //Field offset: 0x34
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT_BEAR; //Field offset: 0x38
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_SQRT_BEAR_ALLY; //Field offset: 0x3C
	[Comment("Дистанция выйдя за которую босс перестает обращать внимание на дикого")]
	public float BOSS_DIST_TO_WARNING_OUT; //Field offset: 0x40
	[Comment("Дистанция выйдя за которую босс перестает обращать внимание на дикого. Только для друзей отряда")]
	public float BOSS_DIST_TO_WARNING_OUT_ALLY; //Field offset: 0x44
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_OUT_SQRT; //Field offset: 0x48
	[Comment(null)]
	public float BOSS_DIST_TO_WARNING_OUT_SQRT_ALLY; //Field offset: 0x4C
	[Comment("Дистанция ближе которой босс будет стрелять.")]
	public float BOSS_DIST_TO_SHOOT; //Field offset: 0x50
	[Comment("Дистанция ближе которой босс будет стрелять. Только для друзей отряда")]
	public float BOSS_DIST_TO_SHOOT_ALLY; //Field offset: 0x54
	[Comment(null)]
	public float BOSS_DIST_TO_SHOOT_SQRT; //Field offset: 0x58
	[Comment(null)]
	public float BOSS_DIST_TO_SHOOT_SQRT_ALLY; //Field offset: 0x5C
	[Comment(null)]
	public float CHANCE_TO_SEND_GRENADE_100; //Field offset: 0x60
	[Comment("Дистанция до босса, если до от потенциального укрытия больше чем Х то боты будут не будут занимать его.")]
	public float MAX_DIST_COVER_BOSS; //Field offset: 0x64
	[Comment(null)]
	public float MAX_DIST_COVER_BOSS_SQRT; //Field offset: 0x68
	[Comment("Дистанция если враг ближе Х то будет отправленна проверка или запрошен бросок грены")]
	public float MAX_DIST_DECIDER_TO_SEND; //Field offset: 0x6C
	[Comment(null)]
	public float MAX_DIST_DECIDER_TO_SEND_SQRT; //Field offset: 0x70
	[Comment("Через столько после потери из видения босс решала будет отправлять челов на проверку")]
	public float TIME_AFTER_LOSE; //Field offset: 0x74
	[Comment("Но не больше чем Х")]
	public float TIME_AFTER_LOSE_DELTA; //Field offset: 0x78
	[Comment("Столько он попробудет отправить")]
	public int PERSONS_SEND; //Field offset: 0x7C
	[Comment("Через столько он попробует отправить еще раз")]
	public float DELTA_SEARCH_TIME; //Field offset: 0x80
	[Comment("Является ли нахождение всех в укрытиях необходимым условием что бы отправлять на проверку")]
	public bool COVER_TO_SEND; //Field offset: 0x84
	[Comment("Столько босс не будет стрелять во врага дикого пока с ним разбирается свита если этот дикий не стреляет в самого босса")]
	public float WAIT_NO_ATTACK_SAVAGE; //Field offset: 0x88
	[Comment("Шанс что при выборе пути для патрулирования босс выберет Маршрут Отдыха а не основной")]
	public float CHANCE_USE_RESERVE_PATROL_100; //Field offset: 0x8C
	[Comment("время, через которое предупреждение будет считаться завершённым")]
	public float WARN_PLAYER_PERIOD; //Field offset: 0x90
	[Comment("объём регенерации хп в бою за минуту (применяется раз в 3 секунды)")]
	public float EFFECT_REGENERATION_PER_MIN; //Field offset: 0x94
	[Comment("использовать ли обезболивающие на старте")]
	public bool EFFECT_PAINKILLER; //Field offset: 0x98
	[Comment("Игнорировать голод и жажду")]
	public bool DISABLE_METABOLISM; //Field offset: 0x99
	[Comment("Дистанция по высоте в рамках которой игрок считается врагом киллы")]
	public float KILLA_Y_DELTA_TO_BE_ENEMY_BOSS; //Field offset: 0x9C
	[Comment("Дистанция в рамках которой игрок считается врагом киллы")]
	public float KILLA_DITANCE_TO_BE_ENEMY_BOSS; //Field offset: 0xA0
	[Comment("Через сколько секунд босс пойдет искать")]
	public float KILLA_START_SEARCH_SEC; //Field offset: 0xA4
	[Comment("Сколько длиться контузия.")]
	public float KILLA_CONTUTION_TIME; //Field offset: 0xA8
	[Comment("ближняя дистанция")]
	public float KILLA_CLOSE_ATTACK_DIST; //Field offset: 0xAC
	[Comment("средняя дистанция")]
	public float KILLA_MIDDLE_ATTACK_DIST; //Field offset: 0xB0
	[Comment("дальняя дистанция")]
	public float KILLA_LARGE_ATTACK_DIST; //Field offset: 0xB4
	[Comment("для остановки и ожидания поиска дистанция")]
	public float KILLA_SEARCH_METERS; //Field offset: 0xB8
	[Comment("Дистанция для поиска укрытий в режиме защиты")]
	public float KILLA_DEF_DIST_SQRT; //Field offset: 0xBC
	[Comment("Если бот в течении этой дельты никого не нашел и побывал ближе чем KILLA_SEARCH_METERS то он пойдет посидит отдохнет.")]
	public float KILLA_SEARCH_SEC_STOP_AFTER_COMING; //Field offset: 0xC0
	[Comment("Если место с которого надо сапресить дальше чем Х то он не будет сапресить.")]
	public float KILLA_DIST_TO_GO_TO_SUPPRESS; //Field offset: 0xC4
	[Comment("Сколько ждать и не бежать после подавления гранатой")]
	public float KILLA_AFTER_GRENADE_SUPPRESS_DELAY; //Field offset: 0xC8
	[Comment("После скольки штурмов долен настать перерыв")]
	public int KILLA_CLOSEATTACK_TIMES; //Field offset: 0xCC
	[Comment("Длительность перерыва")]
	public float KILLA_CLOSEATTACK_DELAY; //Field offset: 0xD0
	[Comment("Килла базовое время ожидания в укрытии.")]
	public float KILLA_HOLD_DELAY; //Field offset: 0xD4
	[Comment("Если перед набегом на врага пуль меньше чем Х то килла перезарядится")]
	public int KILLA_BULLET_TO_RELOAD; //Field offset: 0xD8
	[Comment("Если перед набегом на врага пуль меньше чем Х то килла перезарядится")]
	public float PERCENT_BULLET_TO_RELOAD; //Field offset: 0xDC
	[Comment("Будет ли босс предупреждать (с учетом дистанции)")]
	public bool SHALL_WARN; //Field offset: 0xE0
	[Comment(null)]
	public int KILLA_ENEMIES_TO_ATTACK; //Field offset: 0xE4
	[Comment("Если враги оказываются на короткой дистанции (менее 30м) босс штурмует их.")]
	public float KILLA_ONE_IS_CLOSE; //Field offset: 0xE8
	[Comment("НАсколько дольше килла зажимает от пролетающих мима пуль")]
	public float KILLA_TRIGGER_DOWN_DELAY; //Field offset: 0xEC
	[Comment("НАсколько дольше килла выглядывает из укрытия")]
	public float KILLA_WAIT_IN_COVER_COEF; //Field offset: 0xF0
	[Comment("Дистанция по высоте в рамках которой игрок считается врагом тагиллы")]
	public float TAGILLA_Y_DELTA_TO_BE_ENEMY_BOSS; //Field offset: 0xF4
	[Comment("квадрат дистанции, с которой тагилле на помощь будут приходить дикие.")]
	public float TAGILLA_SAVAGE_HELP_SQR_DIST; //Field offset: 0xF8
	[Comment("ближняя дистанция с игнорированием безопасности")]
	public float TAGILLA_FORCED_CLOSE_ATTACK_DIST; //Field offset: 0xFC
	[Comment("Если враги оказываются на короткой дистанции (менее 15м) босс штурмует их с бОльшим шансом при срабатывании триггера. Расстояние считается по навмешу!")]
	public float TAGILLA_FIRST_ASSAULT_RADIUS; //Field offset: 0x100
	[Comment("шанс штурма при успешном срабатывании триггера на меньшем радиусе.")]
	public float TAGILLA_FIRST_ASSAULT_CHANCE; //Field offset: 0x104
	[Comment("Если враги оказываются на короткой дистанции (менее 30м) босс штурмует их с меньшим шансом при срабатывании триггера. Расстояние считается по навмешу!")]
	public float TAGILLA_SECOND_ASSAULT_RADIUS; //Field offset: 0x108
	[Comment("шанс штурма при успешном срабатывании триггера на большем радиусе.")]
	public float TAGILLA_SECOND_ASSAULT_CHANCE; //Field offset: 0x10C
	[Comment("квадрат дистанции, начиная с которой Тагилла будет считать врага замеченным, даже если не видел его. В идеале - TAGILLA_CLOSE_ATTACK_DIST")]
	public float TAGILLA_FEEL_ENEMY_DIST_SQR; //Field offset: 0x110
	[Comment("прекратить преследование, если не нанёс удар в течение такого количества секунд")]
	public float TAGILLA_TIME_TO_PURSUIT_WITHOUT_HITS; //Field offset: 0x114
	[Comment("не принимать решение преследовать чаще чем раз в X секунд")]
	public float TAGILLA_MELEE_ATTACK_NEXT_DECISION_PERIOD; //Field offset: 0x118
	[Comment("шанс штурма при перезарядке")]
	public float TAGILLA_MELEE_CHANCE_RELOAD; //Field offset: 0x11C
	[Comment("шанс штурма при использовании предмета")]
	public float TAGILLA_MELEE_CHANCE_INTERACTION; //Field offset: 0x120
	[Comment("шанс штурма при использовании инвентаря")]
	public float TAGILLA_MELEE_CHANCE_INVENTORY; //Field offset: 0x124
	[Comment("шанс штурма при использовании аптечки")]
	public float TAGILLA_MELEE_CHANCE_MEDS; //Field offset: 0x128
	[Comment("шанс штурма при близком приближении")]
	public float TAGILLA_MELEE_CHANCE_FORCED; //Field offset: 0x12C
	[Comment("минимальное время между окончанием предыдущего штурма и началом следующего")]
	public float TAGILLA_MIN_TIME_TO_REPEAT_MELEE_ASSAULT; //Field offset: 0x130
	[Comment("дистанция хотя бы 1 врага до лута меньше чем Х когда все заняли позиции то атаковать")]
	public float KOJANIY_DIST_WHEN_READY; //Field offset: 0x134
	[Comment("дляу учета количества врагов учитывается этот радиус.")]
	public float KOJANIY_DIST_TO_BE_ENEMY; //Field offset: 0x138
	[Comment("Дистанция до лута что бы можно было атаковать")]
	public float KOJANIY_MIN_DIST_TO_LOOT; //Field offset: 0x13C
	[Comment(null)]
	public float KOJANIY_MIN_DIST_TO_LOOT_SQRT; //Field offset: 0x140
	[Comment("Если враг подошел ближе чем Х к свите/боссу то атаковать.")]
	public float KOJANIY_DIST_ENEMY_TOO_CLOSE; //Field offset: 0x144
	[Comment("Коэфициент допуска к луту по дистанции для врагов больше 1")]
	public float KOJANIY_MANY_ENEMIES_COEF; //Field offset: 0x148
	[Comment("Стартовая позиция при драки - true- отсчитывается от бота. false- отсчитывается от Позции для окружения игрока")]
	public bool KOJANIY_FIGHT_CENTER_POS_ME; //Field offset: 0x14C
	[Comment("Дистанция для пересчета. Если последняя точка пересчета больше чем Х относительно новой.")]
	public float KOJANIY_DIST_CORE_SPOS_RECALC; //Field offset: 0x150
	[Comment(null)]
	public float KOJANIY_DIST_CORE_SPOS_RECALC_SQRT; //Field offset: 0x154
	[Comment("Через сколько кожаный или один из помошников после потери цели из виду дадут выстрелов")]
	public float KOJANIY_START_SUPPERS_SHOOTS_SEC; //Field offset: 0x158
	[Comment("Через сколько после первого ложного обстрела можно будет начать второй")]
	public float KOJANIY_START_NEXT_SUPPERS_SHOOTS_SEC; //Field offset: 0x15C
	[Comment("если врагов строго больше чем Х то будет использованна защитная тактика")]
	public int KOJANIY_SAFE_ENEMIES; //Field offset: 0x160
	[Comment("Через сколько секунд после пропадения из виду боссу/фолловеру становится пох на врага.")]
	public float KOJANIY_TAKE_CARE_ABOULT_ENEMY_DELTA; //Field offset: 0x164
	[Comment("Через сколько секунд после пропадения из виду боссу/фолловеру пойдут в ближайшее укрытие")]
	public float KOJANIY_WANNA_GO_TO_CLOSEST_COVER; //Field offset: 0x168
	[Comment("название желаемого типа пути")]
	public string GLUHAR_FOLLOWER_PATH_NAME; //Field offset: 0x170
	[Comment(null)]
	public float GLUHAR_FOLLOWER_SCOUT_DIST_START_ATTACK; //Field offset: 0x178
	[Comment(null)]
	public float GLUHAR_FOLLOWER_SCOUT_DIST_END_ATTACK; //Field offset: 0x17C
	[Comment(null)]
	public float GLUHAR_BOSS_WANNA_ATTACK_CHANCE_0_100; //Field offset: 0x180
	[Comment("Дистанция ДО босса с которой можно атаковать ассаутерам.")]
	public float GLUHAR_ASSAULT_ATTACK_DIST; //Field offset: 0x184
	[Comment("Дистанция если првевысить её то асаутеры перестанут атаковать")]
	public float GLUHAR_STOP_ASSAULT_ATTACK_DIST; //Field offset: 0x188
	[Comment(null)]
	public float GLUHAR_TIME_TO_ASSAULT; //Field offset: 0x18C
	[Comment("Если бот должен охранять босса, но в текщем укрытии дистанция больше чем Х     то он постарается поменять укртие на поближе")]
	public float DIST_TO_PROTECT_BOSS; //Field offset: 0x190
	[Comment("Через какое время босс проверит и захочет вызвать подкрепу . Если <0 то не работает")]
	public float GLUHAR_SEC_TO_REINFORSMENTS; //Field offset: 0x194
	[Comment("Может ли глухать вызывать подкрепу по этим ивентам")]
	public bool GLUHAR_REINFORSMENTS_BY_EXIT; //Field offset: 0x198
	[Comment("Может ли глухать вызывать подкрепу по этим ивентам")]
	public bool GLUHAR_REINFORSMENTS_BY_EVENT; //Field offset: 0x199
	[Comment("Может ли глухать вызывать подкрепу по этим ивентам")]
	public bool GLUHAR_REINFORSMENTS_BY_PLAYER_COME_TO_ZONE; //Field offset: 0x19A
	[Comment("Если фоловеров меньше чем Х то можно вызывать подкрепу   . Если <0 то не работает")]
	public int GLUHAR_FOLLOWERS_TO_REINFORSMENTS; //Field offset: 0x19C
	[Comment("Целевое кол-во по роли")]
	public int GLUHAR_FOLLOWERS_SECURITY; //Field offset: 0x1A0
	[Comment("Целевое кол-во по роли")]
	public int GLUHAR_FOLLOWERS_ASSAULT; //Field offset: 0x1A4
	[Comment("Целевое кол-во по роли")]
	public int GLUHAR_FOLLOWERS_SCOUT; //Field offset: 0x1A8
	[Comment("Целевое кол-во по роли")]
	public int GLUHAR_FOLLOWERS_SNIPE; //Field offset: 0x1AC
	[Comment("Дистанция до босса когда он начинает хотеть идти убивать если штурмовики дереться")]
	public float GLUHAR_BOSS_DIST_TO_ENEMY_WANT_KILL; //Field offset: 0x1B0
	[Comment("Сколько секунд отходить в укрытия если тебя концули и враг не виден   ")]
	public float IF_I_HITTED_GO_AWAY_SEC_HIT; //Field offset: 0x1B4
	[Comment("На сколько бот должен отстать от боса что бы перейти на бег если он использует передвижение с остановками.")]
	public float DIST_TO_START_RUN_FOR_COVER_WITH_STOP; //Field offset: 0x1B8
	[Comment("На сколько оставшаяся дистанция пути бота должна отличаться от оставшийся дистанции босса что бы он мог перейти на бег если он использует передвижение с остановками.")]
	public float DELTA_DIST_DEST_BOSS_START_RUN_FOR_COVER_WITH_STOP; //Field offset: 0x1BC
	[Comment("Использовать только точки со стрельбой")]
	public bool SANITAR_ONLY_FIGHT_COVERS; //Field offset: 0x1C0
	[Comment("Тактика 2 укрытий")]
	public bool SANITAR_TWO_COVER_TACTIC; //Field offset: 0x1C1
	[Comment("Если фоловров меньше чем Х то предупреждать не будут")]
	public int COUNT_FOLLOWERS_TO_WARN; //Field offset: 0x1C4
	[Comment("Может ли босс при тактике укрытий использовать кусты")]
	public bool RUN_HIDE_CAN_USE_TREE_COVRES; //Field offset: 0x1C8
	[Comment("Если расстояния меньше Х то будет игнорироваться видимость врага для атаки ножом")]
	public float SECTANT_INDOOR_DIST_NOT_TO_ATTACK; //Field offset: 0x1CC
	[Comment("При добавлении бота во враги из-за пересечения радиуса босса, даёт читерную видимость на кадр")]
	public bool SET_CHEAT_VISIBLE_WHEN_ADD_TO_ENEMY; //Field offset: 0x1D0
	[Comment("Сколько надо прстоять в круге что бы стать врагом")]
	public float TOTAL_TIME_KILL; //Field offset: 0x1D4
	[Comment("Через столько после предупрежедния станет врагом     ")]
	public float TOTAL_TIME_KILL_AFTER_WARN; //Field offset: 0x1D8
	[Comment("После скольки пересечений границы круга чел будет атакован")]
	public int COME_INSIDE_TIMES; //Field offset: 0x1DC
	[Comment("Насколько метров надо отойти от начала предупреждания ботов что бы он прекратил предупреждать")]
	public float BOSS_DIST_TO_WARNING_OUT_DELTA; //Field offset: 0x1E0
	[Comment("Насколько метров надо отойти от начала предупреждания ботов что бы он прекратил предупреждать. Только для друзей")]
	public float BOSS_DIST_TO_WARNING_OUT_DELTA_ALLY; //Field offset: 0x1E4
	[Comment("ЧЕрез сколько сек после первого дейтсивя педупреждения будет становится враго")]
	public float TOTAL_TIME_KILL_AFTER_START_WARN; //Field offset: 0x1E8
	[Comment("Сколько врагов видно что бы попытатья поливать гранатометом")]
	public int BIG_PIPE_ARTILLERY_COUNT; //Field offset: 0x1EC
	[Comment("Шанс что босс вместо перемещения лежа будет телепортироваться")]
	public float BOSS_ZRYACHIY_TELEPORT_CHANCE; //Field offset: 0x1F0
	[Comment("минимальная дистанция до фрага что бы можно было телепортироватся")]
	public float BOSS_ZRYACHIY_MIN_DIST_TO_TELEPORT; //Field offset: 0x1F4
	[Comment("сколько секунд проходит с рождения бота что бы можно было телепортироватся")]
	public float BOSS_ZRYACHIY_TELEPORT_CAN_SECONDS_FROM_START; //Field offset: 0x1F8
	[Comment("минимальная дистанция для выбора следущего укрытия")]
	public float BOSS_ZRYACHIY_MIN_DIST_TO_NEXT_COVER; //Field offset: 0x1FC
	[Comment("минимальный уровень тумана что бы можно было перепортиться")]
	public float BOSS_ZRYACHIY_POSSIBLE_FOG; //Field offset: 0x200
	[Comment("если стоит в тру то не будет добавлять во врагов при убийстве других ботов")]
	public bool NOT_ADD_TO_ENEMY_ON_KILLS; //Field offset: 0x204
	[Comment("Босс может отправлять реквесты самому себе и исполнять их. На случай, если боссу нужна логика из реквестов")]
	public bool ALLOW_REQUEST_SELF; //Field offset: 0x205
	[Comment("Если враг стрелял более чем Х сек давно то тагилла может атаковать в мили")]
	public float TAGILLA_MELEE_ATTACK_IF_NO_SHOOT; //Field offset: 0x208
	[Comment("Для БД шанс перейти в ассаул, или во подавление")]
	public float BLACK_DIVISION_CHANCE_ASSAULT; //Field offset: 0x20C

	public BotGlobalsBossSettings() { }

	public void Update() { }

}

