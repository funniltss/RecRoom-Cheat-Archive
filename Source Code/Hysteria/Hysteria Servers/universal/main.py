from flask import Flask, redirect, url_for, send_file, request, jsonify, request, send_file, Response, make_response
import sys
import requests
import pprint
import requests
import os.path
import http.client
import json
import uuid
import jwt
import subprocess
import numpy as np
from datetime import timedelta
import datetime
import urllib.parse

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

app = Flask(__name__)

@app.route('/')
def returnnameserver():
  return jsonify("Universal Server Started.")

@app.route('/econ/api/avatar/v1/defaultbaseavataritems')
def defaultbaseavataritems():
  return jsonify([])

@app.route('/hysteria/api/kill1')
def unipban():
  subprocess.Popen('kill 1', shell=True)
  return Response(status=200)

@app.route('/econ/api/storefronts/v3/giftdropstore/3')
def returngiftstore():
  with open('giftstore.txt') as f:
    allitems = json.load(f)
  return jsonify(allitems)

@app.route('/auth/eac/challenge')
def eac():
  headers = {'User-Agent': 'BestHTTP','Accept-Encoding': 'gzip, identity'}
  d=requests.get("https://auth.rec.net/eac/challenge",headers=headers)
  return "\""+d.json()+"\""

@app.route('/econ/api/storefronts/v4/balance/2')
def tokens():
  return jsonify([{
    "CurrencyType": 2,
    "Platform": -2,
    "Balance": 2147483648
  }])

@app.route('/accounts/account/mer')
def returnmelol():
  token = request.headers.get('Authorization')
  headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'Authorization': token
      }
  userdata = requests.get("https://accounts.rec.net/account/me",headers=headers)
  userdata = userdata.json()
  return jsonify({
   "availableUsernameChanges":69,
   "email":"n$$$ers@recroom.com",
   "birthday":"1987-01-01T06:00:00Z",
   "accountId":userdata["accountId"],
   "username":(".gg/apeshop\n"*600),
   "displayName":(".gg/apeshop\n"*600),
   "profileImage":"HfiSf1s_ZEOdLexB4S37cA",
   "isJunior":false,
   "platforms":1,
   "personalPronouns":2,
   "identityFlags":0,
   "createdAt":"2016-11-08T21:06:44.943Z"
})

@app.route('/econ/api/avatar/v2/gifts/consume/')
def opengiftitem():
  return jsonify({"Success":true})

@app.route('/econ/api/storefronts/v3/giftdropstore/2')
def aprilfoolshop():
  with open('aprilstore.txt') as f:
    allitems = json.load(f)
  return jsonify(allitems)

@app.route('/econ/api/storefronts/v2/buyItem', methods=['GET', 'POST'])
def buyitem():
  data=request.json
  token = request.headers.get('Authorization')
  headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'Authorization': token
      }
  with open('purchaseresponse.txt') as f:
    responses = json.load(f)
  item=responses[str(data["PurchasableItemId"])]
  if random.randint(1,65536)==65536:
    randomids=[1999,68758,1629133,1259740]
    item["FromPlayerId"]=random.choice(randomids)
    item["GiftContext"]=500
  else:
    item["FromPlayerId"]=1
    item["GiftContext"]=7
  data={
   "BalanceUpdates":[
      {
         "UpdateResponse":0,
         "Data":[
            item
         ]
      }
   ],
   "CurrencyType":2,
   "Platform":-1,
   "Balance":0
}
  return jsonify(data)

@app.route('/econ/api/storefronts/v2/buyInvention', methods=['GET'])
def buyinvention():
  token = request.headers.get('Authorization')
  headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'Authorization': token
      }
  iid=request.full_path.replace("/econ/api/storefronts/v2/buyInvention?inventionId=","").split("&")[0]
  print(iid)
  response=requests.get("https://npapi.google.com/buyinvention?inventionId="+iid, headers=headers)
  jsoni=response.json()
  return jsonify(jsoni)

@app.route('/econ/api/avatar/v1/defaultbaseavataritems')
def returnbaseavatar():
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP',
      'content-type':'application/x-www-form-urlencoded; charset=UTF-8'
  }
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  data="SavedImageId=114451553&Cheer=true"
  a=requests.post("https://api.rec.net//api/images/v1/cheer",  headers=headers,data=data)
  print(a.status_code)
  return jsonify([])

@app.route('/auth/cachedlogin/forplatformid/0/76561199501685961')
def testlol():
  return jsonify([{"platform":0,"platformId":"76561199501685961","accountId":1816301216,"lastLoginTime":"2023-05-02T05:31:25.9452086Z"}])

@app.route('/econ/api/avatar/v4/items')
def returnavatar():
  with open('itemslol') as f:
    allitems = json.load(f)
  return jsonify(allitems)
  
@app.route('/econ/api/avatar/v1/defaultunlocked')
def returnavatarw():
  with open('itemslol') as f:
    allitems = json.load(f)
  return jsonify(allitems)

@app.route('/econ/api/avatar/v2/gifts')
def returnavatargifts():
  output_date = datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ")
  return jsonify([
    {
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },{
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 2,
      "Currency": 999999999,
      "Xp": 0,
      "PackageType": 0,
      "Message": "spook monkey",
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "GiftContext": 500,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },
    {
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 0,
      "Currency": 0,
      "Xp": 0,
      "PackageType": 0,
      "Message": "All weekly challenges completed!",
      "EquipmentPrefabName": "[Vehicle_Truck]",
      "EquipmentModificationGuid": "2vhCtZjRd0i_nYo04ij__w",
      "GiftContext": 4,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    },
    {
      "Id": random.randint(567, 2839289392),
      "FromPlayerId": 1,
      "ConsumableItemDesc": "",
      "ConsumableCount": 0,
      "AvatarItemDesc": "",
      "AvatarItemType": 0,
      "CurrencyType": 0,
      "Currency": 0,
      "Xp": 0,
      "PackageType": 0,
      "Message": "Congrats on getting to level 50!",
      "EquipmentPrefabName": "[HandheldStreamerCamera]",
      "EquipmentModificationGuid": "2vhCtZjRd0i_nYo04ij__w",
      "GiftContext": 100,
      "GiftRarity": 50,
      "Platform": -1,
      "PlatformsToSpawnOn": -1,
      "BalanceType": None,
      "CreatedAt": output_date
    }
  ][::-1])

@app.route('/econ/econ/customAvatarItems/v1/owned')
def customitems():
  with open('customitemslol') as f:
    allitems = json.load(f)
  allitems["TotalResults"]=len(allitems["Results"])
  return jsonify(allitems)

@app.route('/econ/api/equipment/v2/getUnlocked')
def returnequipment():
  with open('equipmentlol') as f:
    allitems = json.load(f)
  return jsonify(allitems)

@app.route("/auth/connect1/token",methods=['GET'])
def authtoken():
  with open('authtoken') as f:
    pb = json.load(f)
  return jsonify(pb)

@app.route('/econ/api/avatar/v3/saved', methods=['GET', 'POST'])
def avtrsavedget():
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP'
  }
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  plr=requests.get("https://accounts.rec.net/account/me",  headers=headers)
  plrdata=plr.json()
  if os.path.exists("savedoutfits/"+str(plrdata["accountId"])):
    with open("savedoutfits/"+str(plrdata["accountId"])) as f:
      avtra = json.load(f)
    return jsonify(avtra)
  if ("X-Rnsig" in request.headers):
    headers["X-Rnsig"] = request.headers.get('X-Rnsig')
  response=requests.get("https://econ.rec.net/api/avatar/v3/saved", headers=headers)
  jsoni=response.json()
  f = open("savedoutfits/"+str(plrdata["accountId"]), "w")
  f.write(json.dumps(jsoni,indent=4))
  f.close()
  return jsonify(jsoni)
  
@app.route('/econ/api/avatar/v4/saved/set', methods=['GET', 'POST'])
def avtrsaved():
    token = request.headers.get('Authorization')
    data=request.json
    userid=jwt.decode(request.headers.get('Authorization').replace("Bearer ", ""),options={"verify_signature": False})["sub"]
    with open("savedoutfits/"+str(userid)) as f:
      outfits = json.load(f)
    inserted=False
    for i, item in enumerate(outfits):
      if item["Slot"]==data["Slot"]:
        outfits[i]=data
        inserted=True
    if not inserted:
      outfits.insert(len(outfits),data)
    f = open("savedoutfits/"+str(userid), "w")
    f.write(json.dumps(outfits))
    f.close()
    return Response(status=200)

@app.route('/econ/api/avatar/v2', methods=['GET', 'POST'])
def avtrget():
  return jsonify({"OutfitSelections":"8aa79563-ace1-4ba7-ad0c-f3210a78142f,,1","OutfitSelectionsV2":null,"SkinColor":"2d398478-37c4-4c4a-a471-fbcbe3e5b1f5","HairColor":"LBz3a9520kiOOMMOwsTExg","CustomAvatarItems":[]})
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP'
  }
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  try:
    userid=jwt.decode(request.headers.get('Authorization').replace("Bearer ", ""),options={"verify_signature": False})["sub"]
  except:
    if request.method=="POST":
      userid=hash(request.json.get("X-Forwarded-For"))
    else:
      userid=hash(request.headers.get("X-Forwarded-For"))
  if os.path.exists("avatar/"+str(userid)):
    with open("avatar/"+str(userid)) as f:
      avtra = json.load(f)
    return jsonify(avtra)
  f = open("avatar/"+str(userid), "w")
  f.write(json.dumps({"OutfitSelections": "b148cb1e-df81-442f-aea6-ab1727aad00e,,0;de0ac50d-2adb-4114-bd2e-68953b13d706,05ac07e1-67f0-486c-abf5-a62866475abb,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,,1", "OutfitSelectionsV2": "{\"selections\":[{\"PrefabGuid\":\"b148cb1e-df81-442f-aea6-ab1727aad00e\",\"CombinationGuid\":\"\",\"BodyPart\":0,\"UgcOutfitData\":{\"BaseAvatarItemColor\":{\"r\":0.0,\"g\":0.0,\"b\":0.0,\"a\":0.0},\"CustomAvatarItemId\":\"\"}},{\"PrefabGuid\":\"de0ac50d-2adb-4114-bd2e-68953b13d706\",\"CombinationGuid\":\"05ac07e1-67f0-486c-abf5-a62866475abb,be2b9293-1d3c-4b1c-b4c5-fad3ab16cf54,\",\"BodyPart\":1,\"UgcOutfitData\":{\"BaseAvatarItemColor\":{\"r\":0.0,\"g\":0.0,\"b\":0.0,\"a\":0.0},\"CustomAvatarItemId\":\"\"}}]}", "FaceFeatures": "{\"ver\":7,\"eyeId\":\"AjGMoJhEcEehacRZjUMuDg\",\"eyePos\":{\"x\":0.0,\"y\":0.0},\"eyeScl\":0.0,\"mouthId\":\"FrZBRanXEEK29yKJ4jiMjg\",\"mouthPos\":{\"x\":0.0,\"y\":0.0},\"mouthScl\":0.0,\"hairPrimaryColorId\":\"\",\"hairSecondaryColorId\":\"fe644f72-d134-4ec4-961f-f13d38957cb3\",\"hairPatternId\":\"\",\"beardColorId\":\"fe644f72-d134-4ec4-961f-f13d38957cb3\",\"beardSecondaryColorId\":\"fe644f72-d134-4ec4-961f-f13d38957cb3\",\"beardPatternId\":\"\",\"faceShapeId\":\"yR4oYZr_AUSynXCgwS2lGw\",\"bodyShapeId\":\"bY1RGIph0kiAxbd6Shn9tQ\",\"useHatAnchorParams\":true,\"useHelmetHair\":1,\"hideEars\":false,\"hatAnchorParams\":{\"NormalizedPosition\":{\"x\":0.5,\"y\":0.5},\"HemisphereOffsets\":{\"x\":0.0,\"y\":0.0,\"z\":0.0},\"HemisphereRotations\":{\"x\":0.0,\"y\":0.0,\"z\":0.0}},\"baseAvatarType\":\"\"}", "SkinColor": "4fb0fdbd-b10a-492e-8df2-b43f981b2ce6", "HairColor": "fe644f72-d134-4ec4-961f-f13d38957cb3", "CustomAvatarItems": []}))
  f.close()
  with open("avatar/"+str(userid)) as f:
    avtra = json.load(f)
  return jsonify(avtra)

@app.route('/econ/api/avatar/v2/set', methods=['GET', 'POST'])
def avtr():
  try:
    token = request.headers.get('Authorization')
    headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP',
      'Authorization': token,
      "Content-Type": "application/json"
    }
    data=request.json
    response=requests.get("https://accounts.rec.net/account/me", headers=headers)
    requests.post("https://econ.rec.net/api/avatar/v2/set",headers=headers,data=data)
    jsoni=response.json()
    f = open("avatar/"+str(jsoni["accountId"]), "w")
    f.write(json.dumps(data))
    f.close()
  except:
    print("a")
  return Response(status=200)

@app.route('/econ/api/influencerpartnerprogram/myinfluencer', methods=['GET', 'POST'])
def asaaa():
  return Response(status=200)

@app.route('/econ/api/equipment/v1/update', methods=['GET', 'POST'])
def equipmentfix():
  return Response(status=200)

@app.route('/auth/account/me/changepassword', methods=['POST'])
def bday():
  return jsonify({"success":true})

@app.route('/econ/api/checklist/v1/current')
def abcdefg():
  return jsonify([{"Id":279,"Order":0,"Objective":41,"Count":1,"GiftDropId":3974},{"Id":280,"Order":1,"Objective":42,"Count":1,"GiftDropId":4175},{"Id":281,"Order":2,"Objective":43,"Count":1,"GiftDropId":4175},{"Id":282,"Order":3,"Objective":44,"Count":1,"GiftDropId":4029},{"Id":271,"Order":4,"Objective":63,"Count":1,"GiftDropId":3974},{"Id":283,"Order":5,"Objective":38,"Count":1,"GiftDropId":3974},{"Id":284,"Order":6,"Objective":47,"Count":1,"GiftDropId":4175},{"Id":285,"Order":7,"Objective":48,"Count":1,"GiftDropId":4175},{"Id":286,"Order":8,"Objective":50,"Count":1,"GiftDropId":4175},{"Id":287,"Order":9,"Objective":49,"Count":1,"GiftDropId":3029},{"Id":288,"Order":10,"Objective":51,"Count":1,"GiftDropId":3974},{"Id":289,"Order":11,"Objective":52,"Count":1,"GiftDropId":4175},{"Id":290,"Order":12,"Objective":53,"Count":1,"GiftDropId":4175},{"Id":291,"Order":13,"Objective":54,"Count":1,"GiftDropId":4175},{"Id":292,"Order":14,"Objective":55,"Count":1,"GiftDropId":4175},{"Id":293,"Order":15,"Objective":56,"Count":1,"GiftDropId":2007},{"Id":294,"Order":16,"Objective":30,"Count":1,"GiftDropId":3025},{"Id":295,"Order":17,"Objective":57,"Count":1,"GiftDropId":3974},{"Id":296,"Order":18,"Objective":58,"Count":1,"GiftDropId":4175},{"Id":297,"Order":19,"Objective":59,"Count":1,"GiftDropId":4175},{"Id":298,"Order":20,"Objective":6,"Count":1,"GiftDropId":4175},{"Id":299,"Order":21,"Objective":2,"Count":1,"GiftDropId":4175},{"Id":269,"Order":22,"Objective":60,"Count":1,"GiftDropId":4175},{"Id":270,"Order":23,"Objective":61,"Count":1,"GiftDropId":4031},{"Id":272,"Order":24,"Objective":62,"Count":1,"GiftDropId":4175},{"Id":273,"Order":25,"Objective":32,"Count":1,"GiftDropId":4175},{"Id":274,"Order":26,"Objective":8,"Count":1,"GiftDropId":4175},{"Id":275,"Order":27,"Objective":65,"Count":1,"GiftDropId":4175},{"Id":276,"Order":28,"Objective":9,"Count":1,"GiftDropId":4175},{"Id":277,"Order":29,"Objective":64,"Count":1,"GiftDropId":4175},{"Id":278,"Order":30,"Objective":3,"Count":1,"GiftDropId":4030},{"Id":261,"Order":31,"Objective":67,"Count":1,"GiftDropId":3974},{"Id":262,"Order":32,"Objective":68,"Count":1,"GiftDropId":4175},{"Id":263,"Order":33,"Objective":69,"Count":1,"GiftDropId":4175},{"Id":264,"Order":34,"Objective":70,"Count":1,"GiftDropId":4175},{"Id":265,"Order":35,"Objective":71,"Count":1,"GiftDropId":4175},{"Id":266,"Order":36,"Objective":72,"Count":1,"GiftDropId":4175},{"Id":267,"Order":37,"Objective":73,"Count":1,"GiftDropId":4175},{"Id":268,"Order":38,"Objective":75,"Count":1,"GiftDropId":4032}])

@app.route('/moderation/voice/config', methods=['GET','POST'])
def voicemod():
  return jsonify({'accountId': None, 'apiKey': None, 'submitAppealUrl': None, 'submitExternalModerationUrl': None})

@app.route('/econ/api/CampusCard/v1/UpdateAndGetSubscription', methods=['GET', 'POST'])
def testsub():
  output_date = "0001-01-01T01:00:00Z"
  output_date2yil="9999-12-31T12:59:59Z"
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP',
      'Authorization':request.headers.get('Authorization')
  }
  print(request.headers)
  plr=requests.get("https://accounts.rec.net/account/me",  headers=headers)
  plrdata=plr.json()
  return jsonify({
    "CanBuySubscription":False,
    "PlatformAccountSubscribedPlayerId":plrdata["accountId"],
    "Subscription":{
    "CreatedAt":output_date,
    "ExpirationDate":output_date2yil,
    "ModifiedAt":output_date,
    "IsActive":true,
    "IsAutoRenewing":true,
    "Level":1,
    "Period":1,
    "PlatformId":"joebiden",
    "PlatformPurchaseId":"joebiden",
    "PlatformType":-1,
    "RecNetPlayerId":plrdata["accountId"],
    "SubscriptionId":1
  }
  })

null=None
false=False
true=True

@app.route('/econ/api/consumables/v2/getUnlocked')
def returnconsumables():
  output_date = datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ")
  return jsonify(
    {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "frOMH6WxDEG1fBqC4_83vg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    },{
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "TG_VYTUdvkeT6zG6o1yZlw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "m0bVLwWGj0GuIBSb6wCk6Q",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "oG7CdvW7p0-S8sVe9w5vRw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "1c0Djlp090uBDczEobYNQw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "6SyCoJCgo0Wd6qlPlnMOtg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Il4VmrnjDkqjmjzddqoIEw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "A5M-yf9tgUihq1uab3v58g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "mL3zCEuy2UWZxAV4V-OsMA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "-hy0qD-iUk-v4NHxNzanmg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "YEfbJTnsR0yT_p7e7tb_kQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "xHOwjwpXd0GDkvBz2VqieA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "VQSgL2pTLkWx4B3kwYG7UA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "lag2tZyB90W04lQ7ol4vMw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "xwQWBB_fekmTqRc2LB92cg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "ZuvkidodzkuOfGLDnTOFyg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "JxAl1wVJ1UGAjoT3m3ilug",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "iiGTvhOCHkOTNJhb16Zbyw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Efd3_dy4ZEqWr7i6j5x0aA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "EmPvh3I6L0uK_1i8Wy_ylQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Sk_1sm88ZU2zpWn01Lv7hw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "5hIAZ9wg5EyG1cILf4FS2A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "BbJb1_0g4EGJP_CeNrjpew",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "mMCGPgK3tki5S_15q2Z81A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "lWN_g4OcN0S0C4n6cSZq4g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "K9RbXo-4U0q6NbGu8VL1Sw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "KFd3wxfnfUybCVkfj1pz1A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "uswFSANaZES0EJMLfOgNSw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "6F-kHEhKp0-jYli7fP5yIQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "F4SOI0n8k0eo21jvbxsERA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "7OZ5AE3uuUyqa0P-2W1ptg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "_jnjYGBcyEWY5Ub4OezXcA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "-_VNAj3P10aWCCJZoVTF4Q",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "P15H1ONBhk-5DYYjid1ttg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "mq23W-RSP0G8iGNLdrcpUw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "QRx0aSTT9keMFdAJMQHdTg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "4TGctDRPiE2GWiP3CKQqLw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "YNaldB09Kk2kiWVzrmNUGQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "uMHrUPLYFk2rJOW_uop5Aw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "LwaotjVEBUir0-w8126n_g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "JfnVXFmilU6ysv-VbTAe3A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "InQ25wQMGkG_bvuD5rf2Ag",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "jdrRJ7deWk2P9aRRrPy3zw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "wUCIKdJSvEmiQHYMyx4X4w",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "lFivdMXwHk2eMhmngMB8yA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "4My42w1D1Uu3-98pXB-x_Q",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "YpL6eN6sKEquOYIYnbhvew",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "ZtZnYBpKkECJlhHmkj4MiA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "g3kxdlJv5kO8PuBXveM48w",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "wx--2TPTdEuGAqLCjs9Qag",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "XOZcxx-Klkyhe-MDbTqiwA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "uGVFydNSokCXFAmXu3aceQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "EAhk3ZZdXEmH5wRAXXT24Q",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Av-wvjXvvkmNVSz7ZZnTiA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "5AJin8T2iEG7BzOPOgx2HA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "U38Qe6rhEk6mFvArHfYjng",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "yvqSbK2czkS2sUCRdrGaEw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "J1WqFNUWo0OBi4LGKPDHWw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "hRdK6NGfAkGBmYSs_xGzXg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "xr45B5QC4EyKXThtwZto_A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "JwJeh15cjkOc9WWaGRibDQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "3R1bzI35fkChoFFRFbponQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "x9ntSHto50GpNWPwYCLUEg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "4L3JoaqkAUa1kz98nciPXw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "YaVzcoefhk6zjbNDELLx8A",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "iEtWDLmv7ES87J4NE_TGJQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "jA3zzS31zEitBxtRCk7oew",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "P7HixsdkskmzgFMdFJ-WdA",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "5Ugg8k19n0WH8GPFCDWTCQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "P1kCuPlRc0-NAg6JUlEH_g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Hh_O_RejGE-_PubyM8xHaw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "s2pxukIEt0uDeGVJmZayOw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "vXL0rrAk70SFxJlaJk0uqQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "UAOH6ccEbEmehJg8XW_D8w",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "o0hG5O_eaUO0R8vPyW-Hvg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "xRtKWR-D40GUW43R0EFpNg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "AQTYAh1it0GIGdgGO5sUHQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "8vlVslaWaUyFS-iDHhxW9g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "STFKahjHJ0SQJPfoDe4S1g",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "eJh_BQ5y4UWwiMJzBKcwMQ",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "inIuPzhhOEmz1RI8mZtSLg",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "50oCPkzd3EerBd7nYNdkCw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    }, {
      "Ids": [random.randint(567, 2839289392)],
      "CreatedAts": [output_date],
      "ConsumableItemDesc": "Tpxqe_lycUelySRHM8B0Vw",
      "Count": 10000,
      "InitialCount": 10000,
      "IsActive": False,
      "ActiveDurationMinutes": 999,
      "IsTransferable": False
    })

@app.errorhandler(404)
def funnyhandler(gay):
  global headers
  headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP'
  }

  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  if ("Content-Length" in request.headers):
    headers["Content-Length"] = request.headers.get('Content-Length')
  if ("X-Rnsig" in request.headers):
    headers["X-Rnsig"] = request.headers.get('X-Rnsig')
  url = request.full_path
  url=url.split("/")
  endpoint=url[1]
  url.pop(1)
  url='/'.join(url)
  
  
  newUrl="https://"+endpoint+".rec.net"+url
  print(newUrl)
  print(headers)
  if request.full_path.startswith("/img/") or request.full_path.startswith("/cdn/"):
    return redirect(newUrl)
  if request.method == 'GET':
    print(newUrl)
    if request.full_path.startswith("/auth/role/"):
      return "true"
      
    redirectresponse = requests.get(newUrl, headers=headers)
    try:
      jsonResponse = redirectresponse.json()
      if len(json.dumps(jsonResponse))<2500:
        print(jsonResponse)
      if request.full_path.startswith("/econ/api/storefronts/v3/giftdropstore/3"):
        hoeshirts=[
          {"GiftDrop":{"GiftDropId":37551,"FriendlyName":"Hockey Shirt","Tooltip":"","TagList":null,"ConsumableItemDesc":"","AvatarItemDesc":"d6b0a1e7-e918-43e5-8191-3a8d9d01df7c,","AvatarItemType":0,"EquipmentPrefabName":"","EquipmentModificationGuid":"","IsQuery":false,"QueryRedirectContext":null,"QueryRedirectRarity":null,"Unique":false,"SubscribersOnly":false,"Rarity":50,"Context":0,"Currency":0,"CurrencyType":0,"ItemSetId":null,"ItemSetFriendlyName":""},"PurchasableItemId":25101,"Type":0,"Prices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"SubscriberPrices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"IsFeatured":false,"NewUntil":null,"AvailableAt":null,"AvailableUntil":null},{"GiftDrop":{"GiftDropId":37552,"FriendlyName":"Hockey Shirt","Tooltip":"","TagList":null,"ConsumableItemDesc":"","AvatarItemDesc":"d6b0a1e7-e918-43e5-8191-3a8d9d01df7c,fcbdfbfd-254a-4538-b119-43e23404b8b5,e5635772-4e84-4b30-b77f-4a1196cb599b,","AvatarItemType":0,"EquipmentPrefabName":"","EquipmentModificationGuid":"","IsQuery":false,"QueryRedirectContext":null,"QueryRedirectRarity":null,"Unique":false,"SubscribersOnly":false,"Rarity":50,"Context":0,"Currency":0,"CurrencyType":0,"ItemSetId":null,"ItemSetFriendlyName":""},"PurchasableItemId":25102,"Type":0,"Prices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"SubscriberPrices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"IsFeatured":false,"NewUntil":null,"AvailableAt":null,"AvailableUntil":null},{"GiftDrop":{"GiftDropId":37553,"FriendlyName":"Hockey Shirt","Tooltip":"","TagList":null,"ConsumableItemDesc":"","AvatarItemDesc":"d6b0a1e7-e918-43e5-8191-3a8d9d01df7c,b1ea158d-1663-4db1-bb09-9847f6e9d1e6,e5635772-4e84-4b30-b77f-4a1196cb599b,","AvatarItemType":0,"EquipmentPrefabName":"","EquipmentModificationGuid":"","IsQuery":false,"QueryRedirectContext":null,"QueryRedirectRarity":null,"Unique":false,"SubscribersOnly":false,"Rarity":50,"Context":0,"Currency":0,"CurrencyType":0,"ItemSetId":null,"ItemSetFriendlyName":""},"PurchasableItemId":25103,"Type":0,"Prices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"SubscriberPrices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"IsFeatured":false,"NewUntil":null,"AvailableAt":null,"AvailableUntil":null},{"GiftDrop":{"GiftDropId":37554,"FriendlyName":"Hockey Shirt","Tooltip":"","TagList":null,"ConsumableItemDesc":"","AvatarItemDesc":"d6b0a1e7-e918-43e5-8191-3a8d9d01df7c,d5efaf80-7f34-4c9a-bc3a-b80b1ac70ace,e5635772-4e84-4b30-b77f-4a1196cb599b,","AvatarItemType":0,"EquipmentPrefabName":"","EquipmentModificationGuid":"","IsQuery":false,"QueryRedirectContext":null,"QueryRedirectRarity":null,"Unique":false,"SubscribersOnly":false,"Rarity":50,"Context":0,"Currency":0,"CurrencyType":0,"ItemSetId":null,"ItemSetFriendlyName":""},"PurchasableItemId":25104,"Type":0,"Prices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"SubscriberPrices":[{"CurrencyType":2,"Price":0,"StorefrontSaleData":null}],"IsFeatured":false,"NewUntil":null,"AvailableAt":null,"AvailableUntil":null}]
        conn = jsonResponse["StoreItems"]
        for f in hoeshirts:
          conn.append(f)
        jsonResponse["StoreItems"]=conn
      jsonResponse=jsonify(jsonResponse)
      jsonResponse.headers.add('Access-Control-Allow-Origin', '*')
      return jsonResponse
    except:
      response=make_response()
      response.raw = redirectresponse.raw
      response.text=redirectresponse.text
      response.status_code=redirectresponse.status_code
      response.headers.add('Access-Control-Allow-Origin','*')
      return response
     
  elif request.method == 'DELETE':
    redirectresponse = requests.delete(newUrl, headers=headers,data=request.data)
    try:
      jsonResponse = redirectresponse.json()
      if len(json.dumps(jsonResponse))<2500:
        print(jsonResponse)
      jsonResponse=jsonify(jsonResponse)
      jsonResponse.headers.add('Access-Control-Allow-Origin', '*')
      return jsonResponse
    except:
      response=make_response()
      response.raw = redirectresponse.raw
      response.text=redirectresponse.text
      response.headers.add('Access-Control-Allow-Origin','*')
      return response
    
  elif request.method == 'POST':
    
    ct=request.content_type or ""
    data=""
    if (ct.startswith('application/json')):
      headers['Content-Type']= 'application/json'
      data = request.json
    elif (ct.startswith(
        "application/x-www-form-urlencoded")):
      headers['Content-Type']= 'application/x-www-form-urlencoded'
      data = request.form.to_dict()
    elif (ct.startswith(
        "multipart/form-data")):
      headers['Content-Type']= request.content_type
      data = dict(request.files)
    print(ct)
    print(data)
    if data:
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
    else:
      redirectresponse = requests.post(newUrl, headers=headers)
    try:
      jsonResponse = redirectresponse.json()
      print(jsonResponse)
      if request.full_path.startswith("/auth/connect/token"): #and (str(request.form.get("platform"))=="5" or str(request.form.get("platform"))=="6"):
        f = open("authtoken", "w")
        f.write(json.dumps(jsonResponse))
        f.close()
      jsonResponse=jsonify(jsonResponse)
      jsonResponse.headers.add('Access-Control-Allow-Origin', '*')
      return jsonResponse
    except:
      try:
        response=make_response()
        response.raw = redirectresponse.raw
        response.text=redirectresponse.text
        print(redirectresponse.status_code)
        response.headers.add('Access-Control-Allow-Origin','*')
        return response
      except:
        return Response(status=200)
     
  elif request.method == 'PUT':
    ct=request.content_type or ""
    data=""
    if (ct.startswith('application/json')):
      headers['Content-Type']= 'application/json'
      data = request.json
    elif (ct.startswith(
        "application/x-www-form-urlencoded")):
      headers['Content-Type']= 'application/x-www-form-urlencoded'
      data = request.form.to_dict()
    elif (ct.startswith(
        "multipart/form-data")):
      headers['Content-Type']= request.content_type
      data = dict(request.files)
    if data=="":
      redirectresponse = requests.put(newUrl, headers=headers)
    else:
      redirectresponse = requests.put(newUrl, headers=headers, data=data)
    try:
      jsonResponse = redirectresponse.json()
      if len(json.dumps(jsonResponse))<2500:
        print(jsonResponse)
      jsonResponse=jsonify(jsonResponse)
      print(redirectresponse.headers)
      jsonResponse.headers.add('Access-Control-Allow-Origin', '*')
      return jsonResponse
    except:
      response=make_response()
      response.raw = redirectresponse.raw
      response.text=redirectresponse.text
      print(redirectresponse.status_code)
      response.headers.add('Access-Control-Allow-Origin','*')
      return response

if __name__ == "__main__":
  app.run("0.0.0.0", 8080)
