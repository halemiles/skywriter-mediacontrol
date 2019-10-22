import sys
import win32api
from win32con import VK_MEDIA_PLAY_PAUSE, KEYEVENTF_EXTENDEDKEY, VK_MEDIA_NEXT_TRACK, VK_MEDIA_PREV_TRACK, VK_VOLUME_DOWN, VK_VOLUME_UP



if sys.argv[1] == "play":
    win32api.keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENDEDKEY, 0)

if sys.argv[1] == "next":
    win32api.keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENDEDKEY, 0)

if sys.argv[1] == "back":
    win32api.keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENDEDKEY, 0)

if sys.argv[1] == "volup":
    win32api.keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENDEDKEY, 0)

if sys.argv[1] == "voldown":
    win32api.keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENDEDKEY, 0)