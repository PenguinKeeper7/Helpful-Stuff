import sys

args = sys.argv

try:
    infile = open(args[1], "r")
except:
    print("Hashes file not found...")
    sys.exit()

outfile = open(args[2], "w")

try:
    separator = args[3]
except:
    separator = "SEPARATOR"

for x in infile:
    x = x.replace(":", separator, 1)
    x = separator.join(x.rsplit(":", 1))
    outfile.write(x)

infile.close()
outfile.close()
