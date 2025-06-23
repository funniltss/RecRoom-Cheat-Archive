import requests

# API URL
API_URL = "https://accounts.rec.net/account/me/displayName"

def update_display_name(auth_token, new_name):
    headers = {
        "Authorization": f"Bearer {auth_token}",
        "Content-Type": "application/json",
    }
    data = {"displayName": new_name}

    response = requests.post(API_URL, json=data, headers=headers)

    if response.status_code == 200:
        print("Done! Display name updated successfully.")
    else:
        print(f"Error: Failed to update display name. {response.text}")

def main():
    print("Enter Rec Room bearer token:")
    auth_token = input().strip()

    if not auth_token:
        print("Error: Bearer token cannot be empty.")
        return

    print("Enter the display name you want to use:")
    new_name = input().strip()

    if not new_name:
        print("Error: Display name cannot be empty.")
        return

    update_display_name(auth_token, new_name)

if __name__ == "__main__":
    main()
