

# stop containers

docker stop code.productapi
docker stop code.categoryapi
docker stop code.gateway     
docker stop code.db     



# remove containers

docker rm code.productapi
docker rm code.categoryapi
docker rm code.gateway
docker rm code.db

# remove images

docker rmi $(docker images 'code.productapi' -a -q)
docker rmi $(docker images 'code.categoryapi' -a -q)
docker rmi $(docker images 'code.gateway' -a -q)
docker rmi $(docker images 'code.db' -a -q)

# docker system prune -a  -af
docker builder prune -af
docker-compose --env-file ./config/.env.dev up -d --build 