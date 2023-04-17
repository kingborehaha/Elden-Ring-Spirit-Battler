![image](https://user-images.githubusercontent.com/55667610/222884370-4891068b-3ce5-477c-b8ce-ff76ef4c0336.png)

## Elden Ring Spirit Battler is a tool to set up custom encounters in Elden Ring via spirit ash summons.
- Summon vs summon. Watch them fight as a bystander.
- Player vs summon. Set up an encounter to defeat.
- Free for All. Somebody will win. Might even be you!
- Custom Spirit Ash. Malenia too hard? Just summon 10 Radahns.

## Features
- Customize entire fights with any enemy you want, up to 10 enemies at once
- Teams to determine who enemies hate and who they will ally with
- Pick phantom shaders for each team. Invaders? Spirit Summons? Completely invisible? All options! (Customizable phantoms TBA)
- Customize stats as desired. Want Radahn scaled the same as Melania for a fair fight? Want a crab that does 100x damage? Go hog wild
- Hidden player mode. Watch fights without distract enemies (or appearing on-camera)
- Set exactly where summons will appear. You can define arbitrary offsets, or just use one of the helpful presets if you don't want the hassle
- Mod compatability! Just run this tool after everything else has been installed.

## WARNINGS
- The current version of Mod Engine 2 does not manage save files, so if you have existing saves: go to "AppData\Roaming\EldenRing" and backup the save files within. Restore these backups before playing online, or you could potentially be banned.
- Do not run this tool on Regulation.bin in Elden Ring's "Game" folder. If you do and play online, you could potentially be banned.

## How to Use
- Download Mod Engine 2: https://github.com/soulsmods/ModEngine2/releases
- Download and install .NET Desktop Runtime 6.0: https://dotnet.microsoft.com/en-us/download/dotnet/6.0
- Locate your Mod engine 2 "Mod" folder.
- If you do not have any other mods installed, locate your Elden Ring installation and find regulation.bin, then copy and paste regulation.bin into your Mod Engine 2 "mod" folder. You can skip this step if you have other mods installed which modify regulation.bin, just use the regulation.bin that's already in your mod folder.
- Start Elden Ring Spirit Battler, click the browse button in the top left, and load the regulation.bin in your mod engine 2 "mod" folder.
- Hover the mouse over options for tips!
- Create teams and enemies as desired, then choose which Spirit Ash to overwrite.
- Save Changes. The selected ash should now be changed in-game.

## Updates
### v1.3.0
- Added a setting to toggle summons finding targets easily, letting you prevent summons running after boars from 99 meters away.
- Added an option for summons that sets if they aggro on targets at long distance or not, emulating vanilla spirit summon behavior when finding targets easily is disabled.
- Improved Malenia's info in SpiritAshResource.txt
### v1.2.1
- Fixed program version number
- Made summon backups not store some pointless data.
### v1.2.0
- Added summon backup system, which lets you save and load spirit battler data to json files.
- Added config file that saves settings.
- Fixed not being able to disable options for Enable Resummoning and Expand Summon Areas.
### v1.1.0
- Fixed default stat scaling level effects not being removed from human NPCs.
- Fixed stat scaling level effects not applying to non-human NPCs.
- Added Follow Player option for teams, which lets summons to follow the player around.
- Improved empty SpEffect detection, which should help prevent "Not enough free SpEffect slots in NpcParam" errors.
- Fixed an issue where SpEffects were added when they didn't need to be, which should also help prevent "Not enough free SpEffect slots in NpcParam" errors.
### v1.0.0
Public release
### v0.3.0
- Support human NPCs and populate enemy resource with humans.
- Enemy search now filters enemy variant list too.
- Added FAQ button
### v0.2.0
- Added option to expand the amount of areas you can summon in
- Added option that lets you summon and resummon without reloading the game
- Swapped default team's Team Type for Column Left (Enemy -> Beast) and Row Far (Beast -> Enemy)
### v0.1.1
Patreon Beta Release
- Added Spirit Ash search
- Changed a default team's teamType, fixing them not mutually hate the "Enemy" team
- Added randomize phantom color button, and removed that functionality from randomize team name button
- Fixed summon limit check being off by 1
- UI tweaks
### v0.1.0
Private Release

## Credits
- Built using https://github.com/JKAnderson/SoulsFormats
- Contains param definitions from https://github.com/soulsmods/Paramdex and https://github.com/soulsmods/DSMapStudio
