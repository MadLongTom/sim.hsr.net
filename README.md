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
- [ ] Create character database
- [ ] Create battle system
- [ ] to be added...
## Designs
### Battle framework
#### Inclusion
Battle 

Round 

Bout(100 Action Point) 

Character 

Skill 
#### GameEvent
OnBattleStart	OnRoundStart OnBoutStart OnCharacterStart OnSkillApply OnCharacterEnd OnBoutEnd OnRoundEnd OnBattleEnd
### CharacterModel
Basic Numeric Values 
Applied Effects
### EffectModel
Basic Numeric Values 
Associated Events
