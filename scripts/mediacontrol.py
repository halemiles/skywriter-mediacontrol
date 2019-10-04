#!/usr/bin/env python
import skywriter
import signal
import requests

some_value = 5000
server_url = 'http://192.168.1.60:5001'
print('--SkyWriter Media Control--')
@skywriter.flick()
def flick(start,finish):
  if start == "east" and finish == "west":
    try:
      r = requests.get(server_url+"/Control/back")
      print('Previous track trigger', start, finish)
    except:
      print('Problem finding server', server_url)

  if start == "west" and finish == "east":
    try:
      r = requests.get(server_url+"/Control/next")
      print('Next track trigger', start, finish)
    except:
      print('Problem finding server', server_url)

@skywriter.tap()
def tap(position):
  try:
    r = requests.get(server_url+"/Control/play")
    print('Play/pause trigger')
  except:
    print('Problem finding server', server_url)

signal.pause()
