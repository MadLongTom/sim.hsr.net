# Simulator.Honkai:StarRail.NET
**This repo is under establishment. If you are interested in this project, it is welcomed to collabrate!**
## Plan
1. Build the basic battle framework in the ConsoleApplication
2. Refactor ConsoleApplication into WebApplication
## Features
- [ ] Battle Simulation based on game metadata
- [ ] Build ML model based on simulation results
- [ ] Interact with game in realtime and select the optimal solution to the dungeon through the ML model
## Milestones
- [x] Collect metadata (thanks to https://github.com/Dimbreath/StarRailData)
- [ ] **ONGOING** Create character database 
- [ ] Create battle framework
- [ ] Implenment battle AI
- [ ] ML Training
to be added...
## Designs
### Battle framework
#### Inclusion
Battle[Wave[Round[Character[Skill[Hit?Buff?Heal?]]]]]
#### Damage Calc Algo
```math
$$ATK*AMP*(1+\sum DamageBuff)*(1+Critical)*(1-\sum DamageDebuff)*(1+\sum VulnerableBuff)*(1-(Resistance-Penetration))*DefenseEffect$$
```
#### GameEvent (Exported from game config)
<details> <summary>Expand</summary>
OnActionEnd
OnAfterAttack
OnAfterBeingAttacked
OnAfterBeingAttackedEnd
OnAfterBeingHeal
OnAfterBeingHit
OnAfterBeingHitAll
OnAfterCharmAction
OnAfterHit
OnAfterSkillUse
OnAllowAction
OnBeforeAttack
OnBeforeBeingAttacked
OnBeforeBeingHeal
OnBeforeBeingHit
OnBeforeBeingHitAll
OnBeforeDealHeal
OnBeforeDying
OnBeforeHit
OnBeforeHitAll
OnBeforeSkillUse
OnBeingBreak
OnBeingLimbo
OnBeingRevived
OnCreate
OnCustomEvent
OnDeathrattle
OnDestroy
OnEnterBattle
OnHPChange
OnInsertAbilityFinish
OnLimboWaitHeal
OnListenAfterAttack
OnListenAfterSkillUse
OnListenAimAtTargetsRefresh_CL
OnListenAllowAction
OnListenBeforeSkillUse
OnListenBreak
OnListenCharacterCreate
OnListenCharacterDie
OnListenCharmDamagePerformFinish
OnListenCharmMakeDamage
OnListenHPChange
OnListenInsertAbilityFinish
OnListenInsertActionStart
OnListenModifierAdd
OnListenModifierRemove
OnListenSetActiveSkill
OnListenTurnEnd
OnListenUltraSkillPrepare
OnModifierAdd
OnModifierRemove
OnPhase1
OnPhase2
OnResistDebuff
OnSnapshotCreate
OnSPChange
OnStack
OnTriggerBreak
OnTriggerDeath
OnTriggerDeathrattle
OnUltraSkillPrepare
OnWaveMonster
</details>

### CharacterModel
Basic Numeric Values 

Applied Effects
### EffectModel
Basic Numeric Values 

Associated Events
