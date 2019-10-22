# skywriter-mediacontrols

## Available gestures
- ⏯️ Tap: Play/Pause
- ➡️ Swipe left to right : Go to start of track (keep swiping to go to previous track)
- ⬅️ Swipe right to left: Next track
- 🔄 Airwheel clockwise: Decrease volume
- 🔄 Airwheel anti-clockwise: Increase volume


## Prereqs
### Computer playing music
- Install pywin32 module for python3 `pip3 install pywin32`
- Make sure dotnet core is installed (2.2+)
- Open ports
- Run app

### Pi with skywriter
- Install skywriter `curl -sSL get.pimoroni.com/skywriter | bash`
- Move `mediacontrol.py` to somewhere accessable on pi and point to server

## References
- VK names https://referencesource.microsoft.com/#WindowsBase/Shared/MS/Win32/NativeMethodsOther.cs,2493a61114ea6df8,references