import os
from flask import Flask, request, jsonify, Response, redirect
import requests
import pprint
import json
import jwt
import math
import os
import datetime
import time
import discord
from discord import app_commands
import threading
import subprocess
import asyncio
from markupsafe import escape
from discord_webhook import DiscordWebhook
from threading import Timer
from concurrent.futures import ThreadPoolExecutor
from webhooks import login_webhook, logout_webhook, desync_logout_webook, crash_webhook, timein_webhook

#  ip = request.headers["X-FORWARDED-FOR"]


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

app = Flask(__name__)

null = None
false = False
true = True
forceentry = False
webhook_url = "https://discord.com/api/webhooks/1072418235485532180/4jx796CxdRV42FQS4orShOq37UWrZWb5ab94I8jJ06woJ_Cugg1w8f24Vs6SbX3TF7i0"
timers = {}


def crash(usernamefip):
  print("deleting @" + usernamefip + "from timers")
  del timers[usernamefip]
  print(usernamefip + " timedout, sending crash webhook")
  crash_webhook(usernamefip)


def crashtimer(usernamefip):
  if usernamefip in timers:
    timers[usernamefip].cancel()
    del timers[usernamefip]
    print("timer cancelled for " + usernamefip)
    return f"timer cancelled"
  print("timer created for for " + usernamefip)
  timers[usernamefip] = Timer(90.0, crash, [usernamefip])
  timers[usernamefip].start()
  return f"crashtimer func completed"


@app.route('/')
def returnnameserver():
  return jsonify("accounts")


@app.route('/matchmake/instance/69420', methods=["POST"])
def roomjoin():
  with open("fakeheartbeat.json", "r") as f:
    hbdata = json.load(f)
  meuserid = jwt.decode(request.headers.get('Authorization').replace(
    "Bearer ", ""),
                        options={"verify_signature": False})["sub"]
  if "a" + str(meuserid) in hbdata:
    return jsonify(hbdata["a" + str(meuserid)])
  return jsonify({"errorCode": 3})


@app.route('/room/<roomjoe>/instances')
def roominstanceforcejoinmaybe(roomjoe):
  return jsonify([{
    "roomInstanceId": 69420,
    "roomId": 1,
    "subRoomId": 1,
    "isFull": False,
    "createdAt": "2023-03-07T02:54:34.9364498Z",
    "playerIds": [121916]
  }])


@app.route('/forcejoin')
def forcejoin():
  joiname = request.args.get('userid')
  headers = {'Accept-Encoding': 'gzip, identity', 'User-Agent': 'BestHTTP'}
  headers["Authorization"] = request.headers.get('Authorization')
  matchdata = requests.get("https://match.rec.net/player?id=" + joiname,
                           headers=headers)
  userdata = requests.get("https://accounts.rec.net/account/" + joiname)
  userdata = userdata.json()
  meepurl = "http://www.meep.moe/api/pursuers?apiKey=638fa746c53245b7a4541973d5246143&username=" + userdata[
    "username"]
  print(meepurl)
  meepapidata = requests.get(meepurl)
  meepapidata = meepapidata.json()
  matchdata = matchdata.json()[0]
  meuserid = jwt.decode(request.headers.get('Authorization').replace(
    "Bearer ", ""),
                        options={"verify_signature": False})["sub"]
  #"photonRoomId":"fc06e708-943c-4f20-9270-f786f5fcf899",
  if not "roomId" in meepapidata:
    return Response(status=402)
  if "roomInstance" in matchdata and matchdata["roomInstance"] != None:
    matchdata["roomInstance"]["photonRoomId"] = meepapidata["roomId"]
    with open("fakeheartbeat.json", "r") as f:
      hbdata = json.load(f)
    hbdata["a" + str(meuserid)] = {"roomInstance": matchdata["roomInstance"]}
    json_object = json.dumps(hbdata, indent=4)
    f = open("fakeheartbeat.json", "w")
    f.write(json_object)
    f.close()
    return Response(status=200)
  else:
    return Response(status=402)

@app.route('/OGURLS/modsonline/<roomname>')
def get_room_info(roomname):
    with open('pubearer') as f:
      pb = json.load(f)
    bearer = pb["Bearer"]
    lookup=[
        "An Unknown Device",
        "VR",
        "Screen",
        "Mobile",
        "VR Low",
        "Quest 2"
    ]
    lookupstatus=[
        "Public",
        "Friends Only",
        "Favorite Friends Only",
        "Offline"
    ]
    lookuploco=[
        "Teleport",
        "Walk"
    ]
    url = f"https://rooms.rec.net/rooms?name={roomname}&include=1325&unityAssetTarget=1&unityAssetVersion=1"
    headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        "Authorization":bearer
    }
    response = requests.get(url, headers=headers)
    j1 = response.json()
    room_info = {"roomName": roomname, "onlinePlayers": []}
    for element in j1['Roles']:
        url = f"https://match.rec.net/player?id={element['AccountId']}"
        response = requests.get(url, headers=headers)
        j2 = response.json()[0]
        if j2['isOnline']:
            url = f"https://accounts.rec.net/account/{element['AccountId']}"
            response = requests.get(url)
            j3 = response.json()
            player_data = {
                "username": j3['username'],
                "deviceClass": lookup[j2['deviceClass']],
                "statusVisibility": lookupstatus[j2['statusVisibility']],
                "vrMovementMode": lookuploco[j2['vrMovementMode']]
            }
            room_info["onlinePlayers"].append(player_data)
    return jsonify(room_info)

@app.route('/hysteria/api/getbearer',methods=["GET","POST"])
def getbearer():
  name = 'pubearer'
  if request.method=="POST":
    name=name+str(hash(request.data))
  else:
    name=name+str(hash(request.headers.get("X-Forwarded-For")))
  if not os.path.exists(name):
    with open('pubearer') as f:
      pb = json.load(f)
    f = open(name, "w")
    f.write(json.dumps(pb))
    f.close()
  else:
    with open(name) as f:
      pb = json.load(f)
    return jsonify(pb)
  return "WTF???"

@app.route('/connect/token',methods=["POST"])
def authtoken():
  print(request.form.to_dict())
  ip=request.headers.get("X-Forwarded-For")
  name = 'authtoken'+str(hash(ip))
  if os.path.exists(name):
    with open(name) as f:
      pb = json.load(f)
    return jsonify(pb)
  else:
    token_ = requests.get("https://npuni.google.com/auth/connect1/token")
    token=token_.json()
    f = open(name, "w")
    f.write(json.dumps(token))
    f.close()
    with open(name) as f:
      pb = json.load(f)
    return jsonify(pb)
  return "WTF???"

@app.route('/hysteria/api/pc/invalidatebearer',methods=["GET"])
def invalidatebearer():
  name = str(hash(request.headers.get("X-Forwarded-For")))
  if os.path.exists('pubearer'+name):
    os.remove('pubearer'+name)
  if os.path.exists('authtoken'+name):
    os.remove('authtoken'+name)
  return "Removed."
@app.route('/hysteria/api/pc/getbearerid',methods=["GET"])
def getbearerid():
  name = str(hash(request.headers.get("X-Forwarded-For")))
  return name

@app.route('/hysteria/api/kill1')
def unipban():
  subprocess.Popen('kill 1', shell=True)
  return Response(status=200)

def errorcodetoeng(ecode):
  ujs = {
    "a74": "NotAMemberOfClub",
    "a50": "NotorietyTooPoor",
    "a-1": "UnknownError",
    "a70": "NoSuchClub",
    "a11": "JuniorNotAllowed",
    "a31": "DeviceClassNotSupportedByRoomOwner",
    "a14": "InsufficientRelationship",
    "a75": "BannedFromClub",
    "a35": "EventIsPrivate",
    "a78": "ChatPartyInviteNotFound",
    "a2": "PlayerNotOnline",
    "a30": "DeviceClassNotSupported",
    "a0": "Succes",
    "a82": "RRPlusRequired",
    "a83": "MetaJuniorAccountRestriction",
    "a26": "RoomInstanceIsPrivate",
    "a22": "RoomIsNotActive",
    "a40": "RoomInviteExpired",
    "a84": "NotExclusivelyLoggedIn",
    "a80": "ChatMessageNotAnInvite",
    "a21": "RoomBlockedByCreator",
    "a85": "AccountDoesNotExist",
    "a5": "EventAlreadyFinished",
    "a81": "DeveloperOnly",
    "a7": "BlockedFromRoom",
    "a3": "InsufficientSpace",
    "a1": "NoSuchGame",
    "a20": "NoSuchRoom",
    "a25": "RoomIsPrivate",
    "a36": "EventIsFull",
    "a76": "InstanceJoinNotPermitted",
    "a17": "AlreadyInTargetInstance",
    "a19": "UGCNotAllowed",
    "a4": "EventNotStarted",
    "a55": "BannedFromRoom",
    "a13": "AlreadyInBestInstance",
    "a73": "ClubIsNotActive",
    "a45": "NoAvailableRegion",
    "a16": "UpdateRequired",
    "a77": "LevelTooLow",
    "a32": "MovementModeNotSupportedByRoomOwner",
    "a79": "ChatPartyInviteModerated",
    "a12": "Banned",
    "a71": "ClubHasNoClubhouse"
  }
  return ujs["a" + str(ecode)] or "UnknownError"


@app.route('/invalidateroominstance', methods=["GET","POST"])
def invalidroominstance():
  edata = request.json
  print(edata)
  with open('instancearchive') as f:
    archiveinstance = json.load(f)
  if "/matchmake/event/" + str(
      edata["PlayerEventId"]) + "?" in archiveinstance:
    archiveinstance.pop("/matchmake/event/" + str(edata["PlayerEventId"]) +
                        "?")
    print("Removed " + str(edata["PlayerEventId"]) + " From Instance Archive")
  f = open("instancearchive", "w")
  f.write(json.dumps(archiveinstance, indent=4))
  f.close()
  return Response(Status=200)


def updatebearer(pubearer, rnsig):
  global publicbearer
  global publicrnsig
  publicbearer = pubearer
  publicrnsig = rnsig
  f = open("pubearer", "w")
  f.write(json.dumps({"Bearer": publicbearer, "rnsig": publicrnsig}))
  f.close()

lastaccount=0

@app.errorhandler(404)
def funnyhandler(gay):
  if request.full_path.endswith("reportjoinresult"):
    return Response(status=200)
  global requestfunnymethod
  newUrl = "https://match.rec.net" + request.full_path
  if not (request.full_path.startswith("/player/heartbeat")):
    print(request.form)
    print(request.stream.read() or "No Data")
    print(request.headers)
    print(request.method)
    print(newUrl)
  else:
    #neptune code starts here
    ip = request.headers["X-FORWARDED-FOR"]
    with open("sync.json", "r") as f:
      sync_data = json.load(f)
    if ip in sync_data:
      username = sync_data[ip]
      if username in timers:
        crashtimer(username)
        crashtimer(username)
      else:
        crashtimer(username)
        timein_webhook(username)
    #neptune code ends here
    updatebearer(request.headers.get('Authorization'),
                 request.headers.get('X-Rnsig'))
  requestfunnymethod = request.method
  headers = {'Accept-Encoding': 'gzip, identity', 'User-Agent': 'BestHTTP'}
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  if ("X-Rnsig" in request.headers):
    headers["X-Rnsig"] = request.headers.get('X-Rnsig')

  if requestfunnymethod == 'GET':

    redirectresponse = requests.get(newUrl, headers=headers)
    try:
      jsonResponse = redirectresponse.json()
      if request.full_path.startswith("/player?id="):
        new = []
        for status in jsonResponse:
          status1 = status
          status1["statusVisibility"] = 0
          status1["roomInstance"]["maxCapacity"] = +1
          status1["roomInstance"]["isFull"] = False
          new.append(status1)
        jsonResponse = new
      print("sending heartbeat response")
      print(jsonResponse)
      return jsonify(jsonResponse)
    except:
      return redirectresponse.raw

  elif requestfunnymethod == 'POST':

    with open('instancearchive') as f:
      archiveinstance = json.load(f)

    if (request.content_type.startswith('application/json')):
      headers['Content-Type'] = 'application/json'
      data = request.json
    elif (
        request.content_type.startswith("application/x-www-form-urlencoded")):
      headers['Content-Type'] = 'application/x-www-form-urlencoded'
      data = request.form.to_dict()
    with open("fakeheartbeat.json", "r") as f:
      hbdata = json.load(f)
    if request.full_path.startswith("/player/login"):
      llock = request.form["LoginLock"]
      
      userdata = requests.get("https://accounts.rec.net/account/me",headers=headers)
      userdata = userdata.json()
      userdata["LoginLock"]=llock
      # todo: add discord bot to verify accs with slash command before un-commenting
      global lastaccount
      if not os.path.exists("logins/" + str(userdata["accountId"]) + ".json"):
        userdata["Verified"]=False
        json_object = json.dumps(userdata, indent=4)
        f = open("logins/" + str(userdata["accountId"]) + ".json", "w")
        f.write(json_object)
        f.close()
        lastaccount=userdata["accountId"]
        #return Response(status=401)
      with open("logins/" + str(userdata["accountId"]) + ".json", "r") as f:
        llockfile=json.load(f)
        userdata=llockfile
      if llockfile["Verified"]==False:
        lastaccount=userdata["accountId"]
        #return Response(status=401)
      
      # neptune code starts here
      username = str(userdata["username"])
      ip = request.headers["X-FORWARDED-FOR"]

      with open("sync.json", "r") as f:
        sync_data = json.load(f)

      sync_data[ip] = username
      with open("sync.json", "w") as f:
        json.dump(sync_data, f, indent=4)
      if username in timers:
        del timers[username]
        crashtimer(username)
      else:
        crashtimer(username)
      login_webhook(username, userdata)

      # neptune code ends here
      
      json_object = json.dumps(userdata, indent=4)
      f = open("logins/" + str(userdata["accountId"]) + ".json", "w")
      f.write(json_object)
      f.close()
    if newUrl.endswith("?"):
      newUrl = newUrl.replace("?", "")
    redirectresponse = requests.post(newUrl, headers=headers, data=data)
    if request.full_path.startswith("/matchmake/"):
      if "roomInstance" in redirectresponse.json():
        meuserid = jwt.decode(request.headers.get('Authorization').replace(
          "Bearer ", ""),
                              options={"verify_signature": False})["sub"]
        if "a" + str(meuserid) in hbdata:
          hbdata.pop("a" + str(meuserid))
        json_object = json.dumps(hbdata, indent=4)
        f = open("fakeheartbeat.json", "w")
        f.write(json_object)
        f.close()
      elif "errorCode" in redirectresponse.json():
        print(errorcodetoeng(redirectresponse.json()["errorCode"]))
    if request.full_path.startswith("/matchmake/event/"):
      if "roomInstance" in redirectresponse.json():
        archiveinstance[request.full_path] = redirectresponse.json()
        meuserid = jwt.decode(request.headers.get('Authorization').replace(
          "Bearer ", ""),
                              options={"verify_signature": False})["sub"]
        if "a" + str(meuserid) in hbdata:
          hbdata.pop("a" + str(meuserid))
        json_object = json.dumps(hbdata, indent=4)
        f = open("fakeheartbeat.json", "w")
        f.write(json_object)
        f.close()
      elif "errorCode" in redirectresponse.json():
        print(errorcodetoeng(redirectresponse.json()["errorCode"]))
        if request.full_path in archiveinstance:
          meuserid = jwt.decode(request.headers.get('Authorization').replace(
            "Bearer ", ""),
                                options={"verify_signature": False})["sub"]
          hbdata["a" + str(meuserid)] = archiveinstance[request.full_path]
          json_object = json.dumps(hbdata, indent=4)
          f = open("fakeheartbeat.json", "w")
          f.write(json_object)
          f.close()
          return jsonify(archiveinstance[request.full_path])
    try:
      jsonResponse = redirectresponse.json()
      if not (request.full_path.startswith("/player/heartbeat")):
        print(jsonResponse)
      else:
        f = open("heartbeat", "w")
        f.write(json.dumps(jsonResponse))
        f.close()

        """
        
        with open("fakeheartbeat.json", "r") as f:
          hbdata = json.load(f)
        meuserid = jwt.decode(request.headers.get('Authorization').replace(          "Bearer ", ""),options={"verify_signature": False})["sub"]
        if hbdata["a" + str(meuserid)]:
          jsonResponse["roomInstance"] = hbdata["a" + str(meuserid)]["roomInstance"]
          """
      if "roomInstance" in jsonResponse:
        jsonResponse["roomInstance"]["isPrivate"] = True
        if jsonResponse["roomInstance"]["roomId"]==3600012773859582034:
          jsonResponse["roomInstance"]["location"]="cbad71af-0831-44d8-b8ef-69edafa841f6"

      f = open("instancearchive", "w")
      f.write(json.dumps(archiveinstance))
      f.close()
      return jsonify(jsonResponse)
    except:
      if not (request.full_path.startswith("/player/heartbeat")):
        print(redirectresponse.status_code)
      return redirectresponse.raw

  elif requestfunnymethod == 'PUT':
    if (request.content_type.startswith('application/json')):
      headers['Content-Type'] = 'application/json'
      data = request.json
    elif (
        request.content_type.startswith("application/x-www-form-urlencoded")):
      headers['Content-Type'] = 'application/x-www-form-urlencoded'
      data = request.form
    redirectresponse = requests.put(newUrl, headers=headers, data=data)
    try:
      jsonResponse = redirectresponse.json()
      if not (request.full_path.startswith("/player/heartbeat")):
        print(jsonResponse)
      return jsonify(jsonResponse)
    except:
      return redirectresponse.raw


#neptune code starts here
@app.route('/player/logout', methods=['POST'])
def logout():
  ip = request.headers["X-FORWARDED-FOR"]
  with open("sync.json", "r") as f:
    sync_data = json.load(f)

  if ip in sync_data:
    username = sync_data[ip]
    if username in timers:
      del timers[username]
      crashtimer(username)
    print(username + " logged out, sending logout webhook")
    logout_webhook(username)
    del sync_data[ip]
    with open("sync.json", "w") as f:
      json.dump(sync_data, f, indent=4)
    return "logout webhook sent"
  else:
    username = sync_data[ip]
    desync_logout_webook(username)
  return 1

intents = discord.Intents.default()
intents.message_content = True
client = discord.Client(intents=intents)
tree = app_commands.CommandTree(client)

@client.event
async def on_ready():
  await tree.sync(guild=discord.Object(id=1065355483222904953))
  print(f'We have logged in as {client.user}')

@tree.command(name = "verify_account", description = "Verify an account for hysteria use.", guild=discord.Object(id=1065355483222904953) )
async def first_command(interaction):
  global lastaccount
  if lastaccount==0:
    await interaction.response.send_message("No account to verify.")
  else:
    with open("logins/" + str(lastaccount) + ".json", "r") as f:
      llockfile=json.load(f)
      userdata=llockfile
      userdata["Verified"]=True
      json_object = json.dumps(userdata, indent=4)
      f = open("logins/" + str(lastaccount) + ".json", "w")
      f.write(json_object)
      f.close()
      resp="Account "+str(lastaccount)+" Verified."
      lastaccount=0
      await interaction.response.send_message(resp)
  
#neptune code ends here
def rundbot():
  
  client.run(os.environ['token'])
discordbotthread = threading.Thread(target=rundbot)
discordbotthread.start()

if __name__ == "__main__":
  app.run("0.0.0.0", 8080)
