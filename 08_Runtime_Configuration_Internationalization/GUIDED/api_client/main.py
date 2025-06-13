from config_env import get_base_url

import requests

def main():
    base_url = get_base_url()
    try:
        response = request.get(f"(base_url)/status")
        if response.status_code ==200:
            print("API aktif"), response.json()
        else:
            print("Gagal", response.status_code)
    except