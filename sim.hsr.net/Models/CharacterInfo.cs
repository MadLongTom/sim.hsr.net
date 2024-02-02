using Newtonsoft.Json;
using sim.hsr.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sim.hsr.net.Models.CharacterInfo;

namespace sim.hsr.net.Models
{
    internal record CharacterInfo
    {
        // Root myDeserializedrecord = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public record AbilityInherentTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record AbilityList
        {
            public string Name { get; set; }
            public TargetInfo TargetInfo { get; set; }
            public DelimitedList<OnStart> OnStart { get; set; }
            public DynamicValues DynamicValues { get; set; }
            public Dictionary<string, GlobalModifiers> Modifiers { get; set; }
        }

        public record AbilityTarget
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record AddRatio
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record AimOffset
        {
            public int X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public record AimTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record AnchorOffset
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public record AttackProperty
        {
            public string DamageType { get; set; }
            public DamagePercentage DamagePercentage { get; set; }
            public StanceValue StanceValue { get; set; }
            public SPHitRatio SPHitRatio { get; set; }
            public string HitAnimation { get; set; }
            public string HitEffect { get; set; }
            public double HitEffectHeight { get; set; }
            public int HitAngleVertical { get; set; }
        }

        public record BlendConfig
        {
            public string BlendType { get; set; }
            public string CustomCurveName { get; set; }
            public double? BlendTime { get; set; }
        }

        public record CallbackConfig
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public TargetType TargetType { get; set; }
            public string ModifierName { get; set; }
            public string Active { get; set; }
            public int? BarType { get; set; }
            public string CurrentState { get; set; }
            public string IconPath { get; set; }
            public MaxCount MaxCount { get; set; }
            public CurrentCount CurrentCount { get; set; }
            public Predicate Predicate { get; set; }
            public DelimitedList<SuccessTaskList> SuccessTaskList { get; set; }
            public LifeTime LifeTime { get; set; }
            public MaxLayer MaxLayer { get; set; }
            public LayerAddWhenStack LayerAddWhenStack { get; set; }
            public DynamicValues DynamicValues { get; set; }
            public ReadTargetType ReadTargetType { get; set; }
            public string ValueType { get; set; }
            public Multiplier Multiplier { get; set; }
            public string DynamicKey { get; set; }
            public Value Value { get; set; }
            public string Property { get; set; }
            public PropertyValue PropertyValue { get; set; }
            public DelimitedList<FailedTaskList> FailedTaskList { get; set; }
        }

        public record CallbackList
        {
            public string Event { get; set; }
            public DelimitedList<CallbackConfig> CallbackConfig { get; set; }
        }

        public record CameraConfig
        {
            public NormalConfig NormalConfig { get; set; }
            public BlendConfig BlendConfig { get; set; }
            public ShowEntityConfig ShowEntityConfig { get; set; }
        }

        public record CompareValue
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record Count
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record CurrentCount
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record CustomCenterTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record DamagePercentage
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record DisplayData
        {
            public double UIMessageHeight { get; set; }
            public double DitherRangeX { get; set; }
            public double DitherRangeY { get; set; }
            public string AttachPoint { get; set; }
        }

        public record DynamicValues
        {
            public MDFPropertyValue MDF_PropertyValue { get; set; }
            public MDFLifeTime MDF_LifeTime { get; set; }
            public MDFHPIncrease2 MDF_HPIncrease2 { get; set; }
            //public Values Values { get; set; }
            public MDFHPIncrease MDF_HPIncrease { get; set; }
            public MDFAttackUpRatio MDF_AttackUpRatio { get; set; }
            public MDFDamageResistance MDF_DamageResistance { get; set; }
            public MDFHealPercentage2 MDF__HealPercentage2 { get; set; }
            public MDFHealValue2 MDF__HealValue2 { get; set; }
            public MDFAddSP MDF_AddSP { get; set; }
            public MDFHealCount MDF_HealCount { get; set; }
            public MDFHealCountExtra MDF_HealCountExtra { get; set; }
        }

        public record FailedTaskList
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string DynamicKey { get; set; }
            public Value Value { get; set; }
            public string Active { get; set; }
            public int? BarType { get; set; }
            public string CurrentState { get; set; }
            public string IconPath { get; set; }
            public MaxCount MaxCount { get; set; }
            public CurrentCount CurrentCount { get; set; }
            public Predicate Predicate { get; set; }
            public DelimitedList<SuccessTaskList> SuccessTaskList { get; set; }
            //public DelimitedList<FailedTaskList> FailedTaskList { get; set; }
            public TargetType TargetType { get; set; }
            public string ModifierName { get; set; }
            public bool? LifeStepImmediately { get; set; }
            public LifeTime LifeTime { get; set; }
            public DynamicValues DynamicValues { get; set; }
            public string VOType { get; set; }
            public bool AliveOnly { get; set; }
            public string AbilityName { get; set; }
            public AbilityTarget AbilityTarget { get; set; }
            public DelimitedList<string> AbortBehaviorFlags { get; set; }
            public string InsertAbilityPriority { get; set; }
            public string TargetAliveState { get; set; }
            public bool? ShowInActionBar { get; set; }
            public PreCheck PreCheck { get; set; }
        }

        public record FirstTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record FixedAddValue
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record FixedValue
        {
            public double Value { get; set; }
        }

        public record FixedValue11
        {
            public double Value { get; set; }
        }

        public record HealPercentage
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record LayerAddWhenStack
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record LifeTime
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record GlobalModifiers
        {
            public bool UseSnapshotEntity { get; set; }
            public DelimitedList<CallbackList> _CallbackList { get; set; }
            public int Count { get; set; }
            public string Stacking { get; set; }
            public DynamicValues DynamicValues { get; set; }
            public DelimitedList<PriorityList> _PriorityList { get; set; }
        }

        public record MaxCount
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MaxLayer
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MaxLoopCount
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFAddSP
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFAttackUpRatio
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFDamageResistance
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHealCount
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHealCountExtra
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHealPercentage2
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHealValue2
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHPIncrease
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFHPIncrease2
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFLifeTime
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MDFPropertyValue
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }
        /*
        public record Modifiers
        {
            public MAvatarBailu00DieEvent MAvatar_Bailu_00_DieEvent { get; set; }
            public MAvatarBailu00ReviveEvent MAvatar_Bailu_00_ReviveEvent { get; set; }
            public StageAbilityMazeBailu00Modifier StageAbility_Maze_Bailu_00_Modifier { get; set; }
            
        }*/
    
        public record ModifyValue
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record MovingRangeList
        {
            public TargetType TargetType { get; set; }
            public OffsetTargetDistance OffsetTargetDistance { get; set; }
            public NormalizedTimeStart NormalizedTimeStart { get; set; }
            public NormalizedTimeEnd NormalizedTimeEnd { get; set; }
        }

        public record Multiplier
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record NormalConfig
        {
            public string CameraState { get; set; }
            public bool IsLocalOffset { get; set; }
            public AnchorOffset AnchorOffset { get; set; }
            public AimTargetType AimTargetType { get; set; }
            public AimOffset AimOffset { get; set; }
            public int FollowPoleAngle { get; set; }
            public double FollowRadius { get; set; }
            public int FOV { get; set; }
            public double? FollowDamp { get; set; }
            public double? AimDamp { get; set; }
        }

        public record NormalizedTimeEnd
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record NormalizedTimeStart
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record NormalizedTimeWait
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record NormalizedTransitionDuration
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record OffsetTargetDistance
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record OnProjectileHit
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public TargetType TargetType { get; set; }
            public string FormulaType { get; set; }
            public HealPercentage HealPercentage { get; set; }
            public ModifyValue ModifyValue { get; set; }
            public DisplayData DisplayData { get; set; }
        }

        public record OnStart
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public object TargetType { get; set; }
            public string AbilityName { get; set; }
            public bool IsSkillPerform { get; set; }
            public string AnimStateName { get; set; }
            public DelimitedList<MovingRangeList> MovingRangeList { get; set; }
            public NormalizedTimeEnd NormalizedTimeEnd { get; set; }
            public AttackProperty AttackProperty { get; set; }
            public bool? CanTriggerLastKill { get; set; }
            public AbilityInherentTargetType AbilityInherentTargetType { get; set; }
            public NormalizedTimeWait NormalizedTimeWait { get; set; }
            public double? WaitTime { get; set; }
            public OffsetTargetDistance OffsetTargetDistance { get; set; }
            public bool? IsSync { get; set; }
            public string Team { get; set; }
            public string FormationType { get; set; }
            public string FormationConfigName { get; set; }
            public string EffectPath { get; set; }
            public Predicate Predicate { get; set; }
            public DelimitedList<SuccessTaskList> SuccessTaskList { get; set; }
            public object MaxNumber { get; set; }
            public Projectile Projectile { get; set; }
            public DelimitedList<OnProjectileHit> OnProjectileHit { get; set; }
            public bool? WaitProjectileFinish { get; set; }
            public string DynamicKey { get; set; }
            public Value Value { get; set; }
            public DelimitedList<TaskList> TaskList { get; set; }
            public MaxLoopCount MaxLoopCount { get; set; }
            public AddRatio AddRatio { get; set; }
            public DelimitedList<FailedTaskList> FailedTaskList { get; set; }
            public string AnimLogicState { get; set; }
            public string CustomFormationName { get; set; }
            public CameraConfig CameraConfig { get; set; }
            public bool? IsHide { get; set; }
            public CustomCenterTargetType CustomCenterTargetType { get; set; }
            public string NotifyTypeName { get; set; }
            public string TimelineName { get; set; }
            public bool? IsShow { get; set; }
            public string FormulaType { get; set; }
            public HealPercentage HealPercentage { get; set; }
            public ModifyValue ModifyValue { get; set; }
            public DisplayData DisplayData { get; set; }
            public string ModifierName { get; set; }
            public Count Count { get; set; }
        }

        public record PointTriggerKey
        {
            public int Hash { get; set; }
        }

        public record PostfixExpr
        {
            public string OpCodes { get; set; }
            public DelimitedList<object> FixedValues { get; set; }
            public DelimitedList<int> DynamicHashes { get; set; }
        }

        public record PreCheck
        {
            public string Type { get; set; }
            public Count Count { get; set; }
        }

        public record Predicate
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public TriggerKey TriggerKey { get; set; }
            public TargetType TargetType { get; set; }
            public string CompareType { get; set; }
            public CompareValue CompareValue { get; set; }
            public DelimitedList<PredicateList> PredicateList { get; set; }
            public string DynamicKey { get; set; }
            public string ModifierName { get; set; }
            public PointTriggerKey PointTriggerKey { get; set; }
            public string Team { get; set; }
        }

        public record PredicateList
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string ModifierName { get; set; }
            public TargetType TargetType { get; set; }
            public bool? Inverse { get; set; }
            public string CompareType { get; set; }
            public CompareValue CompareValue { get; set; }
            public FirstTargetType FirstTargetType { get; set; }
            public bool FirstTargetAliveOnly { get; set; }
            public SecondTargetType SecondTargetType { get; set; }
            public bool SecondTargetAliveOnly { get; set; }
            public string Flag { get; set; }
            public string DynamicKey { get; set; }
            public string ContextScope { get; set; }
        }

        public record PriorityList
        {
            public string PriorityName { get; set; }
            public string Key { get; set; }
        }

        public record Projectile
        {
            public double FlyTime { get; set; }
            public string TargetAttachPoint { get; set; }
            public bool IgnoreTargetHitbox { get; set; }
            public bool StartFromLastHitPos { get; set; }
            public TargetOffset TargetOffset { get; set; }
            public string FlyEffect { get; set; }
            public string HitEffect { get; set; }
            public bool FlyEffectFadeOut { get; set; }
            public bool WriteProgressToEffectAnimator { get; set; }
            public StartOffsetRange StartOffsetRange { get; set; }
        }

        public record PropertyValue
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record ReadTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record Root
        {
            public DelimitedList<AbilityList> AbilityList { get; set; }
            //public GlobalModifiers GlobalModifiers { get; set; }
            public Dictionary<string,GlobalModifiers> GlobalModifiers { get; set; }
        }

        public record SecondTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record ShowEntityConfig
        {
            public ShowTargetType ShowTargetType { get; set; }
        }

        public record ShowTargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record SPHitRatio
        {
            public bool IsDynamic { get; set; }
            public FixedValue FixedValue { get; set; }
        }

        public record StanceValue
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
        }

        public record StartOffsetRange
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double Z { get; set; }
        }

        public record SuccessTaskList
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public TargetType TargetType { get; set; }
            public string ModifierName { get; set; }
            public LifeTime LifeTime { get; set; }
            public DynamicValues DynamicValues { get; set; }
            public string DynamicKey { get; set; }
            public Value Value { get; set; }
            public string ModifyFunction { get; set; }
            public AbilityInherentTargetType AbilityInherentTargetType { get; set; }
            public string AbilityName { get; set; }
            public bool? IsSkillPerform { get; set; }
            public string UIPrefabPath { get; set; }
            public TitleTextID TitleTextID { get; set; }
            public string AnimStateName { get; set; }
            public NormalizedTimeEnd NormalizedTimeEnd { get; set; }
            public string EffectPath { get; set; }
            public string TimelineName { get; set; }
            public string AnimLogicState { get; set; }
            public bool? OnlyAlive { get; set; }
            public bool? IsSlientDispel { get; set; }
            public bool? AliveOnly { get; set; }
            public string FormulaType { get; set; }
            public HealPercentage HealPercentage { get; set; }
            public ModifyValue ModifyValue { get; set; }
            public DisplayData DisplayData { get; set; }
            public Predicate Predicate { get; set; }
            //public DelimitedList<SuccessTaskList> SuccessTaskList { get; set; }
            public DelimitedList<FailedTaskList> FailedTaskList { get; set; }
            public bool? IgnoreRadius { get; set; }
            public OffsetTargetDistance OffsetTargetDistance { get; set; }
            public FixedAddValue FixedAddValue { get; set; }
            public int? MinMutexTime { get; set; }
            public string MutexType { get; set; }
            public NormalizedTransitionDuration NormalizedTransitionDuration { get; set; }
            public bool ForceStart { get; set; }
            public Multiplier Multiplier { get; set; }
            public string Active { get; set; }
            public int? BarType { get; set; }
            public string CurrentState { get; set; }
            public string IconPath { get; set; }
            public MaxCount MaxCount { get; set; }
            public CurrentCount CurrentCount { get; set; }
            public string ValueType { get; set; }
            public bool? OnlyRemoveCasterAdded { get; set; }
        }

        public record Target
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
        }

        public record TargetInfo
        {
            public string TargetType { get; set; }
        }

        public record TargetOffset
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double Z { get; set; }
        }

        public record TargetType
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string Alias { get; set; }
            public DelimitedList<Target> Targets { get; set; }
        }

        public record TaskList
        {
            [JsonProperty("$type")]
            public string type { get; set; }
            public string DynamicKey { get; set; }
            public Value Value { get; set; }
            public TargetType TargetType { get; set; }
            public object MaxNumber { get; set; }
            public Projectile Projectile { get; set; }
            public DelimitedList<OnProjectileHit> OnProjectileHit { get; set; }
            public bool? WaitProjectileFinish { get; set; }
            public double? WaitTime { get; set; }
            //public DelimitedList<TaskList> TaskList { get; set; }
            public Predicate Predicate { get; set; }
            public DelimitedList<SuccessTaskList> SuccessTaskList { get; set; }
            public DelimitedList<FailedTaskList> FailedTaskList { get; set; }
        }

        public record TitleTextID
        {
            public int Hash { get; set; }
        }

        public record TriggerKey
        {
            public int Hash { get; set; }
        }

        public record Value
        {
            public bool IsDynamic { get; set; }
            public PostfixExpr PostfixExpr { get; set; }
            public FixedValue FixedValue { get; set; }
        }
    }
}
