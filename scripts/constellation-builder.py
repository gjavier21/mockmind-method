# 🌌 Script: Constellation Builder  
# Purpose: Auto-generate star-index headers from tile tags and emotional metadata

import os
import re
from collections import defaultdict

def extract_tags(file_path):
    with open(file_path, 'r') as f:
        content = f.read()
        tags = re.findall(r'## (.*?) Constellation', content)
        return tags

def build_constellations(directory):
    constellations = defaultdict(list)
    for filename in os.listdir(directory):
        if filename.endswith(".md"):
            path = os.path.join(directory, filename)
            tags = extract_tags(path)
            for tag in tags:
                constellations[tag].append(filename)
    return constellations

mesh = build_constellations("./tiles")
for constellation, files in mesh.items():
    print(f"## {constellation} Constellation")
    for file in files:
        print(f"- {file}")
