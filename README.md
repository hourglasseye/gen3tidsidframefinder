##Gen 3 TID/SID Frame Finder

This is a tool for TID/SID emulator-based RNG manipulation on the following 3rd gen GBA games:

* Emerald
* Fire Red
* Leaf Green

This also supposedly works with the following GameCube games as well, but I can't personally attest to how well this works for these games. Someone else will have to write a guide for these:

* Colosseum
* XD: Gale of Darkness

That said, any of the instructions below are going to be for NDS games only.

##Requirements for NDS Games

* RNG Reporter (download it from [here](http://www.smogon.com/forums/threads/5th-gen-prng-help-info-latest-rng-reporter-9-96-5-pprng-1-15-0.83057/), scroll down to "Prerequisites")
* VBA-RR ([vba-rerecording-svn480-win32](http://tasvideos.org/EmulatorResources/VBA.html) is what I used)
* A ROM of your preferred 3rd generation Pokemon game (Emerald, Fire Red or Leaf Green)
* A save file editor with support for 3rd generation Pokemon games (PKHeX or PokeGen) for checking your SID
* A PID whose shininess you want to guarantee

##Usage

1. Open **VBA-RR**
1. Run the ROM of your preferred game. Make sure your RAM Watch for TID Timer, PRNG State and Frame (or RNG Frame) are set-up (see [this page](https://projectpokemon.org/wiki/Notable_Breakpoints) for addresses, or scroll down to the "Relevant RAM Addresses" section of this readme).
1. Reach the point in the game where:
* In Emerald, Prof. Birch says `"Well, I'll be expecting you later. Come see me in my POKEMON LAB"`. Pause there, and save state.
* In Fire Red or Leaf Green, Prof. Oak says `"Your very own POKEMON legend is about to unfold!"`. Pause there, and save state.
1. Open **Gen3TIDSIDFrameFinder.exe**
1. Copy the value from the `TID timer` on VBA-RR's RAM Watch into the "TID" field
1. Copy your desired PID from RNG Reporter into the "Desired PID" field
1. Copy the value from the `PRNG state` on VBA-RR's RAM Watch into the "PRNG State" field
1. Copy the value from the `Frame state` on VBA-RR's RAM Watch into the "Current Frame" field
1. You can just leave the value of Max Frame at `100000` (but you can change if you want)
1. Click "Find Frame to Hit"
1. Pick a SID from the list and take note of its frame
1. Go back to **VBA-RR**
1. Advance the frames until you reach the frame of the SID you picked
1. Press and hold A, then unpause the game (keep A pressed)
1. Check your the SID you got. Most likely, you got the wrong SID
1. Go back to **Gen3TIDSIDFrameFinder**
1. Input the frame you attempted to hit into the "Attempted Frame" field
1. Input the SID you got into the "Acquired SID" field
1. Click "Adjust Frame"
1. Take note of the frame value in "Use This Instead"
1. Go back to **VBA-RR**
1. Load your saved state from earlier
1. Advance the frames until you reach the adjusted frame value you got from "Use This Instead"
1. Press and hold A, then unpause the game (keep A pressed)
1. You now have a TID/SID combo that will guarantee the shininess of the PID you inputted earlier

###Relevant RAM Addresses for VBA-RR's RAM Watch

* TID Timer - `04000104`, Unsigned, 2 bytes (you need this for all)
* Emerald (U)
  * PRNG State - `03005D80`, Hexadecimal, 4 bytes
  * Frame - `020249C0`, Unsigned, 4 bytes
* Emerald (J)
  * PRNG State - `03005AE0`, Hexadecimal, 4 bytes
  * Frame - `02024664`, Unsigned, 4 bytes
* Fire Red / Leaf Green
  * PRNG State - `03005000`, Hexadecimal, 4 bytes
  * Frame - `03003114`, Unsigned, 4 bytes (provided by [CollectorTogami/ItsProfOak](https://www.reddit.com/user/ItsProfOak))
* These were taken from https://projectpokemon.org/wiki/Notable_Breakpoints unless specified otherwise

##Acknowledgements

This tool was the idea of [Feder96](https://www.reddit.com/user/Feder96/) (aka [Real.96](pokerng.forumcommunity.net/?act=Profile&MID=9270606)).

I had to study [RNGReporter](https://github.com/Slashmolder/RNGReporter), otherwise I wouldn't have been able to make this tool. In fact, most of us can't even begin to do any RNG manipulation without it, so thank you, [SlashMolder](http://www.smogon.com/forums/members/slashmolder.83647/)!

Thanks to all the amazing people from [r/pokemonrng](https://www.reddit.com/r/pokemonrng/), [Project Pokemon](https://projectpokemon.org) and [Smogon](http://www.smogon.com/ingame/rng/) for all the amazing RNG manipulation guides, tools and research.