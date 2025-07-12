# 🌡️ Script: Glow Mapper  
# Purpose: Index glow scores across tiles and render tonal heatmaps

import os
import re

def extract_glow(file_path):
    with open(file_path, 'r') as f:
        content = f.read()
        match = re.search(r'Glow Index.*?(\d+)', content)
        return int(match.group(1)) if match else None

def map_glow(directory):
    glow_map = {}
    for filename in os.listdir(directory):
        if filename.endswith(".md"):
            path = os.path.join(directory, filename)
            glow = extract_glow(path)
            if glow is not None:
                glow_map[filename] = glow
    return glow_map

heatmap = map_glow("./tiles")
for tile, glow in sorted(heatmap.items(), key=lambda x: x[1], reverse=True):
    print(f"{tile}: Glow Index {glow}")
