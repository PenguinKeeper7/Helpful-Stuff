import sys

args = sys.argv

infile = open(args[1], "r")
outfile = open(args[2], "w")

try:
    separator = args[3]
except:
    separator = "SEP"

for x in infile:
    x = x.replace(":", separator, 1)
    x = separator.join(x.rsplit(":", 1))
    outfile.write(x)

infile.close()
outfile.close()
