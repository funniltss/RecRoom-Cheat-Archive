import time
from pypresence import Presence

CLIENT_ID = "1330654610049863702"  # Replace with your Discord app's client ID
RPC = Presence(CLIENT_ID)
RPC.connect()

try:
    RPC.update(state="Using the menu...", details="Rec Room Utilities")
    while True:
        time.sleep(15)  # Keep the status alive
except KeyboardInterrupt:
    RPC.clear()  # Clear the status when exiting




