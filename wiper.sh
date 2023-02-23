echo "Wiping server is 5 seconds"
sleep 5

TITLE="server_title/hostname"
SERVER="/home/rust/server1"
STEAM="/home/rust/Steam/steamcmd.sh"
PASSWORD="password"
WEBSITE="server_website"
####################
PORT=38015
QUERY=38016
RCON=38017
####################
MAP=3500
SEED=$(( $RANDOM * 100000 + $RANDOM * 1000 + $RANDOM % 1000 ))

echo "##########################################################"
echo "Exporting New Starter file with seed and map size e.t.c"
echo "#########################################################"
sleep 3

#############################################################################################
cat > $SERVER/start_server.sh <<EOF
#!/bin/sh
while :
do
 TERM=roxterm
 echo "Starting Server..."
 sleep 3

 $STEAM \+force_install_dir $SERVER \+login anonymous \+app_update 258550 \+quit

 echo "Updating Oxide..."
 sleep 3

 wget -c --inet4-only https://umod.org/games/rust/download/develop -O UmodUpdate.zip
 unzip -o UmodUpdate.zip
 rm UmodUpdate.zip

 echo "Starting.."
 sleep 3
 ./RustDedicated -batchmode -nographics -server.ip 0.0.0.0 -server.port $PORT -server.queryport $QUERY -rcon.ip 0.0.0.0 -rcon.port $RCON -rcon.password "$PASSWORD" -server.maxplayers 500 -server.level "Procedural Map" -server.seed $SEED -server.worldsize $MAP -server.hostname "$TITLE" -server.identity "my_server_identity" -server.saveinterval 300 -server.globalchat true -server.url "$WEBSITE"
 echo "\nRestarting server...\n"
done
EOF

#############################################################################################
echo "Deleting server map file."
sleep 3
cd $SERVER/server/my_server_identity && rm procedural*

#############################################################################################
echo "Server wiped! New Seeds: $SEED and map Size $MAP | Server will come online shortly"
