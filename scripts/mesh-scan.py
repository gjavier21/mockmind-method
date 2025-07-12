# 🧠 Script: Mesh Scan  
# Purpose: Validate tile links, glow index, and constellation integrity

import os
import re

def scan_tiles(directory):
    for filename in os.listdir(directory):
        if filename.endswith(".md"):
            with open(os.path.join(directory, filename), 'r') as f:
                content = f.read()
                links = re.findall(r'

\[.*?\]

\((.*?)\)', content)
                print(f"{filename}: {len(links)} links found")

scan_tiles("./tiles")
