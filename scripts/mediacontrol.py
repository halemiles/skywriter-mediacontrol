#!/usr/bin/env python
import skywriter
import signal
import requests

some_value = 5000

#@skywriter.move()
#def move(x, y, z):
#  print( x, y, z )

@skywriter.flick()
def flick(start,finish):
  if start == "east" and finish == "west":
   r = requests.get("http://192.168.1.60:5001/Control/back")
  if start == "west" and finish == "east":
   r = requests.get("http://192.168.1.60:5001/Control/next")
  print('Got a flick!', start, finish)

@skywriter.airwheel()
def spinny(delta):
  global some_value
  some_value += delta
  if some_value < 0:
  	some_value = 0
  if some_value > 10000:
    some_value = 10000
  print('Airwheel:', some_value/100)

@skywriter.double_tap()
def doubletap(position):
  print('Double tap!', position)
  r = requests.get("http://192.168.1.60:5001/Control/play")
  #print(r.json)

@skywriter.tap()
def tap(position):
  print('Tap!', position)
  r = requests.get("http://192.168.1.60:5001/Home/play")

@skywriter.touch()
def touch(position):
  print('Touch!', position)

signal.pause()
