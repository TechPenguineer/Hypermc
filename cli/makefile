CC=gcc
OUTPUT_DIR=$(wildcard out/$@.o)
SRC=$(wildcard src/*.c)
CFLAGS= -Wall -o 
VERSION=1-0-0

build: $(SRC)
	$(CC) -g $(SRC) $(CFLAGS) out/HyperMc-cli-$(VERSION)

clean: 
	rm out/*.*