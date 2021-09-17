#!/usr/bin/env bash

GIT_DIR=$(git rev-parse --git-dir)

echo "Installing hooks..."

# this command creates symlink to our pre-commit script
mkdir $GIT_DIR/hooks
ln -s ../../GitHelpers/pre-commit-hooks.bash $GIT_DIR/hooks/pre-commit

echo "Done!"
