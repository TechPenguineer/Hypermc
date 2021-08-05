CC=gcc
OUTPUT_DIR=$(wildcard out/$@.o)
SRC=$(wildcard src/*.*)
CFLAGS= -Wall -o 
VERSION=1-0-0

build-exe: $(SRC)
	$(CC) -g $(SRC) $(CFLAGS) out/HyperMc-cli-$(VERSION)
	make build-obj

build-obj: 
	$(CC) -g $(SRC) $(CFLAGS) out/HyperMc-cli-$(VERSION).o

clean: 
	rm out/*.*