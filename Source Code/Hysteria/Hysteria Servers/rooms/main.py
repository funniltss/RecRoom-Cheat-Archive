from flask import Flask, redirect, url_for, send_file, request, jsonify, request, send_file, Response, make_response
import sys
import requests
import pprint
import requests
import json
import urllib.parse
import jwt
import uuid
import subprocess
import datetime
import math
import base64
import random


class LoggingMiddleware(object):

  def __init__(self, app):
    self._app = app

  def __call__(self, env, resp):
    errorlog = env['wsgi.errors']
    pprint.pprint(('REQUEST', env), stream=errorlog)

    def log_response(status, headers, *args):
      pprint.pprint(('RESPONSE', status, headers), stream=errorlog)
      return resp(status, headers, *args)

    return self._app(env, log_response)


global authtokenfunny
null=None
false=False
true=True
app = Flask(__name__)

@app.route('/')
def returnnameserver():
  return jsonify("rooms") 

@app.route('/hysteria/api/kill1')
def unipban():
  subprocess.Popen('kill 1', shell=True)
  return Response(status=200)

@app.route('/photon_access_tokens')
def phtn():
  return jsonify({
    "Permissions":[
      {
         "Permission":"VOTE_KICK_PERMISSION",
         "Role":0,
         "Override":true,
         "Type":1,
         "Value":"1"
      },{
         "Permission":"CAN_EDIT_ROOM_ROLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_INVITE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_TALK",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_PRINT_PHOTOS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_START_GAMES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SELF_REVIVE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"AUTO_ASSIGNED_GAME_ROLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_CHANGE_GAME_MODE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_MAKER_PEN",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_DELETE_ALL_BUTTON",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SAVE_INVENTIONS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"DISABLE_MIC_AUTO_MUTE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_END_GAMES_EARLY",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_SHARE_CAM",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"DEPRECATED_CAN_EDIT_CIRCUITS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SPAWN_INVENTIONS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SPAWN_CONSUMABLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_ROOM_RESET_BUTTON",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_PLAY_GIZMOS_TOGGLE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },
   ]
  }) 

def edit_token(jwt_token):
    print(jwt_token)
    return jwt_token
  
@app.errorhandler(404)
def funnyhandler(gay):
  global requestfunnymethod
  print(request.form)
  print(request.data)
  print(request.headers)
  requestfunnymethod = request.method
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP'
  }
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  if ("X-Rnsig" in request.headers):
    headers["X-Rnsig"] = request.headers.get('X-Rnsig')
  if request.full_path.endswith("/clone"):
    return make_response(200)
  if request.full_path.startswith("/nigga"):
    newUrl = "https://chat.rec.net" + request.full_path
    return jsonify(newUrl)
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      if request.full_path.startswith("/rooms/") and request.full_path.endswith("/bans?"):
        return jsonify([])
      path= request.full_path
      newUrl = "https://rooms.rec.net" + path
      if "/saves" in newUrl and newUrl.endswith("skip=0&take=20"):
        newUrl=newUrl.replace("&take=20","&take=65536")
      print(newUrl)
      
        
      
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      if request.full_path.startswith("/photon_access_token"):
        print(jsonResponse)
        mptoken=jwt.encode({
  "sub": "1",
  "scope": "makerpen",
  "aud": '1'
}, "secret", algorithm="HS256")
        #jsonResponse["PhotonAccessToken"]=mptoken
        jsonResponse["Permissions"]=[
      {
         "Permission":"VOTE_KICK_PERMISSION",
         "Role":0,
         "Override":true,
         "Type":1,
         "Value":"1"
      },{
         "Permission":"CAN_EDIT_ROOM_ROLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_INVITE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_TALK",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_PRINT_PHOTOS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_START_GAMES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SELF_REVIVE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"AUTO_ASSIGNED_GAME_ROLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_CHANGE_GAME_MODE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_MAKER_PEN",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_DELETE_ALL_BUTTON",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SAVE_INVENTIONS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"DISABLE_MIC_AUTO_MUTE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_END_GAMES_EARLY",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_SHARE_CAM",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"DEPRECATED_CAN_EDIT_CIRCUITS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SPAWN_INVENTIONS",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_SPAWN_CONSUMABLES",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_ROOM_RESET_BUTTON",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },{
         "Permission":"CAN_USE_PLAY_GIZMOS_TOGGLE",
         "Role":0,
         "Override":true,
         "Type":0,
         "Value":"True"
      },
   ]
      if "533349622569843?include=" in request.full_path:
        newsubrooms=[]
        for juhuj in jsonResponse["SubRooms"]:
          x=juhuj
          x["UnityAssetId"]="310da1c3-1929-42c2-b89c-f8d31c691342"
          x["UnityAsset"]="3yn9c9kaqlsb240ijbcot33t5.assetbundle"
          x["UnityAssetHash"]="Uq77iFC8xFsebchN285qAjaMhTGxxpEQpwUiVJE75+Q="
          x["DataBlob"]="bh54455jud8nid0lf0rqsg85c.room"
          x["DataBlobHash"]="XMHXP4GpXO2i4EqE2I7ZKhCwOFqnoEfYuHB4A5oS3/g="
          if "CurrentSave" in x:
            x["CurrentSave"]["SubRoomDataSaveId"]=120094129
            x["CurrentSave"]["UnityAssetId"]="310da1c3-1929-42c2-b89c-f8d31c691342"
            x["CurrentSave"]["UnityAsset"]="3yn9c9kaqlsb240ijbcot33t5.assetbundle"
            x["CurrentSave"]["UnityAssetHash"]="Uq77iFC8xFsebchN285qAjaMhTGxxpEQpwUiVJE75+Q="
            x["CurrentSave"]["DataBlob"]="bh54455jud8nid0lf0rqsg85c.room"
            x["CurrentSave"]["DataBlobHash"]="XMHXP4GpXO2i4EqE2I7ZKhCwOFqnoEfYuHB4A5oS3/g="
          newsubrooms.append(x)
        jsonResponse["DataBlob"]="5uausg3njczkrnxh1yib8o4vb.meta"
        jsonResponse["DataBlobHash"]="ojc0kmwlR3/Tq5kAwImPBLx9dftsFZgeheUtfdl6r0s="
        jsonResponse["SubRooms"]=newsubrooms
      if "?include=1325&unityAssetTarget" in request.full_path:
        jsonResponse["SupportsScreens"] = True
        jsonResponse["SupportsWalkVR"] = True
        jsonResponse["SupportsTeleportVR"] = True
        jsonResponse["SupportsVRLow"] = True
        jsonResponse["SupportsQuest2"] = True
        jsonResponse["SupportsMobile"] = True
        jsonResponse["SupportsJuniors"] = True
        #jsonResponse["IsDorm"] = True
        redirectresponse2=requests.get("https://accounts.rec.net/account/me",headers=headers)
        hsib = redirectresponse2.json()
        jsonResponse["CreatorAccountId"]=hsib["accountId"]
        a={"AccountId":hsib["accountId"],"Role":255,"LastChangedByAccountId":1,"InvitedRole":0}
        jsonResponse["Roles"].insert(1,a)
        jsonResponse["IsDeveloperOwned"]=true
        jsonResponse["IsRRO"]=false
        jsonResponse["MinLevel"]=0
        jsonResponse["Tags"]=[]
      if request.full_path.startswith("/rooms/createdby/me"):
        urujs=[]
        redirectresponse2=requests.get("https://accounts.rec.net/account/me",headers=headers)
        hsib = redirectresponse2.json()
        for room in jsonResponse:
          room["CreatorAccountId"]=hsib["accountId"]
          a={"AccountId":hsib["accountId"],"Role":255,"LastChangedByAccountId":1,"InvitedRole":0}
          room["Roles"]=[a]
          urujs.append(room)
        jsonResponse=urujs
      if request.full_path.startswith("/rooms/search?query="):
        roomname=urllib.parse.unquote(request.args.get('query')).split(" ")[0]
        print(roomname)
        try:
          redirectresponse2=requests.get("https://rooms.rec.net/rooms?name="+roomname, headers=headers)
          jsonResponse2 = redirectresponse2.json()
          jsonResponse["Results"].insert(0,jsonResponse2)
        except:
          print("no roomname")

      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if "/bans" in request.full_path:
        return jsonify({"Success":true})
      if (request.content_type.startswith('application/json')):
        headers['Content-Type']= 'application/json'
        data = request.json
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers['Content-Type']= 'application/x-www-form-urlencoded'
        data = request.form
      newUrl = "https://rooms.rec.net" + request.full_path
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
      try:
        jsonResponse = redirectresponse.json()
        if request.full_path.endswith("/bans"):
          jsonResponse["Success"]=True
        if len(json.dumps(jsonResponse))<2500:
          print(jsonResponse)
        return jsonify(jsonResponse)
      except:
        return redirectresponse.raw
    elif request.method == 'PUT':
      if (request.content_type.startswith('application/json')):
        headers['Content-Type']= 'application/json'
        data = request.json
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers['Content-Type']= 'application/x-www-form-urlencoded'
        data = request.form
      newUrl = "https://rooms.rec.net" + request.full_path
      print(data)
      response = requests.put(newUrl, headers=headers, data=data)
      try:
        json_response = response.json()
        if len(json.dumps(json_response))<2500:
          print(json_response)
        return jsonify(status_code=response.status_code, response=json_response)
      except:
        return response.content

if __name__ == "__main__":
  app.run("127.0.0.2", 8080)
