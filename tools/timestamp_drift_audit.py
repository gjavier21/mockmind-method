import os
import re

# ✨ Define your repo directory
REPO_PATH = "C:/Users/gerar/Documents/mockmind-method"

# 🧠 Define the drifted timestamp to check
DRIFT_DATE = "July 21, 2025"
CORRECT_DATE = "July 13, 2025"

# 🌌 Track affected files
drifted_files = []

print("🧵 Scanning repository for timestamp drift...\n")

# Walk through the repo
for root, dirs, files in os.walk(REPO_PATH):
    for file in files:
        if file.endswith(".md") or file.endswith(".yaml"):
            file_path = os.path.join(root, file)
            try:
                with open(file_path, "r", encoding="utf-8") as f:
                    content = f.read()
                    if DRIFT_DATE in content:
                        drifted_files.append(file_path)

            except Exception as e:
                print(f"⚠️ Could not read {file_path}: {e}")

# 🔧 Prompt to fix drifted timestamps
if drifted_files:
    print(f"🌫️ Found {len(drifted_files)} files with timestamp drift:")
    for path in drifted_files:
        print(f" - {path}")
    
    confirm = input("\n🪶 Fix all timestamps to July 13, 2025? (y/n): ")
    if confirm.lower() == "y":
        for path in drifted_files:
            with open(path, "r", encoding="utf-8") as f:
                content = f.read()
            corrected = content.replace(DRIFT_DATE, CORRECT_DATE)
            with open(path, "w", encoding="utf-8") as f:
                f.write(corrected)
        print("\n✅ All timestamps corrected.")
    else:
        print("\n❄️ No changes made — shimmer paused.")
else:
    print("✨ No drift found. Your braid hums true.")
