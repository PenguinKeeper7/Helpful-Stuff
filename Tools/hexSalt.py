import sys, os

if not(len(sys.argv) == 3):
    print("Usage: python hexSalt.py inputFile.txt outputFile.txt")
    quit()

infile = open(sys.argv[1], "r")
outfile = open(sys.argv[2], "w")

for line in infile:
    line = line.rstrip("\n").split(":", 1)
    outfile.write(line[0] + ":" + line[1].encode("utf-8").hex() + "\n")

infile.close()
outfile.close()
