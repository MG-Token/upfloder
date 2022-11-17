# UPFloder

A service to bypass the restrictions of 1 to X Iranian servers...

# Install
#### Ubuntu:
```bash

sudo apt install gnupg ca-certificates

sudo apt-key adv –keyserver hkp://keyserver.ubuntu.com:80 –recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

echo deb https://download.mono-project.com/repo/ubuntu stable-focal main | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

sudo apt update

sudo apt upgrade

sudo apt install mono-complete wget unzip

//On Server Site:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder-server.linux.x86_x64.zip


```

