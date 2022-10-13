

# stop containers

docker stop code.productconsumerservice
docker stop code.productapi
docker stop code.categoryapi
docker stop code.gateway     
docker stop code.rabbitmq     
docker stop code.db     



# remove containers

docker rm code.db
docker rm code.rabbitmq
docker rm code.productconsumerservice
docker rm code.productapi
docker rm code.categoryapi
docker rm code.gateway

# remove images

docker rmi $(docker images 'db' -a -q)
docker rmi $(docker images 'rabbitmq' -a -q)
docker rmi $(docker images 'productconsumerservice' -a -q)
docker rmi $(docker images 'productapi' -a -q)
docker rmi $(docker images 'categoryapi' -a -q)
docker rmi $(docker images 'gateway' -a -q)


# remove all networks
docker network prune -af

# remove all volumes
docker volume rm $(docker volume ls -q)

# docker system prune -a  -af
docker builder prune -af
docker-compose --env-file ./config/.env.dev up -d --build 


# docker volume rm --filter "name!=portainer_portainer-docker-extension-desktop-extension_portainer_data"