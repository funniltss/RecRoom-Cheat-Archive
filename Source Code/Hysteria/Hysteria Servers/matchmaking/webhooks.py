import datetime
from discord_webhook import DiscordWebhook

webhook_url = "https://discord.com/api/webhooks/1072418235485532180/4jx796CxdRV42FQS4orShOq37UWrZWb5ab94I8jJ06woJ_Cugg1w8f24Vs6SbX3TF7i0"

red = 14692657
green = 3735392
orange = 16749880
blue = 3711743

# usernamefip = username from ip


def crash_webhook(usernamefip):
  Embed = {
    "title":
    "@" + usernamefip +
    " has timed out *(player has probably crashed/desynced)*",
    "description":
    "*60s has passed without a heartbeat response from @" + usernamefip + "*",
    "url":
    "https://rec.net/user/" + usernamefip,
    "color":
    orange,
    "timestamp":
    str(datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")),
    "footer": {
      "text": "webhook by neptune#1995"
    }
  }
  webhook = DiscordWebhook(
    url=webhook_url,
    username="Hysteria",
    avatar_url="https://i.ibb.co/vdVKsbH/6qvnjs0s1xxvyj0di35am3lro.jpg")
  webhook.add_embed(Embed)
  try:
    webhook.execute()
  except:
    print("Crash Webhook Error")
  return 1


def timein_webhook(usernamefip):
  print(usernamefip + " timed back in, sending time in webhook")
  Embed = {
    "title":
    "@" + usernamefip + " has timed back in *(player has reconnected)*",
    "description":
    "*Heartbeat response recieved from @" + usernamefip + " after timing out*",
    "url": "https://rec.net/user/" + usernamefip,
    "color": blue,
    "timestamp": str(datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")),
    "footer": {
      "text": "webhook by neptune#1995"
    }
  }
  webhook = DiscordWebhook(
    url=webhook_url,
    username="Hysteria",
    avatar_url="https://i.ibb.co/vdVKsbH/6qvnjs0s1xxvyj0di35am3lro.jpg")
  webhook.add_embed(Embed)
  try:
    webhook.execute()
  except:
    print("Time-In Webhook Error")
  return 1


def login_webhook(username, userdata):
  Embed = {
    "title":
    "@" + username + " has logged in",
    "description":
    "*Recieved login request from @" + username + "*",
    "url":
    "https://rec.net/user/" + username,
    "color":
    green,
    "timestamp":
    str(datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")),
    "footer": {
      "text": "webhook by neptune#1995"
    },
    "fields": [
      {
        "name":
        "> **Account Information**",
        "value":
        "**Available Username Changes:** `" +
        str(userdata["availableUsernameChanges"]) + "`" + "\n**Birthday:** `" +
        str(userdata["birthday"]) + "`" + "\n**Account ID:** `" +
        str(userdata["accountId"]) + "`" + "\n**Account Name:** `" +
        str(userdata["username"]) + "`" + "\n**Display Name:** `" +
        str(userdata["displayName"]) + "`" + "\n**Is Junior:** `" +
        str(userdata["isJunior"]) + "`" + "\n**Platforms:** `" +
        str(userdata["platforms"]) + "`" + "\n**Pronouns:** `" +
        str(userdata["personalPronouns"]) + "`" + "\n**Pride Flags:** `" +
        str(userdata["identityFlags"]) + "`" + "\n**Created At:** `" +
        str(userdata["createdAt"]) + "`" + "\n**LoginLock:** `" +
        str(userdata["LoginLock"]) + "`",
        "inline":
        False
      },
    ]
  }
  print(Embed)
  webhook = DiscordWebhook(
    url=webhook_url,
    username="Hysteria",
    avatar_url="https://i.ibb.co/vdVKsbH/6qvnjs0s1xxvyj0di35am3lro.jpg")
  webhook.add_embed(Embed)
  try:
    webhook.execute()
  except:
    print("Login Webhook Error")
  return 1


def desync_logout_webook(usernamefip):
  Embed = {
    "title": "A desynced player has logged out",
    "description":
    "*Logout request recieved from an ip which has no stored data*",
    "color": red,
    "timestamp": str(datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")),
    "footer": {
      "text": "webhook by neptune#1995"
    }
  }
  webhook = DiscordWebhook(
    url=webhook_url,
    username="Hysteria",
    avatar_url="https://i.ibb.co/vdVKsbH/6qvnjs0s1xxvyj0di35am3lro.jpg")
  webhook.add_embed(Embed)
  try:
    webhook.execute()
  except:
    print("Desync Logout Webhook Error")
  return 1


def logout_webhook(username):
  Embed = {
    "title": "@" + username + " has logged out",
    "description": "*Recieved logout request from @" + username + "*",
    "url": "https://rec.net/user/" + username,
    "color": red,
    "timestamp": str(datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")),
    "footer": {
      "text": "webhook by neptune#1995"
    }
  }
  print(Embed)
  webhook = DiscordWebhook(
    url=webhook_url,
    username="Hysteria",
    avatar_url="https://i.ibb.co/vdVKsbH/6qvnjs0s1xxvyj0di35am3lro.jpg")
  webhook.add_embed(Embed)
  try:
    webhook.execute()
  except:
    print("Logout Webhook Error")
  return 1
