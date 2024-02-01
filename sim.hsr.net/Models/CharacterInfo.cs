using sim.hsr.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sim.hsr.net.Models.CharacterInfo;

namespace sim.hsr.net.Models
{
    internal class CharacterInfo
    {
        public class TargetInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public string TargetType { get; set; }
        }

        public class OnStartItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string TargetType { get; set; }
        }

        public class AbilityListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public TargetInfo TargetInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<OnStartItem> OnStart { get; set; }
        }

        public class UIConfig
        {
            /// <summary>
            /// 
            /// </summary>
            public string UIPosition { get; set; }
        }

        public class MAvatar_Kafka_00_Passive_CanAttackCD
        {
            /// <summary>
            /// 
            /// </summary>
            public int LifeTime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public UIConfig UIConfig { get; set; }
        }

        public class TargetType
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string @Alias { get; set; }
        }

        public class Predicate
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public TargetType TargetType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Team { get; set; }
        }

        public class TargetType
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string @Alias { get; set; }
        }

        public class SuccessTaskListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public TargetType TargetType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ModifierName { get; set; }
        }

        public class CallbackConfigItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Predicate Predicate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<SuccessTaskListItem> SuccessTaskList { get; set; }
        }

        public class _CallbackListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string @Event { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<CallbackConfigItem> CallbackConfig { get; set; }
        }

        public class MAvatar_Kafka_00_Rank04
        {
            /// <summary>
            /// 
            /// </summary>
            public List<_CallbackListItem> _CallbackList { get; set; }
        }

        public class PredicateListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> AttackTypes { get; set; }
        }

        public class Predicate
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<PredicateListItem> PredicateList { get; set; }
        }

        public class TargetType
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string @Alias { get; set; }
        }

        public class PostfixExpr
        {
            /// <summary>
            /// 
            /// </summary>
            public string OpCodes { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> FixedValues { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<int> DynamicHashes { get; set; }
        }

        public class AddValue
        {
            /// <summary>
            /// 
            /// </summary>
            public string IsDynamic { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public PostfixExpr PostfixExpr { get; set; }
        }

        public class SuccessTaskListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public TargetType TargetType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public AddValue AddValue { get; set; }
        }

        public class CallbackConfigItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string _type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Predicate Predicate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<SuccessTaskListItem> SuccessTaskList { get; set; }
        }

        public class _CallbackListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string @Event { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<CallbackConfigItem> CallbackConfig { get; set; }
        }

        public class MAvatar_Kafka_00_Rank04_Sub
        {
            /// <summary>
            /// 
            /// </summary>
            public List<string> BehaviorFlagList { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<_CallbackListItem> _CallbackList { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Stacking { get; set; }
        }

        public class GlobalModifiers
        {
            /// <summary>
            /// 
            /// </summary>
            public MAvatar_Kafka_00_Passive_CanAttackCD MAvatar_Kafka_00_Passive_CanAttackCD { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public MAvatar_Kafka_00_Rank04 MAvatar_Kafka_00_Rank04 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public MAvatar_Kafka_00_Rank04_Sub MAvatar_Kafka_00_Rank04_Sub { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public List<AbilityListItem> AbilityList { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public GlobalModifiers GlobalModifiers { get; set; }
        }

    }
}
