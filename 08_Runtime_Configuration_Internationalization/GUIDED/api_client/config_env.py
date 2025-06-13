import os
from dotenv import load_dotenv

load dotenv()

def get_base_url():
    return os.getenv("BASE_URL")