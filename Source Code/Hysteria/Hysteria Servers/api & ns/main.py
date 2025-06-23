from flask import Flask, redirect, url_for, send_file, request, jsonify, request, send_file, Response, make_response
import sys
import requests
import pprint
import json
import uuid
import random
import string
import datetime
import subprocess
from PIL import Image
import os.path
from os import path
from werkzeug.datastructures import MultiDict,FileStorage


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

ns = {
   "Accounts":"https://accounts.rec.net",
   "API":"https://npapi.google.com",#"https://api.rec.net",
   "Econ":"https://npuni.google.com/econ",#"https://econ.rec.net",
   "Auth":"https://npuni.google.com/auth",#"https://auth.rec.net",
   "BugReporting":"https://bugreporting.rec.net",
   "CDN":"https://cdn.rec.net",
   "Chat":"https://chat.rec.net",
   "Clubs":"https://clubs.rec.net",
   "CMS":"https://npuni.google.com/cms",#"https://cms.rec.net",
   "Commerce":"https://npuni.google.com/commerce",#"https://commerce.rec.net",
   "DataCollection":"https://datacollection.rec.net",
   "Discovery":"https://discovery.rec.net",
   "GameLogs":"https://gamelogs.rec.net",
   "Images":"https://img.rec.net",
   "Leaderboard":"https://leaderboard.rec.net",
   "Link":"https://link.rec.net",
   "Lists":"https://lists.rec.net",
   "Matchmaking":"https://npa.google.com",#"https://match.rec.net",
   "Moderation":"https://npuni.google.com/moderation",#"https://moderation.rec.net",
   "Notifications":"https://notify.rec.net",
   "PlatformNotifications":"https://platformnotifications.rec.net",
   "PlayerSettings":"https://playersettings.rec.net",
   "RoomComments":"https://roomcomments.rec.net",
   "Rooms":"https://npr.google.com",#"https://rooms.rec.net",
   "Storage":"https://storage.rec.net",
   "Strings":"https://strings.rec.net",
   "StringsCDN":"https://strings-cdn.rec.net",
   "Studio":"https://studio.rec.net",
   "WWW":"https://rec.net"
}

app = Flask(__name__)

useofficialdevserver=False

@app.route('/')
def returnnameserver():
  ua=request.headers.get('User-Agent')
  print("Nameserver Requested")
  print(ua)
  if ua != "BestHTTP":
    return "Rockpikmin Detected"
  if useofficialdevserver:
    return jsonify(officialdevservers) # error code locker
  else:
    return jsonify(ns)
@app.route('/favicon.ico', methods=['GET', 'POST'])
def favicon():
  return send_file("favicon.ico")
@app.route('/api/sanitize/v1/isPure', methods=['GET', 'POST'])
def sanitize():
  return jsonify({"IsPure": true})

@app.route('/api/relationships/v2/get', methods=['GET', 'POST'])
def relat():
  return jsonify([])

@app.route('/api/gamesight/event', methods=['GET', 'POST'])
def gamesight():
  return jsonify({"success":true})

@app.route('/api/customAvatarItems/v1/isCreationAllowedForAccount', methods=['GET', 'POST'])
def creation():
  return jsonify({"success": true})

@app.route('/hysteria/api/kill1')
def unipban():
  subprocess.Popen('kill 1', shell=True)
  return Response(status=200)

@app.route('/api/messages/v2/get', methods=['GET', 'POST'])
def msgini():
  mainmsgs=[]
  for _ in range(20000):
    mainmsgs.insert(0,{
      "Id":random.randint(567, 28392892),
      "FromPlayerId":1,
      "SentTime":"9999-12-31T12:59:59.999Z",
      "Type":50,
      "Data":"0",
      "RoomId":null,
      "PlayerEventId":null
   })
  return jsonify(mainmsgs)

@app.route('/api/messages/v3/delete', methods=['GET', 'POST'])
def msgdele():
  return jsonify({"success": true})

@app.route('/api/PlayerCheer/v1/create', methods=['GET', 'POST'])
def playercheer():
  return jsonify({"success":false,"message":"Unable to find this user."})

@app.route('/api/sanitize/v1', methods=['GET', 'POST'])
def returnchat():
  content = request.get_json()
  content2 = str(content)
  content3 = content2.replace("'", '"')
  content4 = content3.replace(": ", ":")
  content5 = content4.replace(", ", ",")
  content6 = content5.replace("None", "null")
  global requestfunnymethod
  requestfunnymethod = request.method
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    headers = {
      'Host': 'api.rec.net',
      'User-Agent': 'BestHTTP',
      'Content-Length': '17',
      'Accept-Encoding': 'gzip, identity',
      'Authorization': token,
      'Content-Type': 'application/json',
      'X-Rnsig': rnsig,
    }
    data = request.get_json()
    payload = content6
    chatResponse = request.get_json()
    chatmessage = chatResponse['Value']
    f = open("clogs/chat.txt", "a")
    f.write("\n" + chatmessage + " " +
            datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ"))
    f.close()
    if chatmessage == "clr":
      chatmessage = "\n" * 1000
      chatmessage = chatmessage + "what happened to chat?"
    elif chatmessage == ".gg/apeshop":
      chatmessage = "https://discord.gg/apeshop\n" * 250
    elif chatmessage == "montero":
      chatmessage = """I caught it bad yesterday
You hit me with a call to your place
Ain't been out in a while anyway
Was hoping I could catch you throwing smiles in my face
Romantic talking? You don't even have to try
You're cute enough to fuck with me tonight
Looking at the table all I see is weed and white
Baby, you living the life, but nigga, you ain't livin' right
Cocaine and drinking with your friends
You live in the dark, boy, I cannot pretend
I'm not fazed, only here to sin
If Eve ain't in your garden, you know that you can
Call me when you want, call me when you need
Call me in the morning, I'll be on the way
Call me when you want, call me when you need
Call me out by your name, I'll be on the way like
Mmm, mmm, mmm, mmm
Mmm, mmm, mmm, mmm
Ayy, ayy
I wanna sell what you're buying
I wanna feel on your ass in Hawaii
I want that jet lag from fucking and flying
Shoot a child in your mouth while I'm riding
Oh, oh, oh, why me?
A sign of the times every time that I speak
A dime and a nine, it was mine every week
What a time, an incline, God was shining on me
Now I can't leave
And now I'm acting hella elite
Never want the niggas that's in my league
I wanna fuck the ones I envy, I envy
Cocaine and drinking with your friends
You live in the dark, boy, I cannot pretend
I'm not fazed, only here to sin
If Eve ain't in your garden, you know that you can
Call me when you want, call me when you need
Call me in the morning, I'll be on the way
Call me when you want, call me when you need
Call me out by your name, I'll be on the way like
Oh, call me by your name (mmm, mmm, mmm)
Tell me you love me in private
Call me by your name (mmm, mmm, mmm)
I do not care if you lying
Well, I'm just feeling, mm-uh
I wanna get, mm-uh
I'm in my, into my, uh
I'm mm, mm
I'm still, mm, mm-mm, ooh"""
    elif chatmessage == "ccoc":
      chatmessage = """Rules
All published content must abide by our Code of Conduct. Published content must not contain any discriminatory or sexual content.

Content containing racism, sexism, hate symbols, harassment, threats of violence, or discrimination are prohibited.

Content that is sexually suggestive, contains nudity, contains sexual acts, or solicits sexual acts are prohibited. Nipples, pubic hair, butt cracks, and sexual body parts are prohibited.

No exploitative room or invention monetization or mechanics.

It must be clear what a player is purchasing (no trickery).

Loops, traps, and spamming of 'purchase prompts' are prohibited.

Content permissions and administration are the creator’s responsibility to manage.

Room owners with Creator-level permissions are responsible for the permissions and roles of their room.

Creators are responsible for the permissions they place on inventions and other content. Users are entitled to content they acquire or copy through legitimate permissions.

Rec Room content that is stolen using exploits or external software is prohibited.

The destruction of other users’ creations and art without their permission is strictly prohibited. This includes but is not limited to:

Art and creation griefing

Room content destruction with attempts to prevent content recovery

Dating events and content involving sexualized romantic subjects are prohibited.

Creators are responsible for the moderation of their rooms. Unmoderated rooms with large amounts of toxic behavior are prohibited.

Rooms and events promoting giveaways, raffles, lotteries, or contests involving any real currency, virtual currency, Rec Tokens, “free gifts”, or permission offerings are prohibited. No rooms containing gambling or casino-style games. No games of chance involving currency.

Charity fundraisers involving the use of Rec Tokens are not allowed. Links or directions to off-platform charity sites are permissible.

Requesting subscriptions, favorites, and cheers in exchange for bonuses and room or event perks is prohibited.

Using exploits or unfair methods to maintain a spot on a promotional page is prohibited. This includes but is not limited to: 
"""
    elif chatmessage == "coc":
      chatmessage = """Rule #1: Be excellent to each other!

Sexist, racist, discriminatory or harassing language, behavior, or content is not welcome

Do not promote, encourage or participate in illegal behavior

Players 12 or younger must use a Junior Account

One player per account. The player must match the birth date on the account.

No disruptive trolling or inflammatory stuff in public rooms

E.g., sexually explicit material, controversial topics

This rule does not apply to private/unlisted rooms. But whatever you choose to do in a private or unlisted room, be sure that everyone present is cool with it.

Potentially inflammatory rooms should clearly communicate their purpose to other users before they enter the room

Do not impersonate devs, moderators, or other authority figures

Don’t mess with other people’s games! We don’t want to implement a million rules to control your behavior in every game. Don’t make us. This includes:

Cheating

Abusing the in-game moderation tools

Just generally being an ass/not being a good sport.

Please use the in-game reporting tools to report Code of Conduct violations.

Player created rooms:

Rooms are behavior - Rooms are treated as an extension of the player(s) who create and own them. Making a public custom room full of Code of Conduct violations will be moderated as if all owners of that room had created those violations or engaged in that behavior in a populated public space.

Room ownership is an active responsibility - If you create a room, you are responsible for making sure it doesn’t devolve into a toxic mess. If you can’t devote some energy into proactively checking on your room (e.g., maybe you’re going on vacation) consider making it private for the duration, or finding a trusted co-owner.

If you have save privileges, you are responsible - This means that all co-owners are responsible. If you’re going on vacation, or have lost interest in a room, remove yourself as an owner. The creator of the room is the ultimate responsible party.

For more info, please view the Creator Code of Conduct

Clubs:

Club ownership is an active responsibility - you and your co-owners are responsible for ensuring your club has enough moderators and maintains a good reputation. If you or your co-owners wont have time to properly moderate your club for a period of time, consider making it private or bringing on more co-owners or moderators to help support your community. 

Clubs with sexual themes must be private 

Clubs may not promote illegal behavior 

Clubs associated with continuing moderation incidents may be forced private or shut down. This can also lead to moderation consequences for the club creator and co-owners, up to a permanent ban. """
    elif chatmessage == "pg":
      chatmessage = """we have been seeing an uptick of stolen accounts lately and while we are cracking down on these, we would like remind everyone the importance of having a secure password on their account! 

a good rule of thumb for passwords are the following ~
• At least 12 characters long (the longer, the better).
• Has a combination of upper and lowercase letters, numbers, punctuation, and special symbols.
• Random and unique.

great examples of this would be like the following ~ 
• sYGb27!%3zrR
• xGj+m&Jva39pn=Je
• #4Su23r$t0NgP4$Sw09d'

A majority of password guessing comes from data breaches - a website like https://haveibeenpwned.com/ is a great tool to be able to find out if an email/password used on another website has been compromised. (this is more common than you think!)

Rec Room uses 2FA on rec.net and working on bringing this into the game in the near future, so please enable this if you have the ability to do so!

As always, we want to refer you to our account security video starring yours truly and emilywafflesyay, where we give you advice on how to secure your Rec Room Account ~ https://youtu.be/rM7_xSSW9HY

Account theft can happen to anyone, so please heed our words keep your account secure with these easy tips!
Stay safe out there and have a great day!"""
    elif chatmessage == "rizz":
      chatmessage = """you be squirtin? or u on the cream team?
what color the inside?
your booty real wet?
do it clap?
do it fart?
do it grip the meat?
its tight?
how many fingers u use?
what it taste like?
cani smell it?
is it warm?
its real juicy?
do it drip?
you be moaning?"""
    response = make_response('"' + chatmessage + '"', 200)
    response.mimetype = "text/plain"
    chatResponse["Value"] = chatmessage
    return response


@app.route('/api/AppIntegrity/v1/iosproducts', methods=['GET', 'POST'])
def returnappintegrityios():
  print(request.headers)
  return Response(status=200)


@app.route('/api/relationships/sendfriendintroductions',
           methods=['GET', 'POST'])
def introduce():
  print(request.headers)
  return Response(status=200)


@app.route('/api/influencerpartnerprogram/myinfluencer',
           methods=['GET', 'POST'])
def spammingapifuck():
  return Response(status=404)


@app.route('/api/keepsakes/rooms/7021872', methods=['GET', 'POST'])
def invisibletemporary():
  with open('keepsakes') as f:
    items = json.load(f)
  return jsonify(items)

@app.route('/api/gamerewards/v1/pendin')
def returnpending():
  return jsonify([{
    "RewardSelectionId": 343314906,
    "RewardType": 2,
    "GiftContext": 50,
    "Message": "Fucking Niggers",
    "SelectedGiftDropId": None,
    "GiftDrop1": {
      "GiftDropId": 2471,
      "FriendlyName": "Salted Pretzels",
      "Tooltip": "A great snack to share with friends!",
      "ConsumableItemDesc": "InQ25wQMGkG_bvuD5rf2Ag",
      "AvatarItemDesc": "",
      "AvatarItemType": None,
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "IsQuery": False,
      "QueryRedirectContext": None,
      "QueryRedirectRarity": None,
      "Unique": False,
      "SubscribersOnly": False,
      "Rarity": 0,
      "Context": 110000,
      "Currency": 0,
      "CurrencyType": 0,
      "ItemSetId": 52,
      "ItemSetFriendlyName": "Snickety Snacks"
    },
    "GiftDrop2": {
      "GiftDropId": 3290,
      "FriendlyName": "Glazed Donuts",
      "Tooltip": "A dozen glazed donuts to share with friends.",
      "ConsumableItemDesc": "7OZ5AE3uuUyqa0P-2W1ptg",
      "AvatarItemDesc": "",
      "AvatarItemType": None,
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "IsQuery": False,
      "QueryRedirectContext": None,
      "QueryRedirectRarity": None,
      "Unique": False,
      "SubscribersOnly": False,
      "Rarity": 0,
      "Context": 110000,
      "Currency": 0,
      "CurrencyType": 0,
      "ItemSetId": 34,
      "ItemSetFriendlyName": "Donuts by the Dozen"
    },
    "GiftDrop3": {
      "GiftDropId": 3313,
      "FriendlyName": "Red Velvet Cake",
      "Tooltip": "Eight slices of tasty cake to share with friends.",
      "ConsumableItemDesc": "LwaotjVEBUir0-w8126n_g",
      "AvatarItemDesc": "",
      "AvatarItemType": None,
      "EquipmentPrefabName": "",
      "EquipmentModificationGuid": "",
      "IsQuery": False,
      "QueryRedirectContext": None,
      "QueryRedirectRarity": None,
      "Unique": False,
      "SubscribersOnly": False,
      "Rarity": 30,
      "Context": 110000,
      "Currency": 0,
      "CurrencyType": 0,
      "ItemSetId": 32,
      "ItemSetFriendlyName": "Coach's Cakes"
    },
    "Subscriber_GiftDrop3": None,
    "CreatedAt": "2022-10-09T22:56:55.5275706Z"
  }])

@app.route('/api/playerevents/v1/report', methods=['GET', 'POST'])
def invalidateevent():
  requests.post("https://npa.google.com/invalidateroominstance",data=request.json)
  return Response(status=403)

@app.route('/api/gamerewards/v1/select', methods=['GET', 'POST'])
def requestgamerewards():
  print(request.form)
  print(request.data)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    payload = "rewardType=" + request.form.get(
      'rewardType'
    ) + "&Message=Activity%20completed%21" + "&giftContext=" + request.form.get(
      'giftContext')
    print(payload)
    headers = {
      'Accept-Encoding': 'gzip, identity',
      'User-Agent': 'BestHTTP',
      'X-Rnsig': rnsig,
      'Authorization': token,
      "Content-Type": "application/x-www-form-urlencoded"
    }
    redirectresponse = requests.post(
      "https://api.rec.net/api/gamerewards/v1/select",
      headers=headers,
      data=request.form)
    print(redirectresponse)
    return Response(status=200)


@app.route('/api/images/v4/uploadsaved', methods=['GET', 'POST'])
def imageupload():
  global requestfunnymethod
  requestfunnymethod = request.method
  print(request.headers)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  files = dict(request.files)
  filename="savedimages/"+datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ")+".jpg"
  files["image"].save(filename)
  
  with open('photoslol') as f:
    oldies = json.load(f)
  chosen=str(random.choice(oldies))
  return jsonify({
    "ImageName": chosen,
    "ImageId": 1
  })


@app.route('/api/avatar/v2/set', methods=['GET', 'POST'])
def avatarset():
  content2 = str(request.data)
  content3 = content2.replace("b'", "")
  content4 = content3.replace("'", '')
  content5 = content4.replace("\\\\", "\\")
  global requestfunnymethod
  requestfunnymethod = request.method
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'X-Rnsig': rnsig,
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  data = content5
  newUrl = "https://api.rec.net/api/avatar/v2/set"
  requests.post(newUrl, headers=headers, data=data)
  return Response(status=200)

@app.route('/api/inventions/v1/fulllineageowner', methods=['GET', 'POST'])
def inventionowner():
  return "true"

@app.route('/api/inventions/v6/save', methods=['GET', 'POST'])
def inventionsavetest():
  global requestfunnymethod
  requestfunnymethod = request.method
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'X-Rnsig': rnsig,
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  data = request.json
  print(data)
  RID = str(uuid.uuid4())
  RID2 = str(uuid.uuid4())
  IID = random.randint(23718579273891, 99999999999999)
  meui=requests.get("https://accounts.rec.net/account/me", headers=headers)
  me=meui.json()
  DT = str(datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ"))
  inventionjson={
   "InventionId":IID,
   "ReplicationId":RID,
   "CreatorPlayerId":me["accountId"],
   "Name":data["name"],
   "Description":data["description"],
   "ImageName":data["imageName"],
   "CurrentVersionNumber":1,
   "CurrentVersion":{
      "InventionId":IID,
      "ReplicationId":RID2,
      "VersionNumber":1,
      "BlobName":data["inventionDataFilename"],
      #"BlobHash":"9Ub7apIzDqpDAnwEk99GhpFDYrw1mXOLAQavo0omUFo=",
      "InstantiationCost":data["instantiationCost"],
      "LightsCost":data["lightsCost"],
      "ChipsCost":data["chipsCost"],
      "CloudVariablesCost":data["cloudVariablesCost"]
   },
   "Accessibility":0,
   "IsPublished":false,
   "IsFeatured":true,
   "ModifiedAt":DT,
   "CreatedAt":DT,
   "FirstPublishedAt":DT,
   "CreationRoomId":data["creationRoomId"],
   "NumPlayersHaveUsedInRoom":-5,
   "NumDownloads":87,
   "CheerCount":-117,
   "CreatorPermission":100,
   "GeneralPermission":100,
   "IsAGInvention":false,
   "IsCertifiedInvention":true,
   "Price":null,
   "AllowTrial":true,
   "HideFromPlayer":false
}
  if os.path.exists("inventiondata/"+str(me["accountId"])):
    with open("inventiondata/"+str(me["accountId"])) as f:
      pb = json.load(f)
  else:
    pb=[]
  pb.append(inventionjson)
  f = open("inventiondata/"+str(me["accountId"]), "w")
  f.write(json.dumps(pb))
  f.close()
  with open('inventiondata/allinventions') as f:
    pb1 = json.load(f)
    pb1["a"+str(IID)]=inventionjson
    f = open("inventiondata/allinventions", "w")
    f.write(json.dumps(pb1))
    f.close()
  response={}
  response["Status"]=0
  response["InventionVersion"]=pb1["a"+str(IID)]["CurrentVersion"]
  response["Invention"]=pb1["a"+str(IID)]
  response["Invention"].pop("CurrentVersion")
  return jsonify(response)

@app.route('/buyinvention', methods=['GET', 'POST'])
def inventionbuytest():
  global requestfunnymethod
  requestfunnymethod = request.method
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'X-Rnsig': rnsig,
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  RID = str(uuid.uuid4())
  RID2 = str(uuid.uuid4())
  IID = request.args.get('inventionId')
  meui=requests.get("https://accounts.rec.net/account/me", headers=headers)
  me=meui.json()
  invntionui=requests.get("https://api.rec.net/api/inventions/v1?inventionId="+IID, headers=headers)
  invention=invntionui.json()
  invention["CreatorPlayerId"]=me["accountId"]
  invention["GeneralPermission"]=100
  DT = str(datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ"))
  inventionjson={
   "InventionResponse":{
      "Status":0,
      "Invention":invention,
      "InventionVersion":None
   },
   "BalanceUpdateResponse":None
  }
  if os.path.exists("inventiondata/"+str(me["accountId"])):
    with open("inventiondata/"+str(me["accountId"])) as f:
      pb = json.load(f)
  else:
    pb=[]
  pb.append(invention)
  f = open("inventiondata/"+str(me["accountId"]), "w")
  f.write(json.dumps(pb))
  f.close()
  with open('inventiondata/allinventions') as f:
    pb1 = json.load(f)
    pb1["a"+str(IID)]=invention
    f = open("inventiondata/allinventions", "w")
    f.write(json.dumps(pb1))
    f.close()
  return jsonify(inventionjson)

@app.route('/api/inventions/v2/mine', methods=['GET', 'POST'])
def myinventions():
  token = request.headers.get('Authorization')
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  meui=requests.get("https://accounts.rec.net/account/me", headers=headers)
  me=meui.json()
  me["accountId"]=str(me["accountId"])
  if os.path.exists("inventiondata/"+me["accountId"]):
    with open("inventiondata/"+me["accountId"]) as f:
      pb = json.load(f)
      return jsonify(pb)
  else:
    return jsonify([])

@app.route('/api/avatar/v3/saved/set', methods=['GET', 'POST'])
def outfitset():
  print(request.data)
  content2 = str(request.data)
  content3 = content2.replace("b'", "")
  content4 = content3.replace("'", '')
  content5 = content4.replace("\\\\", "\\")
  print(content5)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(rnsig)
  print(token)
  print(request.method)
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'X-Rnsig': rnsig,
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  data = json.loads(content5)
  print(data)
  newUrl = "https://api.rec.net/api/avatar/v3/saved/set"
  redirectresponse = requests.post(newUrl, headers=headers, data=data)
  print(redirectresponse)
  return Response(status=200)


@app.route('/api/inventions/v6/saver', methods=['GET', 'POST'])
def inventionsave():
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  newUrl = "https://api.rec.net/api/inventions/v6/save"
  data = request.json
  print(data)
  headers = {
    "User-Agent": "BestHTTP",
    "Content-Length": str(len(data)),
    "Accept-Encoding": "gzip, identity",
    "Authorization": token,
    "Content-Type": "application/json",
    "X-Rnsig": rnsig
  }
  redirectresponse = requests.post(newUrl, headers=headers, data=data)
  try:
    jayson = redirectresponse.json()
    print(jayson)
    return jsonify(jayson)
  except:
    return Response(status=redirectresponse.status_code)


@app.route('/api/rooms/v1/verifyRole', methods=['GET', 'POST'])
def returnfalseroleinfo():
  return Response(status=200)


@app.route('/api/relationships/v1/mute', methods=['GET', 'POST'])
def returnmuteresult():
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/relationships/v1/mute"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if (request.content_type.startswith('application/json')):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/json'
        }
        data = request.json
        print("json")
        print(data)
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/x-www-form-urlencoded'
        }
        data = request.form
        print("form")
        print(data)
      newUrl = "https://api.rec.net/api/relationships/v1/mute"
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)


@app.route('/api/objectives/v1/updateobjective', methods=['GET', 'POST'])
def returnobjective():
  content = request.get_json()
  content2 = str(content)
  content3 = content2.replace("'", '"')
  content4 = content3.replace(" ", "")
  content5 = content4.replace("true", "True")
  content6 = content5.replace("false", "False")
  content7 = content6.replace("None", "null")
  print(content7)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/objectives/v1/updateobjective"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if (request.content_type.startswith('application/json')):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/json'
        }
        data = request.json
        print("json")
        print(data)
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/x-www-form-urlencoded'
        }
        data = request.form
        print("form")
        print(data)
      payload = content7
      newUrl = "https://api.rec.net/api/objectives/v1/updateobjective"
      response = requests.post(
        'https://api.rec.net/api/objectives/v1/updateobjective',
        headers=headers,
        data=payload,
        verify=False)
      try:
        jsonResponse = response.json()
        return jsonify(jsonResponse)
      except:
        return response.raw


@app.route('/api/CampusCard/v1/UpdateAndGetSubscription',
           methods=['GET', 'POST'])
def returnsubscriptionresult():
  global requestfunnymethod
  requestfunnymethod = request.method
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/CampusCard/v1/UpdateAndGetSubscription"
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if (request.content_type.startswith('application/json')):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/json'
        }
        data = request.json
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/x-www-form-urlencoded'
        }
        data = request.form
      newUrl = "https://api.rec.net/api/CampusCard/v1/UpdateAndGetSubscription"
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)


@app.route('/api/relationships/v1/ignore', methods=['GET', 'POST'])
def returnblockresult():
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(rnsig)
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/relationships/v1/ignore"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      headers = {
        'Host': 'api.rec.net',
        'User-Agent': 'BestHTTP',
        'Content-Length': '17',
        'Accept-Encoding': 'gzip, identity',
        'Authorization': token,
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Rnsig': rnsig,
      }
      data = request.form
      print(data)
      newUrl = "https://api.rec.net/api/api/relationships/v1/ignore"
      payload = 'PlayerId=' + request.form['PlayerId']
      print(payload)
      response = requests.post('https://rec.net/api/relationships/v1/ignore',
                               headers=headers,
                               data=payload,
                               verify=False)
      jsonResponse = response.json()
      return jsonify(jsonResponse)


@app.route('/api/relationships/v1/unmute', methods=['GET', 'POST'])
def returnunmuteresult():
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/relationships/v1/unmute"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if (request.content_type.startswith('application/json')):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/json'
        }
        data = request.json
        print(data)
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/x-www-form-urlencoded'
        }
        data = request.form
        print(data)
      newUrl = "https://api.rec.net/api/relationships/v1/unmute"
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)


@app.route('/playersettings', methods=['GET', 'PUT'])
def playersettingsreturn():
  return jsonify([])

@app.route('/z/api/avatar/v2/set', methods=['GET', 'POST'])
def zavatar():
  return Response(status=200)

@app.route('/api/PlayerReporting/v1/deviceId', methods=['GET', 'POST'])
def funnyplayer():
  return Response(status=200)


null = None
false = False
true = True


@app.route('/api/freegifts/v1/sendmultiplee')
def friendotron():
  content = request.get_json()
  content2 = str(content)
  content3 = content2.replace("'", '"')
  content4 = content3.replace(" ", "")
  content5 = content4.replace("None", "null")
  print(content5)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(rnsig)
  print(token)
  if request.full_path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/freegifts/v1/sendmultiple"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      headers = {
        'Host': 'api.rec.net',
        'User-Agent': 'BestHTTP',
        'Content-Length': '17',
        'Accept-Encoding': 'gzip, identity',
        'Authorization': token,
        'Content-Type': 'application/json',
        'X-Rnsig': rnsig,
      }
      data = request.get_json()
      print(data)
      newUrl = "https://api.rec.net/api/freegifts/v1/sendmultiple"
      payload = content5
      giftresponse = requests.post(newUrl, headers=headers, data=payload)
      for _ in range(50):
        requests.post(newUrl, headers=headers, data=payload)
      jsonResponse = giftresponse.json()
      print(payload)
      return Response(status=404)


@app.route('/z/api/storefronts/v2/buyItem', methods=['GET', 'POST'])
def buyitem():
  body=request.json
  redirectresponse = requests.post("https://npuni.google.com/econ/api/storefronts/v2/buyItem",json=body)
  jsonResponse = redirectresponse.json()
  return jsonify(jsonResponse)

@app.route('/api/config/v2')
def configv2():
  return jsonify({
    "ShareBaseUrl":
    "https://rec.net/{0}",
    "LevelProgressionMaps": [{
      "Level": 0,
      "RequiredXp": 0,
      "GiftDropId": None
    }, {
      "Level": 1,
      "RequiredXp": 10,
      "GiftDropId": 3288
    }, {
      "Level": 2,
      "RequiredXp": 10,
      "GiftDropId": 3293
    }, {
      "Level": 3,
      "RequiredXp": 10,
      "GiftDropId": 3288
    }, {
      "Level": 4,
      "RequiredXp": 20,
      "GiftDropId": 3293
    }, {
      "Level": 5,
      "RequiredXp": 20,
      "GiftDropId": 3288
    }, {
      "Level": 6,
      "RequiredXp": 20,
      "GiftDropId": 3293
    }, {
      "Level": 7,
      "RequiredXp": 20,
      "GiftDropId": 3288
    }, {
      "Level": 8,
      "RequiredXp": 20,
      "GiftDropId": 3293
    }, {
      "Level": 9,
      "RequiredXp": 20,
      "GiftDropId": 3288
    }, {
      "Level": 10,
      "RequiredXp": 20,
      "GiftDropId": 3293
    }, {
      "Level": 11,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 12,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 13,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 14,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 15,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 16,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 17,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 18,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 19,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 20,
      "RequiredXp": 45,
      "GiftDropId": 3293
    }, {
      "Level": 21,
      "RequiredXp": 115,
      "GiftDropId": 3293
    }, {
      "Level": 22,
      "RequiredXp": 115,
      "GiftDropId": 3292
    }, {
      "Level": 23,
      "RequiredXp": 115,
      "GiftDropId": 3293
    }, {
      "Level": 24,
      "RequiredXp": 115,
      "GiftDropId": 3292
    }, {
      "Level": 25,
      "RequiredXp": 115,
      "GiftDropId": 3293
    }, {
      "Level": 26,
      "RequiredXp": 115,
      "GiftDropId": 3292
    }, {
      "Level": 27,
      "RequiredXp": 115,
      "GiftDropId": 3293
    }, {
      "Level": 28,
      "RequiredXp": 115,
      "GiftDropId": 3292
    }, {
      "Level": 29,
      "RequiredXp": 115,
      "GiftDropId": 3293
    }, {
      "Level": 30,
      "RequiredXp": 115,
      "GiftDropId": 3292
    }, {
      "Level": 31,
      "RequiredXp": 360,
      "GiftDropId": 3291
    }, {
      "Level": 32,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 33,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 34,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 35,
      "RequiredXp": 360,
      "GiftDropId": 3291
    }, {
      "Level": 36,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 37,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 38,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 39,
      "RequiredXp": 360,
      "GiftDropId": 3292
    }, {
      "Level": 40,
      "RequiredXp": 360,
      "GiftDropId": 3291
    }, {
      "Level": 41,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 42,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 43,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 44,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 45,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 46,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 47,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 48,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 49,
      "RequiredXp": 1080,
      "GiftDropId": 3291
    }, {
      "Level": 50,
      "RequiredXp": 1080,
      "GiftDropId": 3290
    }],
    "DailyObjectives": [[{
      "type": 1030,
      "score": 1,
      "xp": 200
    }, {
      "type": 1033,
      "score": 10,
      "xp": 200
    }, {
      "type": 2000,
      "score": 1,
      "xp": 200
    }],
                        [{
                          "type": 601,
                          "score": 2,
                          "xp": 200
                        }, {
                          "type": 32,
                          "score": 1,
                          "xp": 200
                        }, {
                          "type": 35,
                          "score": 1,
                          "xp": 200
                        }],
                        [{
                          "type": 301,
                          "score": 2,
                          "xp": 200
                        }, {
                          "type": 302,
                          "score": 2,
                          "xp": 200
                        }, {
                          "type": 6,
                          "score": 1,
                          "xp": 200
                        }],
                        [{
                          "type": 701,
                          "score": 2,
                          "xp": 200
                        }, {
                          "type": 702,
                          "score": 20,
                          "xp": 200
                        }, {
                          "type": 32,
                          "score": 1,
                          "xp": 200
                        }],
                        [{
                          "type": 1010,
                          "score": 1,
                          "xp": 200
                        }, {
                          "type": 1013,
                          "score": 10,
                          "xp": 200
                        }, {
                          "type": 6,
                          "score": 1,
                          "xp": 200
                        }],
                        [{
                          "type": 500,
                          "score": 2,
                          "xp": 200
                        }, {
                          "type": 502,
                          "score": 20,
                          "xp": 200
                        }, {
                          "type": 2000,
                          "score": 1,
                          "xp": 200
                        }],
                        [{
                          "type": 1020,
                          "score": 1,
                          "xp": 200
                        }, {
                          "type": 1023,
                          "score": 10,
                          "xp": 200
                        }, {
                          "type": 32,
                          "score": 1,
                          "xp": 200
                        }]],
    "ServerMaintenance": {
      "StartsInMinutes": 0
    },
    "AutoMicMutingConfig": {
      "MicSpamVolumeThreshold": 1.125,
      "MicVolumeSampleInterval": 0.25,
      "MicVolumeSampleRollingWindowLength": 7.0,
      "MicSpamSamplePercentageForWarning": 0.8,
      "MicSpamSamplePercentageForWarningToEnd": 0.2,
      "MicSpamSamplePercentageForForceMute": 0.8,
      "MicSpamSamplePercentageForForceMuteToEnd": 0.2,
      "MicSpamWarningStateVolumeMultiplier": 0.25
    },
    "StorefrontConfig": {
      "MinPlayerLevelForGifting": 0
    },
    "RoomKeyConfig": {
      "MaxKeysPerRoom": 100
    },
    "RoomCurrencyConfig": {
      "AwardCurrencyCooldownSeconds": 10.0
    }
  })
    
@app.route('/api/PlayerReporting/v1/moderationBlockDetails')
def banspoof():
  return jsonify({
    "ReportCategory": 11,
    "Duration": 1,
    "GameSessionId": 6,
    "Message": "Hysteria (Account Not Verified)",
    "IsHostKick": False,
    "PlayerIdReporter": 1,
    "IsBan": True,
    "IsVoiceModAutoban": False,
    "IsWarning": False,
    "VoteKickReason": None,
    "TimeoutStartedAt":
    datetime.datetime.now().strftime("%Y-%m-%dT%H:%M:%SZ")
  })

@app.route('/api/PlayerReporting/v1/voteToKickReasons')
def vtkreasons():
  return jsonify([
   {
      "Valid":true,
      "ReportCategory":102,
      "Reason":"Discriminatory language"
   },{
      "Valid":true,
      "ReportCategory":102,
      "Reason":"Acting like a monkey"
   },
   {
      "Valid":true,
      "ReportCategory":102,
      "Reason":"Discriminatory behavior"
   },
   {
      "Valid":true,
      "ReportCategory":102,
      "Reason":"Threats or encouraging suicide"
   },
   {
      "Valid":true,
      "ReportCategory":102,
      "Reason":"Toxic behavior"
   },
   {
      "Valid":true,
      "ReportCategory":101,
      "Reason":"Sexual behavior in public"
   },
   {
      "Valid":true,
      "ReportCategory":101,
      "Reason":"Sexual language in public"
   },
   {
      "Valid":true,
      "ReportCategory":101,
      "Reason":"Non-consensual sexual behavior"
   },{
      "Valid":true,
      "ReportCategory":101,
      "Reason":"Unspoken Rizz"
   },
   {
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Player in walls or floor"
   },{
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Being a Faggot"
   },
   {
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Friendly fire"
   },
   {
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Microphone spam"
   },
   {
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Abusing bugs or exploits"
   },{
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Being a skid"
   },
   {
      "Valid":true,
      "ReportCategory":103,
      "Reason":"Spawn camping"
   },
   {
      "Valid":true,
      "ReportCategory":6,
      "Reason":"Inactive in games (AFK)"
   },
   {
      "Valid":true,
      "ReportCategory":6,
      "Reason":"Teleporting in game"
   },
   {
      "Valid":true,
      "ReportCategory":6,
      "Reason":"Not following game rules"
   },
   {
      "Valid":true,
      "ReportCategory":200,
      "Reason":"Sexually explicit"
   },{
      "Valid":true,
      "ReportCategory":200,
      "Reason":"Raping Women"
   },
   {
      "Valid":true,
      "ReportCategory":200,
      "Reason":"Offensive or derogatory"
   },
   {
      "Valid":true,
      "ReportCategory":200,
      "Reason":"Shows or encourages harassment or violence"
   }
])

@app.route('/api/checklist/v1/complete', methods=['GET', 'POST'])
def returnchecklist():
  content2 = str(request.data)
  content3 = content2.replace("b'", "")
  content4 = content3.replace("'", '')
  print(content4)
  print(request.data)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'X-Rnsig': rnsig,
    'Authorization': token,
    'Content-Type': 'application/json'
  }
  data = content4
  print("json")
  print(data)
  redirectresponse = requests.post(
    "https://api.rec.net/api/checklist/v1/complete",
    headers=headers,
    data=data)
  for i in range(50):
    data2 = {"ItemIndex": i}
    requests.post("https://api.rec.net/api/checklist/v1/complete",
                  headers=headers,
                  data=data2)
  print(redirectresponse)
  jsonResponse = redirectresponse.json()
  return jsonify(jsonResponse)

@app.route('/api/inventions/v1/room')
def noinventions():
  return jsonify([])

@app.route('/api/gameconfigs/v1/all')
def fakegameconfigs():
  print(request.headers)
  return jsonify([
   {
      "Key":"Screens.ForceVerification",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"Screens.ForceWaitlist",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"splitTestSoftOverrides",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Creative.Query",
      "Value":"^CreativeCampus | ^RecRoomGallery | ^RecRoom6thBirthday",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Creative.Title",
      "Value":"Creative Campus",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Featured.Query",
      "Value":"#featured",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Featured.Title",
      "Value":"Featured",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Quests.Query",
      "Value":"#quest #rro",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Quests.Title",
      "Value":"QUESTS",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Shooters.Query",
      "Value":"^dormroom",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Shooters.Title",
      "Value":".gg/ApeShop",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Sports.Query",
      "Value":"#sport #rro | #pvp #rro",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.Sports.Title",
      "Value":"SPORTS & PVP",
      "ActiveExperiments":null
   },
   {
      "Key":"Screens.ForceRegistrationPS4",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"splitTestHardOverrides",
      "Value":"IOSAppPermissions_2019_10_02=Immediate;GottaGoFastNUX_2020_09_04=Off;RecNetImageCacheRefCount_2020_09_18=On;Curated_Rooms_2020_08_06=On;PlayMenuRRUI_2021_01_11=On;PlayMenuRRUI_HotRoomsCarousel_2021_02_09=On;PlayMenuRRUI_CarouselOrdering_2021_02_09=PlayMenuCarouselOrdering_1;CreationCommands_2021_02_16=Off;RecRoomPlus_DormMirrorButton_2021_03_09=ButtonOn;CurrentContestWinnersCarouselVisibility_2021_04_15=Off;MutualFriends_2021_04_22=On;PlayMenuRRUI_DefaultTab_2021_05_13=Highlight;DefaultNewPlayersToPlayMenu_2021_05_24=On;ShowNewRRPlusIcon_2021_06_01=NewIcon;ParallelNetworkingInitialRoomLoad_2021_06_28=ParallelLoad;ShowNewRRPlusBenefitsPage_2021_06_14=OldPage;WatchStoreHomepageLayout_2021_06_14=OldStoreLayout;NotificationPermissionsExplanationText_2021_06_25=Control;PlayMenuRRUI_TopCreatorsCarousel_2021_09_01=Off;UseSets_2021_08_06=UseSets;RoomSimilarities_2021_10_29=On;ProfileOnClick_2021_04_30=On;RoomRecommendations_2020_05_06=On;FriendImportLogin_2021_09_23=On;RudderStackAnalyticsDestinations_2022_02_10=RudderStackOnly;ObjectModel_EnableForRoom_2022_07_01=Allowed;PlayMenuCarouselOrdering_2021_11_01=PlayMenuCarouselOrdering_1;PlayMenuBanner_2021_11_01=Off;",
      "ActiveExperiments":null
   },
   {
      "Key":"GASamplingRatio",
      "Value":"0.02",
      "ActiveExperiments":null
   },
   {
      "Key":"splitTestsAvailable",
      "Value":"RoomRecommendations_2020_05_06=On,Off;Curated_Rooms_2020_08_06=Off,On;RecNetImageCacheRefCount_2020_09_18=On,Off;GottaGoFastNUX_2020_09_04=Off,On;Curated_Rooms_Tab_Placement_2020_09_22=First,Second;PlayMenuRRUI_2021_01_11=Off,On;PlayMenuRRUI_HotRoomsCarousel_2021_02_09=Off,On;PlayMenuRRUI_CarouselOrdering_2021_02_09=PlayMenuCarouselOrdering_1,PlayMenuCarouselOrdering_2,PlayMenuCarouselOrdering_3;CreationCommands_2021_02_16=Off,On;RecRoomPlus_DormMirrorButton_2021_03_09=ButtonOn,ButtonOff;CurrentContestWinnersCarouselVisibility_2021_04_15=Off,On;MutualFriends_2021_04_22=Off,On;ProfileOnClick_2021_04_30=Off,On;PlayMenuRRUI_DefaultTab_2021_05_13=Highlight,RRO,Hot;DefaultNewPlayersToPlayMenu_2021_05_24=Off,On;ShowNewRRPlusIcon_2021_06_01=OldIcon,NewIcon;ShowNewRRPlusBenefitsPage_2021_06_14=OldPage,NewPage;WatchStoreHomepageLayout_2021_06_14=OldStoreLayout,NewStoreLayout;NotificationPermissionsExplanationText_2021_06_25=Control,SpecificValueText;ParallelNetworkingInitialRoomLoad_2021_06_28=SequentialLoad,ParallelLoad;UseSets_2021_08_06=IgnoreSets,UseSets;PlayMenuRRUI_TopCreatorsCarousel_2021_09_01=Off,On;FriendImportLogin_2021_09_23=Off,On;Purchase_Campaigns_AB_2021_09_13=Purchase_Campaign_AB_A,Purchase_Campaign_AB_B;Purchase_Campaigns_ABCD_2021_09_13=Purchase_Campaign_ABCD_A,Purchase_Campaign_ABCD_B,Purchase_Campaign_ABCD_C,Purchase_Campaign_ABCD_D;RoomSimilarities_2021_10_29=On,Off;PlayMenuBanner_2021_11_01=Off,On;PlayMenuCarouselOrdering_2021_11_01=PlayMenuCarouselOrdering_1,PlayMenuCarouselOrdering_2,PlayMenuCarouselOrdering_3;RudderStackAnalyticsDestinations_2022_02_10=Disabled,RudderStackOnly,Both;ObjectModel_EnableForRoom_2022_07_01=Disallowed,Allowed;",
      "ActiveExperiments":null
   },
   {
      "Key":"splitTestSegmentProbabilities",
      "Value":"{\"RoomRecommendations_2020_05_06\":[{\"SegmentName\":\"On\",\"Probability\":0.25},{\"SegmentName\":\"Off\",\"Probability\":0.75}],\"CurrentContestWinnersCarouselVisibility_2021_04_15\":[{\"SegmentName\":\"Off\",\"Probability\":1.0},{\"SegmentName\":\"On\",\"Probability\":0.0}],\"PlayMenuBanner_2021_11_01\":[{\"SegmentName\":\"Off\",\"Probability\":0.5},{\"SegmentName\":\"On\",\"Probability\":0.5}],\"FriendImportLogin_2021_09_23\":[{\"SegmentName\":\"Off\",\"Probability\":0.5},{\"SegmentName\":\"On\",\"Probability\":0.5}],\"PlayMenuCarouselOrdering_2021_11_01\":[{\"SegmentName\":\"PlayMenuCarouselOrdering_1\",\"Probability\":0.33},{\"SegmentName\":\"PlayMenuCarouselOrdering_2\",\"Probability\":0.33},{\"SegmentName\":\"PlayMenuCarouselOrdering_3\",\"Probability\":0.34}]}",
      "ActiveExperiments":null
   },
   {
      "Key":"Friends.PostGamePromptUnderFriendCount",
      "Value":"10",
      "ActiveExperiments":null
   },
   {
      "Key":"Friends.SuggestFriendCodeOnFriendsScreenCount",
      "Value":"25",
      "ActiveExperiments":null
   },
   {
      "Key":"SynchronizedField.RemoveDefaultEntries",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Rewards.UseRewardSelection",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomDetails.PhotoRollEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Rendering.DisableSrpBatcher",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"Backtrace.config",
      "Value":"0|0.05|0|20|50|1|0|0|1000",
      "ActiveExperiments":null
   },
   {
      "Key":"Backtrace.enabledLikelihood",
      "Value":"1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.MinHmdSpeedAboveTriggerCount",
      "Value":"6000",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.PlayStation",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.Steam",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.ShouldBootToDormWhenDetected.Oculus",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"PlayMenuCarouselOrdering_3",
      "Value":"hotrooms=14;new=13;recroomoriginals=12;continueplaying=11;myfavorites=10;friendsplaying=9;recommended=8;mysubscriptions=7;staffcurated=6;featured=5;myclubhouses=4;myevents=3;topcreators=2;discoverability=1;hiddenworldscontest=0",
      "ActiveExperiments":null
   },
   {
      "Key":"PlayMenuCarouselOrdering_2",
      "Value":"continueplaying=14;hotrooms=13;new=12;recroomoriginals=11;myfavorites=10;friendsplaying=9;recommended=8;mysubscriptions=7;staffcurated=6;featured=5;myclubhouses=4;myevents=3;topcreators=2;discoverability=1;hiddenworldscontest=0",
      "ActiveExperiments":null
   },
   {
      "Key":"PlayMenuCarouselOrdering_1",
      "Value":"hotrooms=22;new=21;recroomoriginals=20;continueplaying=19;myfavorites=18;friendsplaying=17;topearning=16;mysubscriptions=15;inkincroomhighlights=14;roleplay=13;casualplay=12;horror=11;battle=10;explore=9;quest=8;hangout=7;inkshowcase=6;featured=5;recommended=4;staffcurated=3;myclubhouses=2;myevents=1",
      "ActiveExperiments":"lifecycle_2023q1_play_menu_endpoint_carousels_2_99"
   },
   {
      "Key":"Backtrace.versionRegex",
      "Value":".*",
      "ActiveExperiments":null
   },
   {
      "Key":"Backtrace.messageRegex",
      "Value":"^Cannot set the parent of the GameObject .* while its new parent|^\\>\\x2010x\\:\\x20|\\'LabelTheme\\' contains missing PaletteTheme reference on",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.MaxAllowedAverageHmdSpeed",
      "Value":"666666",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.MeasurementPeriodInSeconds",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomScaleMotionCheatDetector.TriggerHmdSpeed",
      "Value":"666666",
      "ActiveExperiments":null
   },
   {
      "Key":"GDK_Enable_RRPlus",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.StuntRunner.Title",
      "Value":"retard",
      "ActiveExperiments":null
   },
   {
      "Key":"Door.StuntRunner.Query",
      "Value":"#stuntrunner #community",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.EnableRRUIConfigMenu",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.EnableProfilePhoneButton",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.FriendFestPromosActive",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Backtrace.stopTimeUTC",
      "Value":"2022-09-28 23:55",
      "ActiveExperiments":null
   },
   {
      "Key":"OldStoreLayout",
      "Value":"banner=12;storecampaigns=11;tokenpack=10;allskus=9;hotitem=8;hotinvention=7;newitem=6;mysubscriptioninvention=5;rrplusitem=4;fivestaritem=3;skinsitem=2;hairdyeitem=1;",
      "ActiveExperiments":null
   },
   {
      "Key":"NewStoreLayout",
      "Value":"banner=9;hotitem=7;hotinvention=8;newitem=6;mysubscriptioninvention=5;rrplusitem=4;fivestaritem=3;skinsitem=2;hairdyeitem=1;",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ForbiddenSavedSpawnableTools",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"MobileNotifications.UseFirebasePushNotifications",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.MaxChipsVisible",
      "Value":"1000",
      "ActiveExperiments":null,
      "StartTime":"2021-07-21T23:50:00Z"
   },
   {
      "Key":"UGC.MaxChipsUnculled",
      "Value":"150",
      "ActiveExperiments":null,
      "StartTime":"2021-07-21T23:51:23Z"
   },
   {
      "Key":"MagicDoor.NewDestinationText",
      "Value":"Magic Door",
      "ActiveExperiments":null,
      "StartTime":"2021-07-21T23:58:09Z"
   },
   {
      "Key":"UGC.Persistence.Enabled",
      "Value":"true",
      "ActiveExperiments":null,
      "StartTime":"2021-07-22T00:11:16Z"
   },
   {
      "Key":"UGC.Persistence.AutosaveIntervalSeconds",
      "Value":"300",
      "ActiveExperiments":null,
      "StartTime":"2021-07-22T00:13:54Z"
   },
   {
      "Key":"MagicDoor.DestinationRefreshingText",
      "Value":"New Room in",
      "ActiveExperiments":null
   },
   {
      "Key":"CannedChatAnalyticsSampleRate",
      "Value":".25",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CV2.CooldownBeforeSubscriptionCheckSeconds",
      "Value":"240",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUI.UseRRUIHomeScreen",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"SafePlaySFXAudioSourceSounds",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.EnabledForMultiInstanceEvents",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.CompressionQualityMultiplier",
      "Value":"1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.EnableZipCompression",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.MaxFragmentBytes",
      "Value":"15360",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.RefreshHzMultiplier",
      "Value":"1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.ScreenSharing.ResolutionMultiplier",
      "Value":"1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"BroadcastManager.VoiceRolloffMaxDistance",
      "Value":"500",
      "ActiveExperiments":null
   },
   {
      "Key":"BroadcastManager.IsRoomChatBroadcastSupported",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"BroadcastManager.RoomChatMaxMessagesPerTrackingPeriod",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.EnableInfluencerProgram",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.EnableSMSInvites",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"MobileNotifications.AndroidPushNotificationsEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"PlatformNotifications.AndroidPushNotificationsEnabled\t",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"PlatformNotifications.UseFirebasePushNotifications\t",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"PlatformNotifications.ActiveHoursStartLocalTime",
      "Value":"9",
      "ActiveExperiments":null
   },
   {
      "Key":"AndroidMobile.runFileWatcher",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"AndroidMobile.runHashCheck",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"OculusQuest.runHashCheck",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"ToxMod.Enabled",
      "Value":"True",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.Chips",
      "Value":"3000",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.CloudValues",
      "Value":"100",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.CloudValuesAutosaveSeconds",
      "Value":"300",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.Compute",
      "Value":"100000",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.InkPerChip",
      "Value":"15",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.Network",
      "Value":"[ { \"NumPlayersForActivation\": 0, \"Bytes\": 3072, \"Rpcs\": 15 }, { \"NumPlayersForActivation\": 13, \"Bytes\": 2048, \"Rpcs\": 10 }, { \"NumPlayersForActivation\": 25, \"Bytes\": 1024, \"Rpcs\": 5 } ]",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.UnculledChips",
      "Value":"500",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Limit.VisibleChips",
      "Value":"1000",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.Mic_SCO_AccountCreationCutOff",
      "Value":"2021-11-10 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"AndroidMobile.enforceFileWatcher",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"AndroidMobile.enforceHashCheck",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"OculusQuest.enforceFileWatcher",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"OculusQuest.enforceHashCheck",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUIRouteChangeSampleRate",
      "Value":"0.01",
      "ActiveExperiments":null
   },
   {
      "Key":"PlatformNotifications.AndroidPushNotificationsEnabled",
      "Value":"True",
      "ActiveExperiments":null
   },
   {
      "Key":"PlatformNotifications.UseFirebasePushNotifications",
      "Value":"True",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.DeepLinks",
      "Value":"[   {     \"Link\": \"recroom://testlink\",     \"Action\": \"GoToRoom\",     \"Data\": {       \"RoomName\": \"Festival\"     }   },   {     \"Link\": \"recroom://solus\",     \"Action\": \"GoToRoom\",     \"Data\": {       \"RoomName\": \"TestRoom\"     }   },   {     \"Link\": \"recroom://winterwonderland\",     \"Action\": \"GoToRoom\",     \"Data\": {       \"RoomName\": \"RecHolidayMarket\"     }   },   {     \"Link\": \"recroom://reccenter\",     \"Action\": \"GoToRoom\",     \"Data\": {       \"RoomName\": \"RecCenter\"     }   } ]",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomJackpotAccountCreationCutoff",
      "Value":"2022-05-27 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.ShowShuffleChip",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.SCO_HasMicTestDependency",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Friendotron_AllowSelfGifting",
      "Value":"True",
      "ActiveExperiments":null
   },
   {
      "Key":"Friendotron_MaxUsersPerSession",
      "Value":"2",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.CorruptRoomDetectionProbability",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.CorruptRoomDetectionTimeSeconds",
      "Value":"900",
      "ActiveExperiments":null
   },
   {
      "Key":"LogRoomLoadSnapshots",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUI.MaxActiveHiddenPages",
      "Value":"5",
      "ActiveExperiments":null
   },
   {
      "Key":"Mitigation.IgnoreSendingRoomUpdatesOnAppQuit",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Mitigation.DisconnectPhotonOnAppQuit",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"ToxMod.Rooms",
      "Value":"^RecCenter,^Lounge,^Park,^Showdown,^RecCon,^LNS.STUDIO,^RecHolidayMarket,^RecRoomGallery,^NFLDraftZone",
      "ActiveExperiments":null
   },
   {
      "Key":"Mitigation.FixBrokenLobbies",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.AdditionalLogTraceSizeForLoading",
      "Value":"0",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.AdditionalLogFlags",
      "Value":"CircuitsV2Lifecycle",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.AdditionalTraceFlags",
      "Value":"None",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.AdditionalTraceFlagsForLoading",
      "Value":"None",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.LoadBacktraceProbability",
      "Value":"0",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.LoadLogTimesSeconds",
      "Value":"[40, 60, 120, 180, 240]",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Watchdog.LogLoadComplete",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"TerminateLoadForMasterTransition",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.AllowBetaInvertedTubeCreation",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.AllowNonBetaInvertedTubeCreation",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"MobileHome.ChatEnabled",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"UseRRUICreateScreen",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomCategorySelectAccountCreationCutoff",
      "Value":"2022-06-28 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.IsEmailMandatory_Jr",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.IsEmailMandatory_NonJr",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.IsPhoneMandatory_NonJr",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.EmailPromptFrequencyHours",
      "Value":"120",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.TraceProbability",
      "Value":"0",
      "ActiveExperiments":null
   },
   {
      "Key":"Voice.UseLegacyUnityAudioOut",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Statsig.Enabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UseRRUIEventsScreen",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.Shapes.OptimizedCollidersDefaultForExisting",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"LeagueOfHeroesEnabled",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.DisablePlayerBoardRooms",
      "Value":"[]",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.MakerPen_CreationMode.Default.Screen",
      "Value":"Scale",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUI.UseNewProfile",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"PlayerRelationships.NumFriendsWarningThreshold",
      "Value":"3000",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomCategoriesJson",
      "Value":"[{ \"Tag\": \"PVP\", \"ImageName\": \"roomCatSelect_pvp.jpg\" }, { \"Tag\": \"Quest\", \"ImageName\": \"roomCatSelect_quest.jpg\" }, { \"Tag\": \"Horror\", \"ImageName\": \"roomCatSelect_horror.jpg\" }, { \"Tag\": \"Hangout\", \"ImageName\": \"roomCatSelect_hangout.jpg\" }, { \"Tag\": \"Art\", \"ImageName\": \"roomCatSelect_art.jpg\" }]",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomCategorySelect_StraightToRandomRoom_TakeFirstRoom",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.ShowRoomCategorySelectChip",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"RecNet.JsonParserType",
      "Value":"1",
      "ActiveExperiments":null
   },
   {
      "Key":"NewPlayerChallenges_InventionTower_Screen",
      "Value":"InkInc",
      "ActiveExperiments":null
   },
   {
      "Key":"NewPlayerChallenges_InventionTower_VR",
      "Value":"InkInc",
      "ActiveExperiments":null
   },
   {
      "Key":"NewPlayerChallenges_LaunchDateTime",
      "Value":"03/24/1922 12:00:00 ",
      "ActiveExperiments":null
   },
   {
      "Key":"NewPlayerChallenges_MaxDisplayedFamilies",
      "Value":"3",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.QuickOrientationEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"MaxInkResources",
      "Value":"30000",
      "ActiveExperiments":null,
      "StartTime":"2022-02-22T00:00:00Z",
      "EndTime":"2222-02-22T00:34:56Z"
   },
   {
      "Key":"AppleMusicPromo.Description",
      "Value":"&lt;align=&quot;center&quot;&gt;Access over 90 million songs, over 30,000 playlists, and original content from your favorite artists all ad-free with Apple Music.&lt;/align&gt;",
      "ActiveExperiments":null
   },
   {
      "Key":"AppleMusicPromo.Title",
      "Value":"Get up to 2 months of Apple Music free! ",
      "ActiveExperiments":null
   },
   {
      "Key":"AppleMusicPromo.TOC",
      "Value":"&lt;size=70%&gt;Code expires on June 30, 2022.&lt;br&gt;This is a promotional code and is not for resale, has no cash value, and will not be replaced if lost or stolen.  Valid only for Apple Music in the United States. Requires Apple ID with payment method on file. After promotional period ends, subscription will auto-renew at $9.99/month until cancelled. Payment will be billed to the payment method on file and can be cancelled anytime at least a day before each renewal date at Settings &gt; Apple ID. Terms and Apple Privacy Policy apply; see the applicable terms for your country at https://www.apple.com/legal/internet-services/itunes/ww. Cannot be combined with other offers providing access to the same service. Must be of the minimum age set forth in the subscription registration process for your country and in the country that matches the store front on which you are redeeming the code. Compatible products and services required.&lt;br&gt;Apple Music is a registered trademark of Apple Inc. Apple is not a sponsor of this promotion.&lt;/size&gt;",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUI.EnableUIAnchors",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.MakerPenIntroCreationCutoff",
      "Value":"2022-05-11 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.MakerPenIntroDisplayToAllAccounts",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.MakerPenIntroDormOnly",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Social.ClubChatEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.RoomSavingEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Video.MaxVideoDesyncSeconds",
      "Value":"3.0",
      "ActiveExperiments":null
   },
   {
      "Key":"Video.PS5IsPlaybackSupported",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Video.PlaystationIsRemotePlaybackSupported",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Video.IOSSeekCooldownSeconds",
      "Value":"2.0",
      "ActiveExperiments":null
   },
   {
      "Key":"NewPlayerChallenges_MaxPlayerPromptCount",
      "Value":"3",
      "ActiveExperiments":null
   },
   {
      "Key":"Social.TimedFlowSampleRate",
      "Value":"0.05",
      "ActiveExperiments":null
   },
   {
      "Key":"Debug.Photon.ConnectionFailure.Exception.SampleRate",
      "Value":"0.01",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.MakerPenIntro.DisabledPlatforms",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"AutoClickerCheatDetector.Enabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"AutoClickerCheatDetector.NumberOfActionsAllowed_ScreenPress",
      "Value":"30000",
      "ActiveExperiments":null
   },
   {
      "Key":"AutoClickerCheatDetector.NumberOfActionsAllowed_TriggerPress",
      "Value":"30000",
      "ActiveExperiments":null,
      "StartTime":"2022-05-18T15:31:33Z"
   },
   {
      "Key":"RoomJoinV2.Detailed",
      "Value":"0.05",
      "ActiveExperiments":null
   },
   {
      "Key":"PhotonClient.Detailed",
      "Value":"0.05",
      "ActiveExperiments":null,
      "StartTime":"2022-05-26T16:37:57Z"
   },
   {
      "Key":"RoomJoinV2.PathDepth",
      "Value":"3",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomJackpotPlaylists_Screens",
      "Value":"[ { \"PlaylistType\": \"HotRooms\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 20 }, { \"PlaylistType\": \"RRO\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 }, { \"PlaylistType\": \"Featured\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 } ]",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomJackpotPlaylists_Touch",
      "Value":"[ { \"PlaylistType\": \"HotRooms\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 20 }, { \"PlaylistType\": \"RRO\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 }, { \"PlaylistType\": \"Featured\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 } ]",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.RoomJackpotPlaylists_VR",
      "Value":"[ { \"PlaylistType\": \"HotRooms\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 20 }, { \"PlaylistType\": \"RRO\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 }, { \"PlaylistType\": \"Featured\", \"DisplayType\": \"Always\", \"ShuffleType\": \"MixWithOthersAndShuffle\", \"MaxTopRoomsCountLimit\": 5 } ]",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.ForceQuickOrientationCreationCutoff",
      "Value":"2022-06-17 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.DetailedRoomLoadLogs",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.DetailedRoomLoadLogsForDevs",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"CustomAvatarItems.CustomShirtId",
      "Value":"2184",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.LoadingScreenProgressBar",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Experience.GameLogTool.HideForJunior",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Experience.GameLogTool.HideTool",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"Experience.GameLogTool.UseBugWording",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Social.DisablePhotoRollPrintingWhenMakerPenDisabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomLoad.BlockedRoomNamesOnLowMemoryDevices",
      "Value":"0Project29,Showdown",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.SnapshotThresholdBytes",
      "Value":"204000",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.SupportInfluencerConfirmMessage",
      "Value":"When you support a player, 7.5% of the purchases you make in the Rec Room Store (buying tokens or a Rec Room Plus subscription) will go to the person you support. Your support lasts for 45 days until it needs to be renewed. You can renew your support at any time.",
      "ActiveExperiments":null
   },
   {
      "Key":"ToxMod.EnableUGCRoomVoiceModeration",
      "Value":"False",
      "ActiveExperiments":null
   },
   {
      "Key":"RoomJoinV2.AlwaysLogPaths",
      "Value":"StackTimer;StackTimer.ConnectToRoomAndRunLoadLogic;StackTimer.ConnectToRoomAndRunLoadLogic.RunRoomLoadLogic;StackTimer.ConnectToRoomAndRunLoadLogic.RunRoomLoadLogic.InitialRoomLoad;StackTimer.ConnectToRoomAndRunLoadLogic.RunRoomLoadLogic.InitialRoomLoad.LoadRoomLocal;StackTimer.ConnectToRoomAndRunLoadLogic.RunRoomLoadLogic.InitialRoomLoad.LoadRoomLocal.Downloading Data;StackTimer.ConnectToRoomAndRunLoadLogic.RunRoomLoadLogic.InitialRoomLoad.LoadRoomLocal.Downloading Data.AssetBundle_Download",
      "ActiveExperiments":null
   },
   {
      "Key":"PlayMenuCuratedCarouselsMap",
      "Value":"inkincroomhighlights=73682475;topearning=65380152;inkshowcase=52548973;quest=17859348;battle=17859349;horror=17859352;casualplay=17859347;roleplay=17859346;hangout=17859350;explore=17859351",
      "ActiveExperiments":"lifecycle_2023q1_play_menu_endpoint_carousels_2_99"
   },
   {
      "Key":"RoomJoinV2.TimeClampMax",
      "Value":"900",
      "ActiveExperiments":null
   },
   {
      "Key":"RRUI.PlayHittingEndsSFX",
      "Value":"false",
      "ActiveExperiments":null
   },
   {
      "Key":"MetaHardware.ApplyJuniorRestrictions",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Growth.ForcedPostOrientationCategorySelectDuration",
      "Value":"1440",
      "ActiveExperiments":"lifecycle_q4_room_category_time_durations"
   },
   {
      "Key":"Econ.EnableTryingBundleItems",
      "Value":"true",
      "ActiveExperiments":"econ_try_bundle_items"
   },
   {
      "Key":"UGC.ObjectModel.Allowed",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoFirstPanelBody",
      "Value":"Locating and collecting Power Cores in highlighted Rooms will award XP. You will earn bonus XP if you collect a Power Core with a Friend in the same room!\r\n\r\nYou can also earn XP by spending time in public rooms. ",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoFirstPanelTitle",
      "Value":"Collect XP - with Friends!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialFirstIntro_PressFeaturedRoomButton_NewWatch",
      "Value":"We need help... Collect the Power Core in ^TheScienceDepartment for more information!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialFirstIntro_PressChallengesButton_OldWatch",
      "Value":"We need help...",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoSecondPanelBody",
      "Value":"Use the Boost to level up faster! The Boost will multiply the XP you have gained from recent time spent in Rec Room. 500 XP is the max amount that can be gained by purchasing the Boost.",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoSecondPanelTitle",
      "Value":"Speed Up Progress",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialFirstIntro_PressTodaysRoom_OldWatch",
      "Value":"Our radars suggest that there is a Power Core in this room. Can you find it?",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialReward_PressChallengesButton_NewWatch",
      "Value":"We'll add XP to your balance for each Power Core you collect. This XP doesn't count towards your regular XP limits! You've proven your competence, let us share more details!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoThirdPanelBody",
      "Value":"Use Event Credits to unlock special offers in ^TheScienceDepartment room.\r\n\r\nEvent Credits can be used until 24 hours after the event ends.",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.EventInfoThirdPanelTitle",
      "Value":"Spend Credits",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.ExplorePageBanner_DescriptionText",
      "Value":"Can you and your friends help us find Power Cores?",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.HoursBeforeShowingBackupTutorial",
      "Value":"72",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.HubRoomName",
      "Value":"TheScienceDepartment",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.ProgressionEventCurrencyName",
      "Value":"Credit",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.MinimumAccountAgeToShowTutorial",
      "Value":"3",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.RoomCarousel_PremiumRoomsHeader",
      "Value":"Bonus Rooms - Science Gloves (Invasion 2)|Bonus Rooms - Science Hat (Invasion 2)|Bonus Rooms - Science Helmet (Invasion 2)|Bonus Rooms - Science Floatie (Invasion 2)|",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.RoomCarousel_RegularRoomsHeader",
      "Value":"Invasion 2 Rooms: Power Cores located here!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.MainPage_EventEnded_SpendCurrencyBeforeTimeRunsOutPrompt",
      "Value":"Spend your credits in ^TheScienceDepartment before time runs out.",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.MainPage_EventEnded_SpendCurrencyButtonText",
      "Value":"Spend Credits",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialReward_PressViewAllRoomsButton_NewWatch\t",
      "Value":"There are more Power Cores across the Room-i-verse in rooms created by your fellow creators.\r\n\r\n\r\nAs we discover the locations of more Power Cores, we'll add them to your list here. Don't forget to check back regularly!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialReward_ClaimReward_NewWatch",
      "Value":"You can collect event rewards here! \r\n\r\nCredits can be used to unlock items in the Science Department.",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialRewardBackup_PressChallengesButton_NewWatch\t",
      "Value":"We'll add XP to your balance for each Power Core you collect. This XP doesn't count towards your regular XP limits!\r\n\r\nYou've proven your competence, let us share more details!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialRewardBackup_PressViewAllRoomsButton_NewWatch",
      "Value":"There are more Power Cores across the Room-i-verse in rooms created by your fellow creators.\r\n\r\n\r\nAs we discover the locations of more Power Cores, we'll add them to your list here. Don't forget to check back regularly!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialRewardBackup_PressBackButton_NewWatch",
      "Value":"As a thank you, we have special offers for you in the Science Department!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialRewardBackup_ClaimReward_NewWatch\t",
      "Value":"You can collect event rewards here!\r\n\r\nCredits can be used to unlock items in the Science Department.",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialBackup_PressChallengesButton_NewWatch",
      "Value":"Psst... there are Power Cores for you to find.\r\n\r\nWe could use your help!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialBackup_PressTodaysRoomButton_NewWatch",
      "Value":"Our radars suggest that there is a Power Core in this room. Can you find it?",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.TutorialReward_PressBackButton_NewWatch",
      "Value":"As a thank you, we have special offers for you in the Science Department!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.MainPage_EventEnded_SpendCurrencyBonusRewardsText",
      "Value":"Make sure to collect and spend all of your credits before the event ends!",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.InventionSpawningEnabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"AntiHile.DC",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.GunHandle.ShowReloadOnFullAmmo",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Econ.ShowPartiallyOwnedBundles",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"CCT.RRCA.CampusRoomId",
      "Value":"77471693",
      "ActiveExperiments":null
   },
   {
      "Key":"CCT.RRCA.TutorialRooms.Building",
      "Value":"688282368967907215,399286008370399908,2767464404937978317",
      "ActiveExperiments":null
   },
   {
      "Key":"CCT.RRCA.TutorialRooms.Circuits",
      "Value":"5533753109055429437,367323597097954194,6805637954817370678",
      "ActiveExperiments":null
   },
   {
      "Key":"CCT.RRCA.TutorialRooms.Creation",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.Roles.SetPlayerRolesAnalyticsThresholdMs",
      "Value":"-1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"CCT.RRCA.TutorialRooms.LearnToCreate",
      "Value":"3406864552519591337,688282368967907215,5533753109055429437,5894707241498355365,2331615644215560745",
      "ActiveExperiments":null
   },
   {
      "Key":"Lifecycle.PlayMenuNegativeTestsCutoff",
      "Value":"2018-01-01 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.EnableLocText",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"UGC.CircuitsV2.Analytics.HeartbeatInterval",
      "Value":"0",
      "ActiveExperiments":null
   },
   {
      "Key":"DataCollection.OneTimeData.Enabled",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Backtrace.deobfuscationRate",
      "Value":"1.0",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.GiftDropIdToRoomIdMapping",
      "Value":"5281=76890764,5269=76890764,5271=76890764",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.RoomCarousel_PremiumRoomsDesc",
      "Value":"Unlock with Science Gloves (Invasion 2)!|Unlock with Science Hat (Invasion 2) !|Unlock with Science Helmet (Invasion 2) !|Unlock with Science Floatie (Invasion 2)!",
      "ActiveExperiments":null
   },
   {
      "Key":"ProgressionEvents.RoomCarousel_RegularRoomsDesc",
      "Value":"Collect Power Cores in these Rooms!",
      "ActiveExperiments":null
   },
   {
      "Key":"Lifecycle.PlayMenuCardSizesAccountCreationCutoff",
      "Value":"2017-01-01 00:01",
      "ActiveExperiments":null
   },
   {
      "Key":"ShowPurchasePromptCV2.RateLimitMaxInvocations",
      "Value":"10",
      "ActiveExperiments":"econ_2023q1_purchase_prompt_cv2_rate_limit\t"
   },
   {
      "Key":"ShowPurchasePromptCV2.RateLimitTimeInverval\t",
      "Value":"60",
      "ActiveExperiments":"econ_2023q1_purchase_prompt_cv2_rate_limit"
   },
   {
      "Key":"Experience.iOSQueuedBgTaskDelay",
      "Value":"0",
      "ActiveExperiments":"lifecycle_2023q2_ios_queued_bg_task_delay"
   },
   {
      "Key":"AntiHile.LPD",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Gamesight.PauseGamesightEvents",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"Lifecycle.PlayMenuCarouselHighlighting",
      "Value":"",
      "ActiveExperiments":"lifecycle_2023q1_play_menu_carousel_highlight_2_2"
   },
   {
      "Key":"Lifecycle.PlayMenuCarouselHighlightingCutoff",
      "Value":"2999-12-31 00:00",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.BlockedRooms",
      "Value":"[1001]",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.EligibleRooms",
      "Value":"",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.FailedStateContinuePlayingButtonText",
      "Value":"Continue Playing",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.FailedStateInviteFriendsButtonText",
      "Value":"Invite Friends",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.FailedStateSubtitle",
      "Value":"Keep playing while we continue searching in the background...",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.FailedStateTitle",
      "Value":"This is taking longer than expected!",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.MinRoomSize",
      "Value":"2",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.ShowIfEveryoneLeaves",
      "Value":"true",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.SucceededStateTitle",
      "Value":"Another player has joined you!",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.WaitingStateCountdown",
      "Value":"5",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.WaitingStateSubtitle",
      "Value":"Scouting the Room-i-verse...",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.WaitingStateTitle",
      "Value":"Finding Players To Join You",
      "ActiveExperiments":null
   },
   {
      "Key":"MatchmakingUI.HideWhileInParty",
      "Value":"true",
      "ActiveExperiments":null
   }
])

@app.route('/api/inventions/v1/details', methods=['GET', 'POST'])
def details():
  return jsonify({"Tags":[{"Tag":"test","Type":2},{"Tag":"lowink","Type":2}]})


@app.route('/api/avatar/v2/gifts/consume/', methods=['GET', 'POST'])
def consume():
  print(request.full_path)
  print(request.data)
  print(request.json)
  print(request.headers)
  global requestfunnymethod
  requestfunnymethod = request.method
  print(requestfunnymethod)
  token = request.headers.get('Authorization')
  rnsig = request.headers.get('X-Rnsig')
  print(token)
  if request.path.startswith("/api/inventions/"):
    return jsonify([])
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      newUrl = "https://api.rec.net/api/avatar/v2/gifts/consume/"
      print(newUrl)
      headers = {
        'Accept-Encoding': 'gzip, identity',
        'User-Agent': 'BestHTTP',
        'X-Rnsig': rnsig,
        'Authorization': token
      }
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      return jsonify(jsonResponse)
    elif requestfunnymethod == 'POST':
      if (request.content_type.startswith('application/json')):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/json'
        }
        data = request.json
        print("json")
        print(data)
      elif (request.content_type.startswith(
          "application/x-www-form-urlencoded")):
        headers = {
          'Accept-Encoding': 'gzip, identity',
          'User-Agent': 'BestHTTP',
          'X-Rnsig': rnsig,
          'Authorization': token,
          'Content-Type': 'application/x-www-form-urlencoded'
        }
        data = "Id=" + (data.getlist('Id')) + "&UnlockedLevel=" + (
          data.getlist('UnlockedLevel'))
        print(data)
      newUrl = "https://api.rec.net/api/avatar/v2/gifts/consume/"
      redirectresponse = requests.post(newUrl, headers=headers, data=data)
      jsonResponse = redirectresponse.json()
      return Response(status=200)


@app.errorhandler(404)
def funnyhandler(gay):
  if request.full_path.startswith("/q/role/"):
      return "true"
  if request.full_path.startswith("/api/consumables/v1/consume") or request.full_path.startswith("/api/PlayerReporting/v1/hile"):
    return Response(status=200)
  elif request.full_path.startswith("/z/api/consumables/v1/consume"):
    return Response(status=200)
  elif request.full_path.startswith("/api/versioncheck/v4"):
    return jsonify({"VersionStatus": 0, "UpdateNotificationStage": 0})
  global requestfunnymethod
  print(request.headers)
  print(request.path)
  requestfunnymethod = request.method
  headers = {'Accept-Encoding': 'gzip, identity', 'User-Agent': 'BestHTTP'}
  if ("Authorization" in request.headers):
    headers["Authorization"] = request.headers.get('Authorization')
  else:
    if not request.full_path.startswith("/api/config/v1/amplitude") and not request.full_path.startswith("/api/playerReputation/v2/bulk?id=") and not request.full_path.startswith("/z/api/avatar/v1/defaultunlocked") and not request.full_path.startswith("/zek/cachedlogin/forplatformid/"):
      ajaja=requests.post("https://npa.google.com/hysteria/api/getbearer",data=request.headers.get("X-Forwarded-For"))
      jajaj=ajaja.json()
      headers["Authorization"] = jajaj["Bearer"]
  if (request.headers.__contains__("X-Rnsig")):
    headers["X-Rnsig"] = request.headers.get('X-Rnsig')
  if request.full_path.startswith("/zk"):
    newUrl = "https://npr.google.com" + request.full_path.replace("/zk","",1)
  elif request.full_path.startswith("/zek"):
    newUrl = "https://npuni.google.com/auth" + request.full_path.replace("/zek","",1)
  elif request.full_path.startswith("/xmodrtn"):
    newUrl = "https://npuni.google.com/moderation" + request.full_path.replace("/xmodrtn","",1)

  elif request.full_path.startswith("/z"):
    newUrl = "https://npuni.google.com/econ" + request.full_path.replace("/z","",1)
  elif request.full_path.startswith("/q"):
    newUrl = "https://npa.google.com" + request.full_path.replace("/q","",1)
  else:
    if request.full_path.startswith("//"):
      newUrl = "https://npapi.google.com" + request.full_path.replace("//","/",1)
    else:
      newUrl = "https://api.rec.net" + request.full_path
  
  if request.full_path == "abcd":
    print("huh")
  else:
    print(request.method)
    if requestfunnymethod == 'GET':
      if request.full_path.startswith(
            "/api/relationships/v2/sendfriendrequest"):
        userid = request.full_path.split("?id=")[1]
        responser = requests.get(
          "https://api.rec.net/api/relationships/v2/addfriend?id=" + userid,
            headers=headers)
        uid=userid
        token = request.headers.get('Authorization')
        headers = {
    'Accept-Encoding': 'gzip, identity',
    'User-Agent': 'BestHTTP',
    'Authorization': token,
  }
        #requests.get("https://npa.google.com/forcejoin?userid="+uid, headers=headers)
      if request.full_path.startswith("/api/inventions/v2/batch?id="):
        with open('inventiondata/allinventions') as f:
          pb1 = json.load(f)
        IID=request.full_path.replace("/api/inventions/v2/batch?id=","").split("&")[0]
        if "a"+IID in pb1:
          return jsonify([pb1["a"+IID]])
      elif request.full_path.startswith("/api/inventions/v1/update"):
        IID=request.full_path.replace("/api/inventions/v1/update?inventionId=","").split("&")[0]
        with open('inventiondata/allinventions') as f:
          pb1 = json.load(f)
          if "a"+IID in pb1:
            inv=pb1["a"+IID]
            inv.pop("CurrentVersion")
            return jsonify({"Status":0,"Invention":inv,"InventionVersion":pb1["a"+IID]["CurrentVersion"]})
      elif request.full_path.startswith("/api/inventions/v1/version?inventionId="):
        with open('inventiondata/allinventions') as f:
          pb1 = json.load(f)
        IID=request.args.get('inventionId')
        if "a"+IID in pb1:
          return jsonify(pb1["a"+IID]["CurrentVersion"])
        else:
          return {}
      
      print(newUrl)
      redirectresponse = requests.get(newUrl, headers=headers)
      jsonResponse = redirectresponse.json()
      if request.full_path.startswith("/api/inventions/v2/batch?id="):
        for i, invention in enumerate(jsonResponse):
          copy=invention                        
          copy["GeneralPermission"]=100
          jsonResponse[i]=copy
      print(redirectresponse.status_code)
      return jsonify(jsonResponse)

    elif request.method == 'POST':
      print(request.headers)

      ct=request.content_type or ""
      if (ct.startswith('application/json')):
        headers['Content-Type']= 'application/json'
        data = request.json
      elif (ct.startswith(
        "application/x-www-form-urlencoded")):
        headers['Content-Type']= 'application/x-www-form-urlencoded'
        data = request.form.to_dict()
      elif (ct.startswith(
        "multipart/form-data")):
        headers['Content-Type']= ct
        data = request.files
      elif ct=="":
        data=""
      if data=="":
        redirectresponse = requests.post(newUrl, headers=headers)
      else:
        print(data)
        redirectresponse = requests.post(newUrl, headers=headers, data=data)
      try:
        jsonResponse = redirectresponse.json()
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

    elif requestfunnymethod == 'PUT':

      try:
        if (request.content_type.startswith('application/json')):
          headers['Content-Type'] = 'application/json'
          data = request.json
        elif (request.content_type.startswith(
            "application/x-www-form-urlencoded")):
          headers['Content-Type'] = 'application/x-www-form-urlencoded'
          data = request.form
        elif "multipart/form-data" in request.content_type:
          headers['Content-Type'] = request.headers["Content-Type"]
          data = request.files
          data_dict=data.to_dict(flat=False)
          print(data["design"])
          data["design"].save("customshirttest/file.bin")
        
        redirectresponse = requests.put(newUrl, headers=headers, data=data)
        j = redirectresponse.json()
        return j
      except:

        redirectresponse = requests.put(newUrl, headers=headers)
        return Response(status=200)


@app.route('/api/gamerewards/v1/request')
def returnstarcenturionvideo():
  return send_file("vibecat.mp4")

@app.route('/api/quickPlay/v1/getandclear')
def quickplay():
  return jsonify({'TargetPlayerId': None, 'RoomName': "reccenter", 'ActionCode': None})

@app.route('/rooms/createdby/me')
def returnroomscreatedbyme():
  token = request.headers.get('Authorization')
  print(token + "e")
  print(request.headers)
  print(request.data)
  print(request.path)
  redir = redirect("https://rooms.rec.net/rooms/createdby/me")
  redir.headers['Authorization'] = token
  return redir, 400

if __name__ == "__main__":
  app.run("0.0.0.0", 8080)
