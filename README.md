Bifrost, the bridge between Path Of Exile resources

# TBD

# For developers
## Setting up the environment
1. Install docker
2. 
	- Setup windows: docker-compose -f Bifrost.Infrastructure\docker-compose.yml up --force-recreate -d
	- Setup *nix: docker-compose -f Bifrost.Infrastructure/docker-compose.yml up --force-recreate -d
	- Teardown windows: docker-compose -f Bifrost.Infrastructure\docker-compose.yml down
	- Teardown *nix: docker-compose -f Bifrost.Infrastructure/docker-compose.yml down