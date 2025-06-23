import requests
import random
import string
from concurrent.futures import ThreadPoolExecutor
import time

def generate_random_username(length):
    return ''.join(random.choices(string.ascii_lowercase + string.digits + "_-", k=length))
def send_random_request(webhook_url, length):
    url = f"https://rec.net/_next/data/d0d54e3907fd18e108f328ca6dfad9e5651f4954/user/{generate_random_username(length)}.json?username={generate_random_username(length)}"
    headers = {'User-Agent': "Mozilla/5.0"}
    
    try:
        response = requests.get(url, headers=headers).json()
        username = response["pageProps"]["username"]
        if response["pageProps"].get("dehydratedState"):
            print(f"@{username} not available")
        else:
            print(f"@{username} available join our discord for more https://discord.gg/Fy5bZXm4Z3")
            requests.post(webhook_url, json={"content": f"✅ The username '{username}' is available!"})
    except (KeyError, ValueError):
        print("Error retrieving username")
def send_requests(webhook_url, count, length):
    with ThreadPoolExecutor(max_workers=1000) as executor:
        for _ in range(count):
            executor.submit(send_random_request, webhook_url, length)
def main():
    webhook_url = input("discord webhook URL>")
    checks_per_second = int(input("Checks per second>"))
    username_length = int(input("Username length:>"))
    
    while True:
        send_requests(webhook_url, checks_per_second, username_length)
        time.sleep(0)
if __name__ == "__main__":
    main()
