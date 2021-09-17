#!/usr/bin/env bash

# magic line to ensure that we're always inside the root of our application,
# no matter from which directory we'll run script
# thanks to it we can just enter `./Index/create-gitkeeps.bash`
cd "${0%/*}/.."

echo "Creating .gitkeeps..."

find . -type d -empty -not -path "./.git/*" -not -path "./Builds/*" -not -path "./Temp/*" -not -path "./Library/*"  -exec touch {}/.gitkeep \;

echo "Adding .gitkeeps to git..."
git ls-files -co --exclude-standard | grep '\.gitkeep$' | sed 's/ /\\ /g' | xargs git add
#find ../ -name .gitkeep | xargs git add

echo "Done!"

